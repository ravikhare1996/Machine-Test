using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpertStudio.Framework.Domain;
using XpertStudio.Framework;
using XpertStudio.Framework.Attributes;
using XpertStudio.Common.Attributes;
using XpertStudio.Common.Enums;

namespace BlazorPWA.Shared.VMs
{
    [Description("Employee Master")]
    [XSProgram(Module= "MachineTest", Program= "EmployeeMaster")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsEmployeeVM : XpertDomainBase
    {
        private string? _ID = "Auto";
        private string? _Description;
        private string? _Fathers_Name;
        private string? _Mothers_Name;
        private string? _EMAIL_ID;
        private string? _PHONE_NO;
        private string? _DESIGNATION;
        private string? _PAYMENT_TYPE = "Payemnt Type";
        private decimal? _Amount = 0;
        private string? _Bank_Name;
        private string? _Account_Number;
        private string? _IFSC_Code;
        private byte[]? _BankProof;
        private string? _BankProof_FilePath;
        private string? _BankProof_FileName;
        private string? _BankProof_ContentType;
        private string? _Account_Email;
        private string? _Account_Phone_Number;
        private string? _Adhaar_Number;
        private string? _Adhaar_Address;
        private string? _Adhaar_Email;
        private byte[]? _AdhaarProof;
        private string? _AdhaarProof_FilePath;
        private string? _AdhaarProof_FileName;
        private string? _AdhaarProof_ContentType;
        private string? _Adhaar_Phone_Number;
        private string? _Category_Type = "Category Type";
        private DateTime? _DATE_OF_JOINING;
        private DateTime? _DATE_OF_BIRTH;
        private string? _PAN_NUMBER;
        private byte[]? _Emp_Photo;
        private string? _Emp_Photo_FilePath;
        private string? _Emp_Photo_FileName;
        private string? _Emp_Photo_ContentType;
        private string? _ADDRESS2;
        private string? _Local_Ref_Person;
        private string? _Local_PINCODE;
        private string? _Local_Ref_Phone_No;
        private string? _ADDRESS1;
        private string? _Permanent_Ref_Person;
        private string? _Parmanent_PINCODE;
        private string? _Permanent_Ref_Phone_No;
        private string? _PF_Phone_Number_Type = "Phone Number Type";
        private string? _PF_Phone_Number;
        private string? _PF_Number;
        private string? _GST_Number;
        private string? _GST_Address;
        private string? _GST_Email;
        private string? _GST_Phone_Number;
        private string? _TDS_Address;
        private string? _TDS_Email;
        private string? _TDS_Phone_Number;
        private string? _TDS_Number;
        private string? _ROC_Phone_Number;
        private string? _ROC_Address;
        private string? _ROC_Email;
        private string? _ROC_Number;
        private string? _ESI_Phone_Number_Type = "Phone Number Type";
        private string? _ESI_Phone_Number;
        private string? _ESI_Number;
        private string? _COMPANY_ADDRESS;
        private string? _Comp_Ref_Person;
        private string? _CompanyCode;
        private string? _Comp_PINCODE;
        private string? _Comp_Ref_Phone_No;

        public clsEmployeeVM() { }

        [DefaultValue("")]
        [DisplayName("Employee Code")]
        [GroupName("General Information")]
        [XpertRequired]
        [Key]
        [MaxLength(30)]
        public override string? ID
        {
            get { return  _ID; }
            set { _ID=value; }
        }

        [DefaultValue("")]
        [DisplayName("Employee Name")]
        [GroupName("General Information")]
        [MaxLength(50)]
        public override string? Description
        {
            get { return  _Description; }
            set { _Description=value; }
        }

        [DefaultValue("")]
        [DisplayName("Employee Name")]
        [GroupName("General Information")]
        [MaxLength(50)]
        public string? Fathers_Name
        {
            get { return  _Fathers_Name; }
            set { _Fathers_Name=value; }
        }

        [DefaultValue("")]
        [DisplayName("Mothers Name")]
        [GroupName("General Information")]
        [MaxLength(50)]
        public string? Mothers_Name
        {
            get { return  _Mothers_Name; }
            set { _Mothers_Name=value; }
        }

        [DefaultValue("")]
        [DisplayName("EMAIL_ID")]
        [GroupName("General Information")]
        [MaxLength(100)]
        public string? EMAIL_ID
        {
            get { return  _EMAIL_ID; }
            set { _EMAIL_ID=value; }
        }

        [DefaultValue("")]
        [DisplayName("Phone Number")]
        [GroupName("General Information")]
        [MaxLength(10)]
        public string? PHONE_NO
        {
            get { return  _PHONE_NO; }
            set { _PHONE_NO=value; }
        }

        [DefaultValue("")]
        [DisplayName("DESIGNATION")]
        [GroupName("Salary Information")]
        public string? DESIGNATION
        {
            get { return  _DESIGNATION; }
            set { _DESIGNATION=value; }
        }

        [DefaultValue("Payemnt Type")]
        [DisplayName("PAYMENT TYPE")]
        [GroupName("Salary Information")]
        [MaxLength(20)]
        public string? PAYMENT_TYPE
        {
            get { return  _PAYMENT_TYPE; }
            set { _PAYMENT_TYPE=value; }
        }

        [DefaultValue("0")]
        [DisplayName("Amount")]
        [GroupName("Salary Information")]
        public decimal? Amount
        {
            get { return  _Amount; }
            set { _Amount=value; }
        }

        [DefaultValue("")]
        [DisplayName("Bank Name")]
        [GroupName("Bank Details")]
        [MaxLength(30)]
        public string? Bank_Name
        {
            get { return  _Bank_Name; }
            set { _Bank_Name=value; }
        }

        [DefaultValue("")]
        [DisplayName("Account Number")]
        [GroupName("Bank Details")]
        [MaxLength(20)]
        public string? Account_Number
        {
            get { return  _Account_Number; }
            set { _Account_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("IFSC Code")]
        [GroupName("Bank Details")]
        [MaxLength(20)]
        public string? IFSC_Code
        {
            get { return  _IFSC_Code; }
            set { _IFSC_Code=value; }
        }

        [GroupName("Bank Details")]
        public byte[]? BankProof
        {
            get { return  _BankProof; }
            set { _BankProof=value; }
        }

        [DisplayName("Bank Proof File Path")]
        [GroupName("Bank Details")]
        public string? BankProof_FilePath
        {
            get { return  _BankProof_FilePath; }
            set { _BankProof_FilePath=value; }
        }

        [GroupName("Bank Details")]
        public string? BankProof_FileName
        {
            get { return  _BankProof_FileName; }
            set { _BankProof_FileName=value; }
        }

        [DisplayName(" Content Type")]
        [GroupName("Bank Details")]
        public string? BankProof_ContentType
        {
            get { return  _BankProof_ContentType; }
            set { _BankProof_ContentType=value; }
        }

        [DefaultValue("")]
        [DisplayName("Bank Email")]
        [GroupName("Bank Details")]
        [MaxLength(30)]
        public string? Account_Email
        {
            get { return  _Account_Email; }
            set { _Account_Email=value; }
        }

        [DefaultValue("")]
        [DisplayName("Account Phone Number")]
        [GroupName("Bank Details")]
        [MaxLength(10)]
        public string? Account_Phone_Number
        {
            get { return  _Account_Phone_Number; }
            set { _Account_Phone_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("Adhaar Number")]
        [GroupName("Adhaar Details")]
        [MaxLength(20)]
        public string? Adhaar_Number
        {
            get { return  _Adhaar_Number; }
            set { _Adhaar_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("Adhaar Address")]
        [GroupName("Adhaar Details")]
        [MaxLength(100)]
        public string? Adhaar_Address
        {
            get { return  _Adhaar_Address; }
            set { _Adhaar_Address=value; }
        }

        [DefaultValue("")]
        [DisplayName("Adhaar Email")]
        [GroupName("Adhaar Details")]
        [MaxLength(30)]
        public string? Adhaar_Email
        {
            get { return  _Adhaar_Email; }
            set { _Adhaar_Email=value; }
        }

        [GroupName("Adhaar Details")]
        public byte[]? AdhaarProof
        {
            get { return  _AdhaarProof; }
            set { _AdhaarProof=value; }
        }

        [DisplayName("Adhaar Proof File Path")]
        [GroupName("Adhaar Details")]
        public string? AdhaarProof_FilePath
        {
            get { return  _AdhaarProof_FilePath; }
            set { _AdhaarProof_FilePath=value; }
        }

        [GroupName("Adhaar Details")]
        public string? AdhaarProof_FileName
        {
            get { return  _AdhaarProof_FileName; }
            set { _AdhaarProof_FileName=value; }
        }

        [DisplayName(" Content Type")]
        [GroupName("Adhaar Details")]
        public string? AdhaarProof_ContentType
        {
            get { return  _AdhaarProof_ContentType; }
            set { _AdhaarProof_ContentType=value; }
        }

        [DefaultValue("")]
        [DisplayName("Adhaar Phone Number")]
        [GroupName("Adhaar Details")]
        [MaxLength(10)]
        public string? Adhaar_Phone_Number
        {
            get { return  _Adhaar_Phone_Number; }
            set { _Adhaar_Phone_Number=value; }
        }

        [DefaultValue("Category Type")]
        [DisplayName("Category")]
        [GroupName("Biographical")]
        public string? Category_Type
        {
            get { return  _Category_Type; }
            set { _Category_Type=value; }
        }

        [DefaultValue("'16-Jul-24 2:01:41 PM'")]
        [DisplayName("Date of Joining")]
        [GroupName("Biographical")]
        public DateTime? DATE_OF_JOINING
        {
            get { return  _DATE_OF_JOINING; }
            set { _DATE_OF_JOINING=value; }
        }

        [DefaultValue("'16-Jul-24 2:01:41 PM'")]
        [DisplayName("Date of Birth")]
        [GroupName("Biographical")]
        public DateTime? DATE_OF_BIRTH
        {
            get { return  _DATE_OF_BIRTH; }
            set { _DATE_OF_BIRTH=value; }
        }

        [DefaultValue("")]
        [DisplayName("PAN NUMBER")]
        [GroupName("Biographical")]
        [MaxLength(12)]
        public string? PAN_NUMBER
        {
            get { return  _PAN_NUMBER; }
            set { _PAN_NUMBER=value; }
        }

        [GroupName("Biographical")]
        public byte[]? Emp_Photo
        {
            get { return  _Emp_Photo; }
            set { _Emp_Photo=value; }
        }

        [DisplayName("Photo File Path")]
        [GroupName("Biographical")]
        public string? Emp_Photo_FilePath
        {
            get { return  _Emp_Photo_FilePath; }
            set { _Emp_Photo_FilePath=value; }
        }

        [GroupName("Biographical")]
        public string? Emp_Photo_FileName
        {
            get { return  _Emp_Photo_FileName; }
            set { _Emp_Photo_FileName=value; }
        }

        [DisplayName(" Content Type")]
        [GroupName("Biographical")]
        public string? Emp_Photo_ContentType
        {
            get { return  _Emp_Photo_ContentType; }
            set { _Emp_Photo_ContentType=value; }
        }

        [DefaultValue("")]
        [DisplayName("Address")]
        [GroupName("Local Address")]
        [MaxLength(500)]
        public string? ADDRESS2
        {
            get { return  _ADDRESS2; }
            set { _ADDRESS2=value; }
        }

        [DefaultValue("")]
        [DisplayName("Ref. Person")]
        [GroupName("Local Address")]
        [MaxLength(50)]
        public string? Local_Ref_Person
        {
            get { return  _Local_Ref_Person; }
            set { _Local_Ref_Person=value; }
        }

        [DefaultValue("")]
        [DisplayName("PINCODE")]
        [GroupName("Local Address")]
        [MaxLength(6)]
        public string? Local_PINCODE
        {
            get { return  _Local_PINCODE; }
            set { _Local_PINCODE=value; }
        }

        [DefaultValue("")]
        [DisplayName("Phone Number")]
        [GroupName("Local Address")]
        [MaxLength(10)]
        public string? Local_Ref_Phone_No
        {
            get { return  _Local_Ref_Phone_No; }
            set { _Local_Ref_Phone_No=value; }
        }

        [DefaultValue("")]
        [DisplayName("Address")]
        [GroupName("Permanent Address")]
        [MaxLength(500)]
        public string? ADDRESS1
        {
            get { return  _ADDRESS1; }
            set { _ADDRESS1=value; }
        }

        [DefaultValue("")]
        [DisplayName("Ref. Person")]
        [GroupName("Permanent Address")]
        [MaxLength(50)]
        public string? Permanent_Ref_Person
        {
            get { return  _Permanent_Ref_Person; }
            set { _Permanent_Ref_Person=value; }
        }

        [DefaultValue("")]
        [DisplayName("PINCODE")]
        [GroupName("Permanent Address")]
        [MaxLength(6)]
        public string? Parmanent_PINCODE
        {
            get { return  _Parmanent_PINCODE; }
            set { _Parmanent_PINCODE=value; }
        }

        [DefaultValue("")]
        [DisplayName("Phone Number")]
        [GroupName("Permanent Address")]
        [MaxLength(10)]
        public string? Permanent_Ref_Phone_No
        {
            get { return  _Permanent_Ref_Phone_No; }
            set { _Permanent_Ref_Phone_No=value; }
        }

        [DefaultValue("Phone Number Type")]
        [DisplayName("Phone Number Type")]
        [GroupName("PF Details")]
        [MaxLength(20)]
        public string? PF_Phone_Number_Type
        {
            get { return  _PF_Phone_Number_Type; }
            set { _PF_Phone_Number_Type=value; }
        }

        [DefaultValue("")]
        [DisplayName("PF Phone Number")]
        [GroupName("PF Details")]
        [MaxLength(10)]
        public string? PF_Phone_Number
        {
            get { return  _PF_Phone_Number; }
            set { _PF_Phone_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("PF Number")]
        [GroupName("PF Details")]
        [MaxLength(20)]
        public string? PF_Number
        {
            get { return  _PF_Number; }
            set { _PF_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("GST Number")]
        [GroupName("GST Details")]
        [MaxLength(15)]
        public string? GST_Number
        {
            get { return  _GST_Number; }
            set { _GST_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("GST Address")]
        [GroupName("GST Details")]
        [MaxLength(100)]
        public string? GST_Address
        {
            get { return  _GST_Address; }
            set { _GST_Address=value; }
        }

        [DefaultValue("")]
        [DisplayName("GST Email")]
        [GroupName("GST Details")]
        [MaxLength(30)]
        public string? GST_Email
        {
            get { return  _GST_Email; }
            set { _GST_Email=value; }
        }

        [DefaultValue("")]
        [DisplayName("GST Phone Number")]
        [GroupName("GST Details")]
        [MaxLength(10)]
        public string? GST_Phone_Number
        {
            get { return  _GST_Phone_Number; }
            set { _GST_Phone_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("TDS Address")]
        [GroupName("TDS Details")]
        [MaxLength(100)]
        public string? TDS_Address
        {
            get { return  _TDS_Address; }
            set { _TDS_Address=value; }
        }

        [DefaultValue("")]
        [DisplayName("TDS Email")]
        [GroupName("TDS Details")]
        [MaxLength(30)]
        public string? TDS_Email
        {
            get { return  _TDS_Email; }
            set { _TDS_Email=value; }
        }

        [DefaultValue("")]
        [DisplayName("TDS Phone Number")]
        [GroupName("TDS Details")]
        [MaxLength(10)]
        public string? TDS_Phone_Number
        {
            get { return  _TDS_Phone_Number; }
            set { _TDS_Phone_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("TDS Number")]
        [GroupName("TDS Details")]
        [MaxLength(20)]
        public string? TDS_Number
        {
            get { return  _TDS_Number; }
            set { _TDS_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("ROC Phone Number")]
        [GroupName("ROC Details")]
        [MaxLength(10)]
        public string? ROC_Phone_Number
        {
            get { return  _ROC_Phone_Number; }
            set { _ROC_Phone_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("ROC Address")]
        [GroupName("ROC Details")]
        [MaxLength(100)]
        public string? ROC_Address
        {
            get { return  _ROC_Address; }
            set { _ROC_Address=value; }
        }

        [DefaultValue("")]
        [DisplayName("ROC Email")]
        [GroupName("ROC Details")]
        [MaxLength(30)]
        public string? ROC_Email
        {
            get { return  _ROC_Email; }
            set { _ROC_Email=value; }
        }

        [DefaultValue("")]
        [DisplayName("ROC Number")]
        [GroupName("ROC Details")]
        [MaxLength(20)]
        public string? ROC_Number
        {
            get { return  _ROC_Number; }
            set { _ROC_Number=value; }
        }

        [DefaultValue("Phone Number Type")]
        [DisplayName("Phone Number Type")]
        [GroupName("ESI Details")]
        [MaxLength(20)]
        public string? ESI_Phone_Number_Type
        {
            get { return  _ESI_Phone_Number_Type; }
            set { _ESI_Phone_Number_Type=value; }
        }

        [DefaultValue("")]
        [DisplayName("ESI Phone Number")]
        [GroupName("ESI Details")]
        [MaxLength(10)]
        public string? ESI_Phone_Number
        {
            get { return  _ESI_Phone_Number; }
            set { _ESI_Phone_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("ESI Number")]
        [GroupName("ESI Details")]
        [MaxLength(20)]
        public string? ESI_Number
        {
            get { return  _ESI_Number; }
            set { _ESI_Number=value; }
        }

        [DefaultValue("")]
        [DisplayName("Address")]
        [GroupName("Company Details")]
        [MaxLength(500)]
        public string? COMPANY_ADDRESS
        {
            get { return  _COMPANY_ADDRESS; }
            set { _COMPANY_ADDRESS=value; }
        }

        [DefaultValue("")]
        [DisplayName("Ref. Person")]
        [GroupName("Company Details")]
        [MaxLength(50)]
        public string? Comp_Ref_Person
        {
            get { return  _Comp_Ref_Person; }
            set { _Comp_Ref_Person=value; }
        }

        [DefaultValue("")]
        [DisplayName("Company Name")]
        [GroupName("Company Details")]
        [MaxLength(30)]
        public override string? CompanyCode
        {
            get { return  _CompanyCode; }
            set { _CompanyCode=value; }
        }

        [DefaultValue("")]
        [DisplayName("PINCODE")]
        [GroupName("Company Details")]
        [MaxLength(6)]
        public string? Comp_PINCODE
        {
            get { return  _Comp_PINCODE; }
            set { _Comp_PINCODE=value; }
        }

        [DefaultValue("")]
        [DisplayName("Phone Number")]
        [GroupName("Company Details")]
        [MaxLength(10)]
        public string? Comp_Ref_Phone_No
        {
            get { return  _Comp_Ref_Phone_No; }
            set { _Comp_Ref_Phone_No=value; }
        }

    }
}
