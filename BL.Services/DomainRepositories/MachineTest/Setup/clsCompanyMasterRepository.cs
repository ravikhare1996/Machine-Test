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
    public partial class clsCompanyMasterRepository : CommonRepositoryDomainBase<clsCompanyMaster>, IclsCompanyMasterDataProxy
    {
        public IEnumerable<clsCompanyMaster> GetData(string Doc_No)
        {
            try
            {
            if (Doc_No == string.Empty)
            {
            return new List<clsCompanyMaster>() { new clsCompanyMaster() }.ToArray();
            }
            using (var context = GetDbContextDomain()) 
             { 
             var results = context.Set<clsCompanyMaster>() 
            .Where(p => p.ID == Doc_No) 
            .ToArray(); 
             return results;
             } 
            }
            catch (Exception ex)
            {
            throw;
            }
        }

        public IEnumerable<clsCompanyMaster> GetAll(int start, int pageSize)
        {
            try
            {
            using (var context = GetDbContextDomain()) 
             { 
            var results = context.Set<clsCompanyMaster>()
            .OrderByDescending(o => o.ID)
            .Select(q => new {
            q.ID
            ,q.Comp_Loc_Seg
            ,q.Phone2
            ,q.Email
            ,q.Pincode
            ,q.Phone1
            ,q.City_Code
            ,q.Add3
            ,q.Add2
            ,q.Add1
            ,q.Description
            ,q.Company_Type
            ,q.Branch_Type
            ,q.Product
            ,q.State
            ,q.Non_Analyzed_Work_Hour
            ,q.Password
            ,q.EmailID_From
            ,q.Port
            ,q.SMTP_Client
            }).ToArray().Select(o => new clsCompanyMaster()
            {
            ID = o.ID
            ,Comp_Loc_Seg = o.Comp_Loc_Seg
            ,Phone2 = o.Phone2
            ,Email = o.Email
            ,Pincode = o.Pincode
            ,Phone1 = o.Phone1
            ,City_Code = o.City_Code
            ,Add3 = o.Add3
            ,Add2 = o.Add2
            ,Add1 = o.Add1
            ,Description = o.Description
            ,Company_Type = o.Company_Type
            ,Branch_Type = o.Branch_Type
            ,Product = o.Product
            ,State = o.State
            ,Non_Analyzed_Work_Hour = o.Non_Analyzed_Work_Hour
            ,Password = o.Password
            ,EmailID_From = o.EmailID_From
            ,Port = o.Port
            ,SMTP_Client = o.SMTP_Client
            }).Skip(start).Take(pageSize);
             return results;
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public async Task<clsCompanyMaster> GetDataAsync(string Doc_No)
        {
            try
            {
            if (Doc_No == string.Empty)
            {
            return new clsCompanyMaster();
            }
            using (var context = GetDbContextDomain()) 
             { 
             var results =await context.Set<clsCompanyMaster>() 
            .Where(p => p.ID == Doc_No) 
            .ToListAsync(); 
             return results.FirstOrDefault();
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public async Task<IEnumerable<clsCompanyMaster>> GetAllAsync(int start, int pageSize, string SearchString = "", string OrderBy = "")
        {
            try
            {
            using (var context = GetDbContextDomain()) 
             { 
            var results = await context.Set<clsCompanyMaster>()
            .Where(d =>d.ID.Contains(SearchString) || d.Description.Contains(SearchString) || SearchString==null || SearchString== String.Empty)
            .OrderByDescending(o => o.ID)
            .Select(q => new {
            q.ID
            ,q.Comp_Loc_Seg
            ,q.Phone2
            ,q.Email
            ,q.Pincode
            ,q.Phone1
            ,q.City_Code
            ,q.Add3
            ,q.Add2
            ,q.Add1
            ,q.Description
            ,q.Company_Type
            ,q.Branch_Type
            ,q.Product
            ,q.State
            ,q.Non_Analyzed_Work_Hour
            ,q.Password
            ,q.EmailID_From
            ,q.Port
            ,q.SMTP_Client
            }).Skip(start).Take(pageSize).ToListAsync();
            return results.Select(o => new clsCompanyMaster()
            {
            ID = o.ID
            ,Comp_Loc_Seg = o.Comp_Loc_Seg
            ,Phone2 = o.Phone2
            ,Email = o.Email
            ,Pincode = o.Pincode
            ,Phone1 = o.Phone1
            ,City_Code = o.City_Code
            ,Add3 = o.Add3
            ,Add2 = o.Add2
            ,Add1 = o.Add1
            ,Description = o.Description
            ,Company_Type = o.Company_Type
            ,Branch_Type = o.Branch_Type
            ,Product = o.Product
            ,State = o.State
            ,Non_Analyzed_Work_Hour = o.Non_Analyzed_Work_Hour
            ,Password = o.Password
            ,EmailID_From = o.EmailID_From
            ,Port = o.Port
            ,SMTP_Client = o.SMTP_Client
            });
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public override clsCompanyMaster Update(clsCompanyMaster entity)
        {
            var trans = XSDBFunctionality.GetTransactin();
            try
            {
            var conn = XSDBFunctionality.GetConnnection;
            using (var context = GetDbContextDomain(conn,contextOwnsConnection: false))
             { 
            context.Database.UseTransaction(trans);
            //get eisting entry  
            var ExistEntity = context.Set<clsCompanyMaster>()
            .Where(p => p.ID == entity.ID)
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
            ExistEntity.FirstOrDefault().Comp_Loc_Seg = entity.Comp_Loc_Seg;
            ExistEntity.FirstOrDefault().Phone2 = entity.Phone2;
            ExistEntity.FirstOrDefault().Email = entity.Email;
            ExistEntity.FirstOrDefault().Pincode = entity.Pincode;
            ExistEntity.FirstOrDefault().Phone1 = entity.Phone1;
            ExistEntity.FirstOrDefault().City_Code = entity.City_Code;
            ExistEntity.FirstOrDefault().Add3 = entity.Add3;
            ExistEntity.FirstOrDefault().Add2 = entity.Add2;
            ExistEntity.FirstOrDefault().Add1 = entity.Add1;
            ExistEntity.FirstOrDefault().Company_Type = entity.Company_Type;
            ExistEntity.FirstOrDefault().Branch_Type = entity.Branch_Type;
            ExistEntity.FirstOrDefault().Product = entity.Product;
            ExistEntity.FirstOrDefault().State = entity.State;
            ExistEntity.FirstOrDefault().Non_Analyzed_Work_Hour = entity.Non_Analyzed_Work_Hour;
            ExistEntity.FirstOrDefault().Password = entity.Password;
            ExistEntity.FirstOrDefault().EmailID_From = entity.EmailID_From;
            ExistEntity.FirstOrDefault().Port = entity.Port;
            ExistEntity.FirstOrDefault().SMTP_Client = entity.SMTP_Client;
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

        public override async Task<clsCompanyMaster> UpdateAsync(clsCompanyMaster entity)
        {
            var trans = XSDBFunctionality.GetTransactin();
            try
            {
            var conn = XSDBFunctionality.GetConnnection;
            using (var context = GetDbContextDomain(conn,contextOwnsConnection: false))
             { 
            context.Database.UseTransaction(trans);
            //get eisting entry  
            var ExistEntity = context.Set<clsCompanyMaster>()
            .Where(p => p.ID == entity.ID)
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
            ExistEntity.FirstOrDefault().Comp_Loc_Seg = entity.Comp_Loc_Seg;
            ExistEntity.FirstOrDefault().Phone2 = entity.Phone2;
            ExistEntity.FirstOrDefault().Email = entity.Email;
            ExistEntity.FirstOrDefault().Pincode = entity.Pincode;
            ExistEntity.FirstOrDefault().Phone1 = entity.Phone1;
            ExistEntity.FirstOrDefault().City_Code = entity.City_Code;
            ExistEntity.FirstOrDefault().Add3 = entity.Add3;
            ExistEntity.FirstOrDefault().Add2 = entity.Add2;
            ExistEntity.FirstOrDefault().Add1 = entity.Add1;
            ExistEntity.FirstOrDefault().Company_Type = entity.Company_Type;
            ExistEntity.FirstOrDefault().Branch_Type = entity.Branch_Type;
            ExistEntity.FirstOrDefault().Product = entity.Product;
            ExistEntity.FirstOrDefault().State = entity.State;
            ExistEntity.FirstOrDefault().Non_Analyzed_Work_Hour = entity.Non_Analyzed_Work_Hour;
            ExistEntity.FirstOrDefault().Password = entity.Password;
            ExistEntity.FirstOrDefault().EmailID_From = entity.EmailID_From;
            ExistEntity.FirstOrDefault().Port = entity.Port;
            ExistEntity.FirstOrDefault().SMTP_Client = entity.SMTP_Client;
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
            Func<clsCompanyMaster, bool> dynamicWhere = new Func<clsCompanyMaster, bool>(x => true);
            if (whereExpression != null && whereExpression.Length > 0)
             { 
               dynamicWhere = interpreter.ParseAsDelegate<Func<clsCompanyMaster, bool>>(whereExpression, "obj");
             } 
             using (var context = GetDbContextDomain())
             { 
             var results = await context.Set<clsCompanyMaster>() 
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
            Func<clsCompanyMaster, bool> dynamicWhere = new Func<clsCompanyMaster, bool>(x => true); 
            if (whereExpression != null && whereExpression.Length > 0)
            {
            dynamicWhere = interpreter.ParseAsDelegate<Func<clsCompanyMaster, bool>>(whereExpression, "obj"); 
            }
             using (var context = GetDbContextDomain())
             { 
             count=  context.Set<clsCompanyMaster>()//.GroupBy(x => x.ID) 
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

        public async virtual Task<IEnumerable<FinderData>> GetCompany_TypeList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            objList.Add(new FinderData() { Code = "Internal", Name = "Internal" });
            objList.Add(new FinderData() { Code = "External", Name = "External" });
            });
            return objList;
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task<IEnumerable<FinderData>> GetBranch_TypeList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            objList.Add(new FinderData() { Code = "Main", Name = "Main" });
            objList.Add(new FinderData() { Code = "Branch", Name = "Branch" });
            objList.Add(new FinderData() { Code = "Other", Name = "Other" });
            });
            return objList;
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task<IEnumerable<FinderData>> GetProductList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            var qry = " select [Product_Code] as Code,[Product_Name] as Name from [TSPL_PRODUCT_MASTER] ";
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

        public async virtual Task<IEnumerable<FinderData>> GetStateList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            var qry = " select [Code] as Code,[Description] as Name from [State Master] ";
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
