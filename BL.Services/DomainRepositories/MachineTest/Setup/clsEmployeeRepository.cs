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
    public partial class clsEmployeeRepository : CommonRepositoryDomainBase<clsEmployee>, IclsEmployeeDataProxy
    {
        public IEnumerable<clsEmployee> GetData(string Doc_No)
        {
            try
            {
            if (Doc_No == string.Empty)
            {
            return new List<clsEmployee>() { new clsEmployee() }.ToArray();
            }
            using (var context = GetDbContextDomain()) 
             { 
             var results = context.Set<clsEmployee>() 
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

        public IEnumerable<clsEmployee> GetAll(int start, int pageSize)
        {
            try
            {
            using (var context = GetDbContextDomain()) 
             { 
            var results = context.Set<clsEmployee>()
            .OrderByDescending(o => o.ID)
            .Select(q => new {
            q.ID
            ,q.PHONE_NO
            ,q.EMAIL_ID
            ,q.Mothers_Name
            ,q.Fathers_Name
            ,q.Description
            ,q.PAYMENT_TYPE
            ,q.DESIGNATION
            ,q.Amount
            ,q.Account_Number
            ,q.Account_Phone_Number
            ,q.Account_Email
            ,q.IFSC_Code
            ,q.Bank_Name
            ,q.BankProof
            ,q.BankProof_FilePath
            ,q.BankProof_FileName
            ,q.BankProof_ContentType
            ,q.Adhaar_Number
            ,q.Adhaar_Phone_Number
            ,q.Adhaar_Email
            ,q.Adhaar_Address
            ,q.AdhaarProof
            ,q.AdhaarProof_FilePath
            ,q.AdhaarProof_FileName
            ,q.AdhaarProof_ContentType
            ,q.PAN_NUMBER
            ,q.Category_Type
            ,q.DATE_OF_JOINING
            ,q.DATE_OF_BIRTH
            ,q.Emp_Photo
            ,q.Emp_Photo_FilePath
            ,q.Emp_Photo_FileName
            ,q.Emp_Photo_ContentType
            ,q.Local_PINCODE
            ,q.Local_Ref_Phone_No
            ,q.ADDRESS2
            ,q.Local_Ref_Person
            ,q.Permanent_Ref_Phone_No
            ,q.Permanent_Ref_Person
            ,q.Parmanent_PINCODE
            ,q.ADDRESS1
            ,q.PF_Number
            ,q.PF_Phone_Number
            ,q.PF_Phone_Number_Type
            ,q.GST_Phone_Number
            ,q.GST_Email
            ,q.GST_Address
            ,q.GST_Number
            ,q.TDS_Number
            ,q.TDS_Phone_Number
            ,q.TDS_Email
            ,q.TDS_Address
            ,q.ROC_Number
            ,q.ROC_Phone_Number
            ,q.ROC_Email
            ,q.ROC_Address
            ,q.ESI_Number
            ,q.ESI_Phone_Number
            ,q.ESI_Phone_Number_Type
            ,q.Comp_Ref_Phone_No
            ,q.Comp_PINCODE
            ,q.CompanyCode
            ,q.Comp_Ref_Person
            ,q.COMPANY_ADDRESS
            }).ToArray().Select(o => new clsEmployee()
            {
            ID = o.ID
            ,PHONE_NO = o.PHONE_NO
            ,EMAIL_ID = o.EMAIL_ID
            ,Mothers_Name = o.Mothers_Name
            ,Fathers_Name = o.Fathers_Name
            ,Description = o.Description
            ,PAYMENT_TYPE = o.PAYMENT_TYPE
            ,DESIGNATION = o.DESIGNATION
            ,Amount = o.Amount
            ,Account_Number = o.Account_Number
            ,Account_Phone_Number = o.Account_Phone_Number
            ,Account_Email = o.Account_Email
            ,IFSC_Code = o.IFSC_Code
            ,Bank_Name = o.Bank_Name
            ,BankProof = o.BankProof
            ,BankProof_FilePath = o.BankProof_FilePath
            ,BankProof_FileName = o.BankProof_FileName
            ,BankProof_ContentType = o.BankProof_ContentType
            ,Adhaar_Number = o.Adhaar_Number
            ,Adhaar_Phone_Number = o.Adhaar_Phone_Number
            ,Adhaar_Email = o.Adhaar_Email
            ,Adhaar_Address = o.Adhaar_Address
            ,AdhaarProof = o.AdhaarProof
            ,AdhaarProof_FilePath = o.AdhaarProof_FilePath
            ,AdhaarProof_FileName = o.AdhaarProof_FileName
            ,AdhaarProof_ContentType = o.AdhaarProof_ContentType
            ,PAN_NUMBER = o.PAN_NUMBER
            ,Category_Type = o.Category_Type
            ,DATE_OF_JOINING = o.DATE_OF_JOINING
            ,DATE_OF_BIRTH = o.DATE_OF_BIRTH
            ,Emp_Photo = o.Emp_Photo
            ,Emp_Photo_FilePath = o.Emp_Photo_FilePath
            ,Emp_Photo_FileName = o.Emp_Photo_FileName
            ,Emp_Photo_ContentType = o.Emp_Photo_ContentType
            ,Local_PINCODE = o.Local_PINCODE
            ,Local_Ref_Phone_No = o.Local_Ref_Phone_No
            ,ADDRESS2 = o.ADDRESS2
            ,Local_Ref_Person = o.Local_Ref_Person
            ,Permanent_Ref_Phone_No = o.Permanent_Ref_Phone_No
            ,Permanent_Ref_Person = o.Permanent_Ref_Person
            ,Parmanent_PINCODE = o.Parmanent_PINCODE
            ,ADDRESS1 = o.ADDRESS1
            ,PF_Number = o.PF_Number
            ,PF_Phone_Number = o.PF_Phone_Number
            ,PF_Phone_Number_Type = o.PF_Phone_Number_Type
            ,GST_Phone_Number = o.GST_Phone_Number
            ,GST_Email = o.GST_Email
            ,GST_Address = o.GST_Address
            ,GST_Number = o.GST_Number
            ,TDS_Number = o.TDS_Number
            ,TDS_Phone_Number = o.TDS_Phone_Number
            ,TDS_Email = o.TDS_Email
            ,TDS_Address = o.TDS_Address
            ,ROC_Number = o.ROC_Number
            ,ROC_Phone_Number = o.ROC_Phone_Number
            ,ROC_Email = o.ROC_Email
            ,ROC_Address = o.ROC_Address
            ,ESI_Number = o.ESI_Number
            ,ESI_Phone_Number = o.ESI_Phone_Number
            ,ESI_Phone_Number_Type = o.ESI_Phone_Number_Type
            ,Comp_Ref_Phone_No = o.Comp_Ref_Phone_No
            ,Comp_PINCODE = o.Comp_PINCODE
            ,CompanyCode = o.CompanyCode
            ,Comp_Ref_Person = o.Comp_Ref_Person
            ,COMPANY_ADDRESS = o.COMPANY_ADDRESS
            }).Skip(start).Take(pageSize);
             return results;
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public async Task<clsEmployee> GetDataAsync(string Doc_No)
        {
            try
            {
            if (Doc_No == string.Empty)
            {
            return new clsEmployee();
            }
            using (var context = GetDbContextDomain()) 
             { 
             var results =await context.Set<clsEmployee>() 
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

        public async Task<IEnumerable<clsEmployee>> GetAllAsync(int start, int pageSize, string SearchString = "", string OrderBy = "")
        {
            try
            {
            using (var context = GetDbContextDomain()) 
             { 
            var results = await context.Set<clsEmployee>()
            .Where(d =>d.ID.Contains(SearchString) || d.Description.Contains(SearchString) || SearchString==null || SearchString== String.Empty)
            .OrderByDescending(o => o.ID)
            .Select(q => new {
            q.ID
            ,q.PHONE_NO
            ,q.EMAIL_ID
            ,q.Mothers_Name
            ,q.Fathers_Name
            ,q.Description
            ,q.PAYMENT_TYPE
            ,q.DESIGNATION
            ,q.Amount
            ,q.Account_Number
            ,q.Account_Phone_Number
            ,q.Account_Email
            ,q.IFSC_Code
            ,q.Bank_Name
            ,q.BankProof
            ,q.BankProof_FilePath
            ,q.BankProof_FileName
            ,q.BankProof_ContentType
            ,q.Adhaar_Number
            ,q.Adhaar_Phone_Number
            ,q.Adhaar_Email
            ,q.Adhaar_Address
            ,q.AdhaarProof
            ,q.AdhaarProof_FilePath
            ,q.AdhaarProof_FileName
            ,q.AdhaarProof_ContentType
            ,q.PAN_NUMBER
            ,q.Category_Type
            ,q.DATE_OF_JOINING
            ,q.DATE_OF_BIRTH
            ,q.Emp_Photo
            ,q.Emp_Photo_FilePath
            ,q.Emp_Photo_FileName
            ,q.Emp_Photo_ContentType
            ,q.Local_PINCODE
            ,q.Local_Ref_Phone_No
            ,q.ADDRESS2
            ,q.Local_Ref_Person
            ,q.Permanent_Ref_Phone_No
            ,q.Permanent_Ref_Person
            ,q.Parmanent_PINCODE
            ,q.ADDRESS1
            ,q.PF_Number
            ,q.PF_Phone_Number
            ,q.PF_Phone_Number_Type
            ,q.GST_Phone_Number
            ,q.GST_Email
            ,q.GST_Address
            ,q.GST_Number
            ,q.TDS_Number
            ,q.TDS_Phone_Number
            ,q.TDS_Email
            ,q.TDS_Address
            ,q.ROC_Number
            ,q.ROC_Phone_Number
            ,q.ROC_Email
            ,q.ROC_Address
            ,q.ESI_Number
            ,q.ESI_Phone_Number
            ,q.ESI_Phone_Number_Type
            ,q.Comp_Ref_Phone_No
            ,q.Comp_PINCODE
            ,q.CompanyCode
            ,q.Comp_Ref_Person
            ,q.COMPANY_ADDRESS
            }).Skip(start).Take(pageSize).ToListAsync();
            return results.Select(o => new clsEmployee()
            {
            ID = o.ID
            ,PHONE_NO = o.PHONE_NO
            ,EMAIL_ID = o.EMAIL_ID
            ,Mothers_Name = o.Mothers_Name
            ,Fathers_Name = o.Fathers_Name
            ,Description = o.Description
            ,PAYMENT_TYPE = o.PAYMENT_TYPE
            ,DESIGNATION = o.DESIGNATION
            ,Amount = o.Amount
            ,Account_Number = o.Account_Number
            ,Account_Phone_Number = o.Account_Phone_Number
            ,Account_Email = o.Account_Email
            ,IFSC_Code = o.IFSC_Code
            ,Bank_Name = o.Bank_Name
            ,BankProof = o.BankProof
            ,BankProof_FilePath = o.BankProof_FilePath
            ,BankProof_FileName = o.BankProof_FileName
            ,BankProof_ContentType = o.BankProof_ContentType
            ,Adhaar_Number = o.Adhaar_Number
            ,Adhaar_Phone_Number = o.Adhaar_Phone_Number
            ,Adhaar_Email = o.Adhaar_Email
            ,Adhaar_Address = o.Adhaar_Address
            ,AdhaarProof = o.AdhaarProof
            ,AdhaarProof_FilePath = o.AdhaarProof_FilePath
            ,AdhaarProof_FileName = o.AdhaarProof_FileName
            ,AdhaarProof_ContentType = o.AdhaarProof_ContentType
            ,PAN_NUMBER = o.PAN_NUMBER
            ,Category_Type = o.Category_Type
            ,DATE_OF_JOINING = o.DATE_OF_JOINING
            ,DATE_OF_BIRTH = o.DATE_OF_BIRTH
            ,Emp_Photo = o.Emp_Photo
            ,Emp_Photo_FilePath = o.Emp_Photo_FilePath
            ,Emp_Photo_FileName = o.Emp_Photo_FileName
            ,Emp_Photo_ContentType = o.Emp_Photo_ContentType
            ,Local_PINCODE = o.Local_PINCODE
            ,Local_Ref_Phone_No = o.Local_Ref_Phone_No
            ,ADDRESS2 = o.ADDRESS2
            ,Local_Ref_Person = o.Local_Ref_Person
            ,Permanent_Ref_Phone_No = o.Permanent_Ref_Phone_No
            ,Permanent_Ref_Person = o.Permanent_Ref_Person
            ,Parmanent_PINCODE = o.Parmanent_PINCODE
            ,ADDRESS1 = o.ADDRESS1
            ,PF_Number = o.PF_Number
            ,PF_Phone_Number = o.PF_Phone_Number
            ,PF_Phone_Number_Type = o.PF_Phone_Number_Type
            ,GST_Phone_Number = o.GST_Phone_Number
            ,GST_Email = o.GST_Email
            ,GST_Address = o.GST_Address
            ,GST_Number = o.GST_Number
            ,TDS_Number = o.TDS_Number
            ,TDS_Phone_Number = o.TDS_Phone_Number
            ,TDS_Email = o.TDS_Email
            ,TDS_Address = o.TDS_Address
            ,ROC_Number = o.ROC_Number
            ,ROC_Phone_Number = o.ROC_Phone_Number
            ,ROC_Email = o.ROC_Email
            ,ROC_Address = o.ROC_Address
            ,ESI_Number = o.ESI_Number
            ,ESI_Phone_Number = o.ESI_Phone_Number
            ,ESI_Phone_Number_Type = o.ESI_Phone_Number_Type
            ,Comp_Ref_Phone_No = o.Comp_Ref_Phone_No
            ,Comp_PINCODE = o.Comp_PINCODE
            ,CompanyCode = o.CompanyCode
            ,Comp_Ref_Person = o.Comp_Ref_Person
            ,COMPANY_ADDRESS = o.COMPANY_ADDRESS
            });
             } 
            }
            catch (Exception)
            {
            throw;
            }
        }

        public override clsEmployee Update(clsEmployee entity)
        {
            var trans = XSDBFunctionality.GetTransactin();
            try
            {
            var conn = XSDBFunctionality.GetConnnection;
            using (var context = GetDbContextDomain(conn,contextOwnsConnection: false))
             { 
            context.Database.UseTransaction(trans);
            //get eisting entry  
            var ExistEntity = context.Set<clsEmployee>()
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
            ExistEntity.FirstOrDefault().PHONE_NO = entity.PHONE_NO;
            ExistEntity.FirstOrDefault().EMAIL_ID = entity.EMAIL_ID;
            ExistEntity.FirstOrDefault().Mothers_Name = entity.Mothers_Name;
            ExistEntity.FirstOrDefault().Fathers_Name = entity.Fathers_Name;
            ExistEntity.FirstOrDefault().PAYMENT_TYPE = entity.PAYMENT_TYPE;
            ExistEntity.FirstOrDefault().DESIGNATION = entity.DESIGNATION;
            ExistEntity.FirstOrDefault().Amount = entity.Amount;
            ExistEntity.FirstOrDefault().Account_Number = entity.Account_Number;
            ExistEntity.FirstOrDefault().Account_Phone_Number = entity.Account_Phone_Number;
            ExistEntity.FirstOrDefault().Account_Email = entity.Account_Email;
            ExistEntity.FirstOrDefault().IFSC_Code = entity.IFSC_Code;
            ExistEntity.FirstOrDefault().Bank_Name = entity.Bank_Name;
            ExistEntity.FirstOrDefault().BankProof = entity.BankProof;
            ExistEntity.FirstOrDefault().BankProof_FilePath = entity.BankProof_FilePath;
            ExistEntity.FirstOrDefault().BankProof_FileName = entity.BankProof_FileName;
            ExistEntity.FirstOrDefault().BankProof_ContentType = entity.BankProof_ContentType;
            ExistEntity.FirstOrDefault().Adhaar_Number = entity.Adhaar_Number;
            ExistEntity.FirstOrDefault().Adhaar_Phone_Number = entity.Adhaar_Phone_Number;
            ExistEntity.FirstOrDefault().Adhaar_Email = entity.Adhaar_Email;
            ExistEntity.FirstOrDefault().Adhaar_Address = entity.Adhaar_Address;
            ExistEntity.FirstOrDefault().AdhaarProof = entity.AdhaarProof;
            ExistEntity.FirstOrDefault().AdhaarProof_FilePath = entity.AdhaarProof_FilePath;
            ExistEntity.FirstOrDefault().AdhaarProof_FileName = entity.AdhaarProof_FileName;
            ExistEntity.FirstOrDefault().AdhaarProof_ContentType = entity.AdhaarProof_ContentType;
            ExistEntity.FirstOrDefault().PAN_NUMBER = entity.PAN_NUMBER;
            ExistEntity.FirstOrDefault().Category_Type = entity.Category_Type;
            ExistEntity.FirstOrDefault().DATE_OF_JOINING = entity.DATE_OF_JOINING;
            ExistEntity.FirstOrDefault().DATE_OF_BIRTH = entity.DATE_OF_BIRTH;
            ExistEntity.FirstOrDefault().Emp_Photo = entity.Emp_Photo;
            ExistEntity.FirstOrDefault().Emp_Photo_FilePath = entity.Emp_Photo_FilePath;
            ExistEntity.FirstOrDefault().Emp_Photo_FileName = entity.Emp_Photo_FileName;
            ExistEntity.FirstOrDefault().Emp_Photo_ContentType = entity.Emp_Photo_ContentType;
            ExistEntity.FirstOrDefault().Local_PINCODE = entity.Local_PINCODE;
            ExistEntity.FirstOrDefault().Local_Ref_Phone_No = entity.Local_Ref_Phone_No;
            ExistEntity.FirstOrDefault().ADDRESS2 = entity.ADDRESS2;
            ExistEntity.FirstOrDefault().Local_Ref_Person = entity.Local_Ref_Person;
            ExistEntity.FirstOrDefault().Permanent_Ref_Phone_No = entity.Permanent_Ref_Phone_No;
            ExistEntity.FirstOrDefault().Permanent_Ref_Person = entity.Permanent_Ref_Person;
            ExistEntity.FirstOrDefault().Parmanent_PINCODE = entity.Parmanent_PINCODE;
            ExistEntity.FirstOrDefault().ADDRESS1 = entity.ADDRESS1;
            ExistEntity.FirstOrDefault().PF_Number = entity.PF_Number;
            ExistEntity.FirstOrDefault().PF_Phone_Number = entity.PF_Phone_Number;
            ExistEntity.FirstOrDefault().PF_Phone_Number_Type = entity.PF_Phone_Number_Type;
            ExistEntity.FirstOrDefault().GST_Phone_Number = entity.GST_Phone_Number;
            ExistEntity.FirstOrDefault().GST_Email = entity.GST_Email;
            ExistEntity.FirstOrDefault().GST_Address = entity.GST_Address;
            ExistEntity.FirstOrDefault().GST_Number = entity.GST_Number;
            ExistEntity.FirstOrDefault().TDS_Number = entity.TDS_Number;
            ExistEntity.FirstOrDefault().TDS_Phone_Number = entity.TDS_Phone_Number;
            ExistEntity.FirstOrDefault().TDS_Email = entity.TDS_Email;
            ExistEntity.FirstOrDefault().TDS_Address = entity.TDS_Address;
            ExistEntity.FirstOrDefault().ROC_Number = entity.ROC_Number;
            ExistEntity.FirstOrDefault().ROC_Phone_Number = entity.ROC_Phone_Number;
            ExistEntity.FirstOrDefault().ROC_Email = entity.ROC_Email;
            ExistEntity.FirstOrDefault().ROC_Address = entity.ROC_Address;
            ExistEntity.FirstOrDefault().ESI_Number = entity.ESI_Number;
            ExistEntity.FirstOrDefault().ESI_Phone_Number = entity.ESI_Phone_Number;
            ExistEntity.FirstOrDefault().ESI_Phone_Number_Type = entity.ESI_Phone_Number_Type;
            ExistEntity.FirstOrDefault().Comp_Ref_Phone_No = entity.Comp_Ref_Phone_No;
            ExistEntity.FirstOrDefault().Comp_PINCODE = entity.Comp_PINCODE;
            ExistEntity.FirstOrDefault().CompanyCode = entity.CompanyCode;
            ExistEntity.FirstOrDefault().Comp_Ref_Person = entity.Comp_Ref_Person;
            ExistEntity.FirstOrDefault().COMPANY_ADDRESS = entity.COMPANY_ADDRESS;
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

        public override async Task<clsEmployee> UpdateAsync(clsEmployee entity)
        {
            var trans = XSDBFunctionality.GetTransactin();
            try
            {
            var conn = XSDBFunctionality.GetConnnection;
            using (var context = GetDbContextDomain(conn,contextOwnsConnection: false))
             { 
            context.Database.UseTransaction(trans);
            //get eisting entry  
            var ExistEntity = context.Set<clsEmployee>()
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
            ExistEntity.FirstOrDefault().PHONE_NO = entity.PHONE_NO;
            ExistEntity.FirstOrDefault().EMAIL_ID = entity.EMAIL_ID;
            ExistEntity.FirstOrDefault().Mothers_Name = entity.Mothers_Name;
            ExistEntity.FirstOrDefault().Fathers_Name = entity.Fathers_Name;
            ExistEntity.FirstOrDefault().PAYMENT_TYPE = entity.PAYMENT_TYPE;
            ExistEntity.FirstOrDefault().DESIGNATION = entity.DESIGNATION;
            ExistEntity.FirstOrDefault().Amount = entity.Amount;
            ExistEntity.FirstOrDefault().Account_Number = entity.Account_Number;
            ExistEntity.FirstOrDefault().Account_Phone_Number = entity.Account_Phone_Number;
            ExistEntity.FirstOrDefault().Account_Email = entity.Account_Email;
            ExistEntity.FirstOrDefault().IFSC_Code = entity.IFSC_Code;
            ExistEntity.FirstOrDefault().Bank_Name = entity.Bank_Name;
            ExistEntity.FirstOrDefault().BankProof = entity.BankProof;
            ExistEntity.FirstOrDefault().BankProof_FilePath = entity.BankProof_FilePath;
            ExistEntity.FirstOrDefault().BankProof_FileName = entity.BankProof_FileName;
            ExistEntity.FirstOrDefault().BankProof_ContentType = entity.BankProof_ContentType;
            ExistEntity.FirstOrDefault().Adhaar_Number = entity.Adhaar_Number;
            ExistEntity.FirstOrDefault().Adhaar_Phone_Number = entity.Adhaar_Phone_Number;
            ExistEntity.FirstOrDefault().Adhaar_Email = entity.Adhaar_Email;
            ExistEntity.FirstOrDefault().Adhaar_Address = entity.Adhaar_Address;
            ExistEntity.FirstOrDefault().AdhaarProof = entity.AdhaarProof;
            ExistEntity.FirstOrDefault().AdhaarProof_FilePath = entity.AdhaarProof_FilePath;
            ExistEntity.FirstOrDefault().AdhaarProof_FileName = entity.AdhaarProof_FileName;
            ExistEntity.FirstOrDefault().AdhaarProof_ContentType = entity.AdhaarProof_ContentType;
            ExistEntity.FirstOrDefault().PAN_NUMBER = entity.PAN_NUMBER;
            ExistEntity.FirstOrDefault().Category_Type = entity.Category_Type;
            ExistEntity.FirstOrDefault().DATE_OF_JOINING = entity.DATE_OF_JOINING;
            ExistEntity.FirstOrDefault().DATE_OF_BIRTH = entity.DATE_OF_BIRTH;
            ExistEntity.FirstOrDefault().Emp_Photo = entity.Emp_Photo;
            ExistEntity.FirstOrDefault().Emp_Photo_FilePath = entity.Emp_Photo_FilePath;
            ExistEntity.FirstOrDefault().Emp_Photo_FileName = entity.Emp_Photo_FileName;
            ExistEntity.FirstOrDefault().Emp_Photo_ContentType = entity.Emp_Photo_ContentType;
            ExistEntity.FirstOrDefault().Local_PINCODE = entity.Local_PINCODE;
            ExistEntity.FirstOrDefault().Local_Ref_Phone_No = entity.Local_Ref_Phone_No;
            ExistEntity.FirstOrDefault().ADDRESS2 = entity.ADDRESS2;
            ExistEntity.FirstOrDefault().Local_Ref_Person = entity.Local_Ref_Person;
            ExistEntity.FirstOrDefault().Permanent_Ref_Phone_No = entity.Permanent_Ref_Phone_No;
            ExistEntity.FirstOrDefault().Permanent_Ref_Person = entity.Permanent_Ref_Person;
            ExistEntity.FirstOrDefault().Parmanent_PINCODE = entity.Parmanent_PINCODE;
            ExistEntity.FirstOrDefault().ADDRESS1 = entity.ADDRESS1;
            ExistEntity.FirstOrDefault().PF_Number = entity.PF_Number;
            ExistEntity.FirstOrDefault().PF_Phone_Number = entity.PF_Phone_Number;
            ExistEntity.FirstOrDefault().PF_Phone_Number_Type = entity.PF_Phone_Number_Type;
            ExistEntity.FirstOrDefault().GST_Phone_Number = entity.GST_Phone_Number;
            ExistEntity.FirstOrDefault().GST_Email = entity.GST_Email;
            ExistEntity.FirstOrDefault().GST_Address = entity.GST_Address;
            ExistEntity.FirstOrDefault().GST_Number = entity.GST_Number;
            ExistEntity.FirstOrDefault().TDS_Number = entity.TDS_Number;
            ExistEntity.FirstOrDefault().TDS_Phone_Number = entity.TDS_Phone_Number;
            ExistEntity.FirstOrDefault().TDS_Email = entity.TDS_Email;
            ExistEntity.FirstOrDefault().TDS_Address = entity.TDS_Address;
            ExistEntity.FirstOrDefault().ROC_Number = entity.ROC_Number;
            ExistEntity.FirstOrDefault().ROC_Phone_Number = entity.ROC_Phone_Number;
            ExistEntity.FirstOrDefault().ROC_Email = entity.ROC_Email;
            ExistEntity.FirstOrDefault().ROC_Address = entity.ROC_Address;
            ExistEntity.FirstOrDefault().ESI_Number = entity.ESI_Number;
            ExistEntity.FirstOrDefault().ESI_Phone_Number = entity.ESI_Phone_Number;
            ExistEntity.FirstOrDefault().ESI_Phone_Number_Type = entity.ESI_Phone_Number_Type;
            ExistEntity.FirstOrDefault().Comp_Ref_Phone_No = entity.Comp_Ref_Phone_No;
            ExistEntity.FirstOrDefault().Comp_PINCODE = entity.Comp_PINCODE;
            ExistEntity.FirstOrDefault().CompanyCode = entity.CompanyCode;
            ExistEntity.FirstOrDefault().Comp_Ref_Person = entity.Comp_Ref_Person;
            ExistEntity.FirstOrDefault().COMPANY_ADDRESS = entity.COMPANY_ADDRESS;
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
            Func<clsEmployee, bool> dynamicWhere = new Func<clsEmployee, bool>(x => true);
            if (whereExpression != null && whereExpression.Length > 0)
             { 
               dynamicWhere = interpreter.ParseAsDelegate<Func<clsEmployee, bool>>(whereExpression, "obj");
             } 
             using (var context = GetDbContextDomain())
             { 
             var results = await context.Set<clsEmployee>() 
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
            Func<clsEmployee, bool> dynamicWhere = new Func<clsEmployee, bool>(x => true); 
            if (whereExpression != null && whereExpression.Length > 0)
            {
            dynamicWhere = interpreter.ParseAsDelegate<Func<clsEmployee, bool>>(whereExpression, "obj"); 
            }
             using (var context = GetDbContextDomain())
             { 
             count=  context.Set<clsEmployee>()//.GroupBy(x => x.ID) 
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

        public async virtual Task<IEnumerable<FinderData>> GetPAYMENT_TYPEList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            objList.Add(new FinderData() { Code = "Daily", Name = "Daily" });
            objList.Add(new FinderData() { Code = "Weekly", Name = "Weekly" });
            objList.Add(new FinderData() { Code = "Monthly", Name = "Monthly" });
            });
            return objList;
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task<IEnumerable<FinderData>> GetDESIGNATIONList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            var qry = " select [Designation_Code] as Code,[Designation_Name] as Name from [TSPL_DESIGNATION_MASTER] ";
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

        public async virtual Task<IEnumerable<FinderData>> GetCategory_TypeList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            objList.Add(new FinderData() { Code = "Employee", Name = "Employee" });
            objList.Add(new FinderData() { Code = "Individual", Name = "Individual" });
            });
            return objList;
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task<IEnumerable<FinderData>> GetPF_Phone_Number_TypeList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            objList.Add(new FinderData() { Code = "Official", Name = "Official" });
            objList.Add(new FinderData() { Code = "Personal", Name = "Personal" });
            });
            return objList;
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task<IEnumerable<FinderData>> GetESI_Phone_Number_TypeList(string FinderType, string WhereExpression)
        {
            try
            {
            var objList = new List<FinderData>();
            await Task.Run(() =>
            {
            var objTr = new FinderData();
            objList.Add(new FinderData() { Code = "Official", Name = "Official" });
            objList.Add(new FinderData() { Code = "Personal", Name = "Personal" });
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
