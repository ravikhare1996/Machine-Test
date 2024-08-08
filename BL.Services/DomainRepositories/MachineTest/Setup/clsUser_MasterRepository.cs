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
    public partial class clsUser_MasterRepository : CommonRepositoryDomainBase<clsUser_Master>, IclsUser_MasterDataProxy
    {
        public IEnumerable<clsUser_Master> GetData(string Doc_No)
        {
            try
            {
            if (Doc_No == string.Empty)
            {
            return new List<clsUser_Master>() { new clsUser_Master() }.ToArray();
            }
            using (var context = GetDbContextDomain()) 
             { 
             var results = context.Set<clsUser_Master>() 
            .Where(p => p.ID == Doc_No) 
            .Include(TL => TL.Trans_Link_Data)
            .ToArray(); 
             return results;
             } 
            }
            catch (Exception ex)
            {
            throw;
            }
        }

        public IEnumerable<clsUser_Master> GetAll(int start, int pageSize)
        {
            try
            {
            using (var context = GetDbContextDomain()) 
             { 
            var results = context.Set<clsUser_Master>()
            .OrderByDescending(o => o.ID)
            .Select(q => new {
            q.ID
            ,q.Password
            ,q.Description
            ,q.User_Type
            ,q.Client
            ,q.PanCard
            ,q.PanCard_FilePath
            ,q.PanCard_FileName
            ,q.PanCard_ContentType
            ,q.E_mail
            ,q.Phone
            }).ToArray().Select(o => new clsUser_Master()
            {
            ID = o.ID
            ,Password = o.Password
            ,Description = o.Description
            ,User_Type = o.User_Type
            ,Client = o.Client
            ,PanCard = o.PanCard
            ,PanCard_FilePath = o.PanCard_FilePath
            ,PanCard_FileName = o.PanCard_FileName
            ,PanCard_ContentType = o.PanCard_ContentType
            ,E_mail = o.E_mail
            ,Phone = o.Phone
            }).Skip(start).Take(pageSize);
             return results;
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public async Task<clsUser_Master> GetDataAsync(string Doc_No)
        {
            try
            {
            if (Doc_No == string.Empty)
            {
            return new clsUser_Master();
            }
            using (var context = GetDbContextDomain()) 
             { 
             var results =await context.Set<clsUser_Master>() 
            .Where(p => p.ID == Doc_No) 
            .Include(TL => TL.Trans_Link_Data)
            .ToListAsync(); 
             return results.FirstOrDefault();
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public async Task<IEnumerable<clsUser_Master>> GetAllAsync(int start, int pageSize, string SearchString = "", string OrderBy = "")
        {
            try
            {
            using (var context = GetDbContextDomain()) 
             { 
            var results = await context.Set<clsUser_Master>()
            .Where(d =>d.ID.Contains(SearchString) || d.Description.Contains(SearchString) || SearchString==null || SearchString== String.Empty)
            .OrderByDescending(o => o.ID)
            .Select(q => new {
            q.ID
            ,q.Password
            ,q.Description
            ,q.User_Type
            ,q.Client
            ,q.PanCard
            ,q.PanCard_FilePath
            ,q.PanCard_FileName
            ,q.PanCard_ContentType
            ,q.E_mail
            ,q.Phone
            }).Skip(start).Take(pageSize).ToListAsync();
            return results.Select(o => new clsUser_Master()
            {
            ID = o.ID
            ,Password = o.Password
            ,Description = o.Description
            ,User_Type = o.User_Type
            ,Client = o.Client
            ,PanCard = o.PanCard
            ,PanCard_FilePath = o.PanCard_FilePath
            ,PanCard_FileName = o.PanCard_FileName
            ,PanCard_ContentType = o.PanCard_ContentType
            ,E_mail = o.E_mail
            ,Phone = o.Phone
            });
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public override clsUser_Master Update(clsUser_Master entity)
        {
            var trans = XSDBFunctionality.GetTransactin();
            try
            {
            var conn = XSDBFunctionality.GetConnnection;
            using (var context = GetDbContextDomain(conn,contextOwnsConnection: false))
             { 
            context.Database.UseTransaction(trans);
            //get eisting entry  
            var ExistEntity = context.Set<clsUser_Master>()
            .Where(p => p.ID == entity.ID)
            .Include(TL => TL.Trans_Link_Data)
            ;
            if (ExistEntity != null && ExistEntity.FirstOrDefault() != null)
            {
            //OnBeforeUpdateExecuted  
            OnBeforeUpdateExecuted(context, entity);
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
            ExistEntity.FirstOrDefault().Password = entity.Password;
            ExistEntity.FirstOrDefault().User_Type = entity.User_Type;
            ExistEntity.FirstOrDefault().Client = entity.Client;
            ExistEntity.FirstOrDefault().PanCard = entity.PanCard;
            ExistEntity.FirstOrDefault().PanCard_FilePath = entity.PanCard_FilePath;
            ExistEntity.FirstOrDefault().PanCard_FileName = entity.PanCard_FileName;
            ExistEntity.FirstOrDefault().PanCard_ContentType = entity.PanCard_ContentType;
            ExistEntity.FirstOrDefault().E_mail = entity.E_mail;
            ExistEntity.FirstOrDefault().Phone = entity.Phone;
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

        public override async Task<clsUser_Master> UpdateAsync(clsUser_Master entity)
        {
            var trans = XSDBFunctionality.GetTransactin();
            try
            {
            var conn = XSDBFunctionality.GetConnnection;
            using (var context = GetDbContextDomain(conn,contextOwnsConnection: false))
             { 
            context.Database.UseTransaction(trans);
            //get eisting entry  
            var ExistEntity = context.Set<clsUser_Master>()
            .Where(p => p.ID == entity.ID)
            .Include(TL => TL.Trans_Link_Data)
            ;
            if (ExistEntity != null && ExistEntity.FirstOrDefault() != null)
            {
            //OnBeforeUpdateExecutedAsync  
            await OnBeforeUpdateExecutedAsync(context, entity);
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
            ExistEntity.FirstOrDefault().Password = entity.Password;
            ExistEntity.FirstOrDefault().User_Type = entity.User_Type;
            ExistEntity.FirstOrDefault().Client = entity.Client;
            ExistEntity.FirstOrDefault().PanCard = entity.PanCard;
            ExistEntity.FirstOrDefault().PanCard_FilePath = entity.PanCard_FilePath;
            ExistEntity.FirstOrDefault().PanCard_FileName = entity.PanCard_FileName;
            ExistEntity.FirstOrDefault().PanCard_ContentType = entity.PanCard_ContentType;
            ExistEntity.FirstOrDefault().E_mail = entity.E_mail;
            ExistEntity.FirstOrDefault().Phone = entity.Phone;
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
            Func<clsUser_Master, bool> dynamicWhere = new Func<clsUser_Master, bool>(x => true);
            if (whereExpression != null && whereExpression.Length > 0)
             { 
               dynamicWhere = interpreter.ParseAsDelegate<Func<clsUser_Master, bool>>(whereExpression, "obj");
             } 
             using (var context = GetDbContextDomain())
             { 
             var results = await context.Set<clsUser_Master>() 
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
            Func<clsUser_Master, bool> dynamicWhere = new Func<clsUser_Master, bool>(x => true); 
            if (whereExpression != null && whereExpression.Length > 0)
            {
            dynamicWhere = interpreter.ParseAsDelegate<Func<clsUser_Master, bool>>(whereExpression, "obj"); 
            }
             using (var context = GetDbContextDomain())
             { 
             count=  context.Set<clsUser_Master>()//.GroupBy(x => x.ID) 
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

        public async virtual Task<IEnumerable<FinderData>> GetUser_TypeList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            objList.Add(new FinderData() { Code = "Level 1", Name = "Level 1" });
            objList.Add(new FinderData() { Code = "Level 2", Name = "Level 2" });
            objList.Add(new FinderData() { Code = "Level 3", Name = "Level 3" });
            objList.Add(new FinderData() { Code = "Level 4", Name = "Level 4" });
            });
            return objList;
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task<IEnumerable<FinderData>> GetClientList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            var qry = " select [Client_Id] as Code,[Client_Name] as Name from [CLIENT_MASTER] ";
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
    }
}
