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
    public partial class clsVendorMasterRepository : CommonRepositoryDomainBase<clsVendorMaster>, IclsVendorMasterDataProxy
    {
        public IEnumerable<clsVendorMaster> GetData(string Doc_No)
        {
            try
            {
            if (Doc_No == string.Empty)
            {
            return new List<clsVendorMaster>() { new clsVendorMaster() }.ToArray();
            }
            using (var context = GetDbContextDomain()) 
             { 
             var results = context.Set<clsVendorMaster>() 
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

        public IEnumerable<clsVendorMaster> GetAll(int start, int pageSize)
        {
            try
            {
            using (var context = GetDbContextDomain()) 
             { 
            var results = context.Set<clsVendorMaster>()
            .OrderByDescending(o => o.ID)
            .Select(q => new {
            q.ID
            ,q.Description
            }).ToArray().Select(o => new clsVendorMaster()
            {
            ID = o.ID
            ,Description = o.Description
            }).Skip(start).Take(pageSize);
             return results;
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public async Task<clsVendorMaster> GetDataAsync(string Doc_No)
        {
            try
            {
            if (Doc_No == string.Empty)
            {
            return new clsVendorMaster();
            }
            using (var context = GetDbContextDomain()) 
             { 
             var results =await context.Set<clsVendorMaster>() 
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

        public async Task<IEnumerable<clsVendorMaster>> GetAllAsync(int start, int pageSize, string SearchString = "", string OrderBy = "")
        {
            try
            {
            using (var context = GetDbContextDomain()) 
             { 
            var results = await context.Set<clsVendorMaster>()
            .Where(d =>d.ID.Contains(SearchString) || d.Description.Contains(SearchString) || SearchString==null || SearchString== String.Empty)
            .OrderByDescending(o => o.ID)
            .Select(q => new {
            q.ID
            ,q.Description
            }).Skip(start).Take(pageSize).ToListAsync();
            return results.Select(o => new clsVendorMaster()
            {
            ID = o.ID
            ,Description = o.Description
            });
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public override clsVendorMaster Update(clsVendorMaster entity)
        {
            var trans = XSDBFunctionality.GetTransactin();
            try
            {
            var conn = XSDBFunctionality.GetConnnection;
            using (var context = GetDbContextDomain(conn,contextOwnsConnection: false))
             { 
            context.Database.UseTransaction(trans);
            //get eisting entry  
            var ExistEntity = context.Set<clsVendorMaster>()
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

        public override async Task<clsVendorMaster> UpdateAsync(clsVendorMaster entity)
        {
            var trans = XSDBFunctionality.GetTransactin();
            try
            {
            var conn = XSDBFunctionality.GetConnnection;
            using (var context = GetDbContextDomain(conn,contextOwnsConnection: false))
             { 
            context.Database.UseTransaction(trans);
            //get eisting entry  
            var ExistEntity = context.Set<clsVendorMaster>()
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
            Func<clsVendorMaster, bool> dynamicWhere = new Func<clsVendorMaster, bool>(x => true);
            if (whereExpression != null && whereExpression.Length > 0)
             { 
               dynamicWhere = interpreter.ParseAsDelegate<Func<clsVendorMaster, bool>>(whereExpression, "obj");
             } 
             using (var context = GetDbContextDomain())
             { 
             var results = await context.Set<clsVendorMaster>() 
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
            Func<clsVendorMaster, bool> dynamicWhere = new Func<clsVendorMaster, bool>(x => true); 
            if (whereExpression != null && whereExpression.Length > 0)
            {
            dynamicWhere = interpreter.ParseAsDelegate<Func<clsVendorMaster, bool>>(whereExpression, "obj"); 
            }
             using (var context = GetDbContextDomain())
             { 
             count=  context.Set<clsVendorMaster>()//.GroupBy(x => x.ID) 
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
    }
}
