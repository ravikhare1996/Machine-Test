using  System;
using  System.Collections.Generic;
using  System.ComponentModel;
using  Microsoft.EntityFrameworkCore;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;
using  XpertStudio.Framework.Domain;
using  XpertStudio.Framework.Attributes;
using  XpertStudio.UI.Repository;
using  XpertStudio.Common.Repository;
using  XpertStudio.Common.Database;
using  XpertStudio.Common.Functions;
using  System.Data;
using  XpertStudio.Common.Enums;
using  XpertStudio.Common.Attributes;
using  MachineTest.Domain.Entities;
using  MachineTest.Services.Interfaces;
using  common.OFM;
using  XpertStudio.Common.Data;
using  DynamicExpresso;

namespace MachineTest.Services.DomainRepositories
{
    [Description("Domain Repository Class")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsPurchaseOrderRepository : CommonRepositoryDomainBase<clsPurchaseOrder>, IclsPurchaseOrderDataProxy
    {
        public IEnumerable<clsPurchaseOrder> GetData(string Doc_No)
        {
            try
            {
            if (Doc_No == string.Empty)
            {
            return new List<clsPurchaseOrder>() { new clsPurchaseOrder() }.ToArray();
            }
            using (var context = GetDbContextDomain()) 
             { 
             var results = context.Set<clsPurchaseOrder>() 
            .Where(p => p.ID == Doc_No) 
             .Include(b0 => b0.PO_ItemList) 
             .Include(b1 => b1.PO_Items) 
            .ToArray(); 
             return results;
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public IEnumerable<clsPurchaseOrder> GetAll(int start, int pageSize)
        {
            try
            {
            using (var context = GetDbContextDomain()) 
             { 
            var results = context.Set<clsPurchaseOrder>()
            .OrderByDescending(o => o.ID)
             .Include(b0 => b0.PO_ItemList) 
             .Include(b1 => b1.PO_Items) 
            .Select(q => new {
            q.ID
            ,q.PORemarks
            ,q.Description
            ,q.POVCode
            ,q.ModifiyDate
            ,q.CreateDate
            ,q.PODate
            ,q.POTotAmt
            ,q.filePhoto
            ,q.filePhoto_FilePath
            ,q.filePhoto_FileName
            ,q.filePhoto_ContentType
            ,q.PO_Options
            }).ToArray().Select(o => new clsPurchaseOrder()
            {
            ID = o.ID
            ,PORemarks = o.PORemarks
            ,Description = o.Description
            ,POVCode = o.POVCode
            ,ModifiyDate = o.ModifiyDate
            ,CreateDate = o.CreateDate
            ,PODate = o.PODate
            ,POTotAmt = o.POTotAmt
            ,filePhoto = o.filePhoto
            ,filePhoto_FilePath = o.filePhoto_FilePath
            ,filePhoto_FileName = o.filePhoto_FileName
            ,filePhoto_ContentType = o.filePhoto_ContentType
            ,PO_Options = o.PO_Options
            }).Skip(start).Take(pageSize);
             return results;
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public async Task<clsPurchaseOrder> GetDataAsync(string Doc_No)
        {
            try
            {
            if (Doc_No == string.Empty)
            {
            return new clsPurchaseOrder();
            }
            using (var context = GetDbContextDomain()) 
             { 
             var results =await context.Set<clsPurchaseOrder>() 
            .Where(p => p.ID == Doc_No) 
             .Include(b0 => b0.PO_ItemList) 
             .Include(b1 => b1.PO_Items) 
            .ToListAsync();
            foreach (var item in results.FirstOrDefault().PO_Items)
            {
               item.ItemName = XpertCommonFunctions.myCstr(XSDBFunctionality.getSingleValue("select IName from TSPL_ITEM_MASTER where ICode='" + item.POICode + "'"));
            }
             return results.FirstOrDefault();
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public async Task<IEnumerable<clsPurchaseOrder>> GetAllAsync(int start, int pageSize, string SearchString = "", string OrderBy = "")
        {
            try
            {
            using (var context = GetDbContextDomain()) 
             { 
            var results = await context.Set<clsPurchaseOrder>()
            .Where(d =>d.ID.Contains(SearchString) || d.Description.Contains(SearchString) || SearchString==null || SearchString== String.Empty)
            .OrderByDescending(o => o.ID)
             .Include(b0 => b0.PO_ItemList) 
             .Include(b1 => b1.PO_Items) 
            .Select(q => new {
            q.ID
            ,q.PORemarks
            ,q.Description
            ,q.POVCode
            ,q.ModifiyDate
            ,q.CreateDate
            ,q.PODate
            ,q.POTotAmt
            ,q.filePhoto
            ,q.filePhoto_FilePath
            ,q.filePhoto_FileName
            ,q.filePhoto_ContentType
            ,q.PO_Options
            }).Skip(start).Take(pageSize).ToListAsync();
            return results.Select(o => new clsPurchaseOrder()
            {
            ID = o.ID
            ,PORemarks = o.PORemarks
            ,Description = o.Description
            ,POVCode = o.POVCode
            ,ModifiyDate = o.ModifiyDate
            ,CreateDate = o.CreateDate
            ,PODate = o.PODate
            ,POTotAmt = o.POTotAmt
            ,filePhoto = o.filePhoto
            ,filePhoto_FilePath = o.filePhoto_FilePath
            ,filePhoto_FileName = o.filePhoto_FileName
            ,filePhoto_ContentType = o.filePhoto_ContentType
            ,PO_Options = o.PO_Options
            });
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public override clsPurchaseOrder Update(clsPurchaseOrder entity)
        {
            var trans = XSDBFunctionality.GetTransactin();
            try
            {
            var conn = XSDBFunctionality.GetConnnection;
            using (var context = GetDbContextDomain(conn,contextOwnsConnection: false))
             { 
            context.Database.UseTransaction(trans);
            //get eisting entry  
            var ExistEntity = context.Set<clsPurchaseOrder>()
            .Where(p => p.ID == entity.ID)
            .Include(b => b.PO_ItemList)
            .Include(b => b.PO_Items)
            ;
            if (ExistEntity != null && ExistEntity.FirstOrDefault() != null)
            {
            //OnBeforeUpdateExecuted  
            OnBeforeUpdateExecuted(context, entity);
            context.Set<clsFinderItems>().RemoveRange(ExistEntity.FirstOrDefault().PO_ItemList);
            context.Set<clsPO_Item>().RemoveRange(ExistEntity.FirstOrDefault().PO_Items);
            context.SaveChanges();
             context.Set<clsFinderItems>().AddRange(entity.PO_ItemList);
             context.Set<clsPO_Item>().AddRange(entity.PO_Items);
            context.SaveChanges();
            //trans link reference docs
            if (ExistEntity.FirstOrDefault().Trans_Link_Data != null)
            {
            context.Set<XpertTransLinkData>().RemoveRange(ExistEntity.FirstOrDefault().Trans_Link_Data);
            context.SaveChanges();
            }
            if (entity.Trans_Link_Data != null && entity.Trans_Link_Data.Count() > 0)
            {
             context.Set<XpertTransLinkData>().AddRange(entity.Trans_Link_Data);
            context.SaveChanges();
            }
            //trans link data end
            ExistEntity.FirstOrDefault().Description = entity.Description;
            ExistEntity.FirstOrDefault().ID = entity.ID;
            ExistEntity.FirstOrDefault().LastModifiedDatetime = DateTime.Now;
            ExistEntity.FirstOrDefault().PORemarks = entity.PORemarks;
            ExistEntity.FirstOrDefault().POVCode = entity.POVCode;
            ExistEntity.FirstOrDefault().ModifiyDate = entity.ModifiyDate;
            ExistEntity.FirstOrDefault().CreateDate = entity.CreateDate;
            ExistEntity.FirstOrDefault().PODate = entity.PODate;
            ExistEntity.FirstOrDefault().POTotAmt = entity.POTotAmt;
            ExistEntity.FirstOrDefault().filePhoto = entity.filePhoto;
            ExistEntity.FirstOrDefault().filePhoto_FilePath = entity.filePhoto_FilePath;
            ExistEntity.FirstOrDefault().filePhoto_FileName = entity.filePhoto_FileName;
            ExistEntity.FirstOrDefault().filePhoto_ContentType = entity.filePhoto_ContentType;
            ExistEntity.FirstOrDefault().PO_Options = entity.PO_Options;
            context.SaveChanges();
            //OnAfterUpdateExecuted  
            OnAfterUpdateExecuted(context, entity);
            trans.Commit();
            conn.Close();
            }
            return entity;
            }
            }
            catch (Exception)
            {
            trans.Rollback();
            throw;
            }
        }

        public override async Task<clsPurchaseOrder> UpdateAsync(clsPurchaseOrder entity)
        {
            var trans = XSDBFunctionality.GetTransactin();
            try
            {
            var conn = XSDBFunctionality.GetConnnection;
            using (var context = GetDbContextDomain(conn,contextOwnsConnection: false))
             { 
            context.Database.UseTransaction(trans);
            //get eisting entry  
            var ExistEntity = context.Set<clsPurchaseOrder>()
            .Where(p => p.ID == entity.ID)
            .Include(b => b.PO_ItemList)
            .Include(b => b.PO_Items)
            ;
            if (ExistEntity != null && ExistEntity.FirstOrDefault() != null)
            {
            //OnBeforeUpdateExecutedAsync  
            await OnBeforeUpdateExecutedAsync(context, entity);
            context.Set<clsFinderItems>().RemoveRange(ExistEntity.FirstOrDefault().PO_ItemList);
            context.Set<clsPO_Item>().RemoveRange(ExistEntity.FirstOrDefault().PO_Items);
            await context.SaveChangesAsync();
             context.Set<clsFinderItems>().AddRange(entity.PO_ItemList);
             context.Set<clsPO_Item>().AddRange(entity.PO_Items);
            await context.SaveChangesAsync();
            //trans link reference docs
            if (ExistEntity.FirstOrDefault().Trans_Link_Data != null)
            {
            context.Set<XpertTransLinkData>().RemoveRange(ExistEntity.FirstOrDefault().Trans_Link_Data);
            await context.SaveChangesAsync();
            }
            if (entity.Trans_Link_Data != null && entity.Trans_Link_Data.Count() > 0)
            {
             context.Set<XpertTransLinkData>().AddRange(entity.Trans_Link_Data);
            await context.SaveChangesAsync();
            }
            //trans link data end
            ExistEntity.FirstOrDefault().Description = entity.Description;
            ExistEntity.FirstOrDefault().ID = entity.ID;
            ExistEntity.FirstOrDefault().LastModifiedDatetime = DateTime.Now;
            ExistEntity.FirstOrDefault().PORemarks = entity.PORemarks;
            ExistEntity.FirstOrDefault().POVCode = entity.POVCode;
            ExistEntity.FirstOrDefault().ModifiyDate = entity.ModifiyDate;
            ExistEntity.FirstOrDefault().CreateDate = entity.CreateDate;
            ExistEntity.FirstOrDefault().PODate = entity.PODate;
            ExistEntity.FirstOrDefault().POTotAmt = entity.POTotAmt;
            ExistEntity.FirstOrDefault().filePhoto = entity.filePhoto;
            ExistEntity.FirstOrDefault().filePhoto_FilePath = entity.filePhoto_FilePath;
            ExistEntity.FirstOrDefault().filePhoto_FileName = entity.filePhoto_FileName;
            ExistEntity.FirstOrDefault().filePhoto_ContentType = entity.filePhoto_ContentType;
            ExistEntity.FirstOrDefault().PO_Options = entity.PO_Options;
            await context.SaveChangesAsync();
            //OnAfterUpdateExecutedAsync  
            await OnAfterUpdateExecutedAsync(context, entity);
            trans.Commit();
            conn.Close();
            }
            return entity;
            }
            }
            catch (Exception)
            {
            trans.Rollback();
            throw;
            }
        }

        public async Task<IEnumerable<IFinderData>> GetFinder(string whereExpression)
        {
            try
            {
            var interpreter = new Interpreter();
            Func<clsPurchaseOrder, bool> dynamicWhere = new Func<clsPurchaseOrder, bool>(x => true);
            if (whereExpression != null && whereExpression.Length > 0)
             { 
               dynamicWhere = interpreter.ParseAsDelegate<Func<clsPurchaseOrder, bool>>(whereExpression, "obj");
             } 
             using (var context = GetDbContextDomain())
             { 
             var results = await context.Set<clsPurchaseOrder>() 
             //.Where(dynamicWhere) //not working in EF6 so it will be uncommented after upgrading to efcore6 or higher versions.
             .Select(q => new { 
             q.ID, 
             q.Description, 
             q.IsDefault 
             }).AsQueryable().ToListAsync();
            return results.Select(o => new FinderData()
             { 
             Code = o.ID, 
             Name = o.Description, 
             IsDefault=o.IsDefault 
             }); 
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public async Task<int> GetCount(string whereExpression)
        {
            try
            {
            int count = 0;
            await Task.Run(() => 
            {
             var interpreter = new Interpreter();
            Func<clsPurchaseOrder, bool> dynamicWhere = new Func<clsPurchaseOrder, bool>(x => true); 
            if (whereExpression != null && whereExpression.Length > 0)
            {
            dynamicWhere = interpreter.ParseAsDelegate<Func<clsPurchaseOrder, bool>>(whereExpression, "obj"); 
            }
             using (var context = GetDbContextDomain())
             { 
             count=  context.Set<clsPurchaseOrder>()//.GroupBy(x => x.ID) 
             .AsEnumerable() 
             .Where(dynamicWhere)
             .Count(); 
              }
            }
            );
             return  count;
            }
            catch (Exception)
            {
            throw;
            }
        }

        public async virtual Task<IEnumerable<FinderData>> GetPO_ItemListList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            var qry = " select [ICode] as Code,[IName] as Name from [TSPL_ITEM_MASTER] ";
            var dt = XSDBFunctionality.GetDataTable(qry);
            foreach (DataRow item in dt.Rows)
            {
            objTr = new FinderData();
            objTr.Code = XpertCommonFunctions.myCstr(item["Code"]);
            objTr.Name = XpertCommonFunctions.myCstr(item["Name"]);
            objList.Add(objTr);
            }
            });
            return objList;
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task<IEnumerable<FinderData>> GetPOICodeList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            var qry = " select [ICode] as Code,[IName] as Name from [TSPL_ITEM_MASTER] ";
            var dt = XSDBFunctionality.GetDataTable(qry);
            foreach (DataRow item in dt.Rows)
            {
            objTr = new FinderData();
            objTr.Code = XpertCommonFunctions.myCstr(item["Code"]);
            objTr.Name = XpertCommonFunctions.myCstr(item["Name"]);
            objList.Add(objTr);
            }
            });
            return objList;
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }
[XSCodeType(Type = XSCodeType.Custom)]
        public Task<IEnumerable<FinderData>> GetPOItemListList(string FinderType, string WhereExpression)
        {
            throw new NotImplementedException();
        }
[XSCodeType(Type = XSCodeType.Custom)]
        public async Task<IEnumerable<FinderData>> GetStatusList(string FinderType, string WhereExpression)
        {
            List<FinderData> StatusList = new List<FinderData>();
            try
            {
                await Task.Run(() =>
                {
                    StatusList.Add(new FinderData() { Code = "Y", Name = "Yes", IsDefault = true });
                    StatusList.Add(new FinderData() { Code = "N", Name = "No" });
                });
                return StatusList;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
