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
using Microsoft.EntityFrameworkCore;
using XpertStudio.Common.Attributes;
using XpertStudio.Common.Enums;
using BlazorPWA.Common.Enums;

namespace MachineTest.Domain.Entities
{
    [Description("frmCompanyMaster")]
    [Table("TSPL_COMPANY_MASTER")]
    [XSProgram(Module= "MachineTest", Program= "Company_Master")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsCompanyMaster : XpertDomainBase
    {
        private string? _ID = "Auto";
        private string? _Description;
        private clsBranchType? _Branch_Type;
        private string? _Add1;
        private string? _Add2;
        private string? _Add3;
        private string? _State;
        private string? _City_Code;
        private string? _Phone1;
        private string? _Pincode;
        private string? _Email;
        private string? _Phone2;
        private string? _Product;
        private string? _Comp_Loc_Seg;
        private string? _Company_Type = "None";
        private decimal? _Non_Analyzed_Work_Hour = 0;
        private string? _SMTP_Client;
        private string? _Port;
        private string? _EmailID_From;
        private string? _Password;

        public clsCompanyMaster() { }

        [DefaultValue("")]
        [Column("Comp_Code", TypeName ="VARCHAR")]
        [DisplayName("Company Code")]
        [GroupName("Basic Info")]
        [XpertRequired]
        [Key]
        [MaxLength(30)]
        public override string? ID
        {
            get { return  _ID; }
            set { _ID=value; }
        }

        [DefaultValue("")]
        [Column("Comp_Name", TypeName ="VARCHAR")]
        [DisplayName("Company Name")]
        [GroupName("Basic Info")]
        public override string? Description
        {
            get { return  _Description; }
            set { _Description=value; }
        }

        [DefaultValue("")]
        [Column("Branch_Type")]
        [DisplayName("Branch")]
        [GroupName("Basic Info")]
        [NotMapped]
        [XSCodeType(Type=XSCodeType.Custom)]
        public clsBranchType? Branch_Type
        {
            get { return  _Branch_Type; }
            set { _Branch_Type=value; }
        }


        [DefaultValue("")]
        [Column("Add1", TypeName ="VARCHAR")]
        [DisplayName("Address 1")]
        [GroupName("Basic Info")]
        public string? Add1
        {
            get { return  _Add1; }
            set { _Add1=value; }
        }

        [DefaultValue("")]
        [Column("Add2", TypeName ="VARCHAR")]
        [DisplayName("Address 2")]
        [GroupName("Basic Info")]
        public string? Add2
        {
            get { return  _Add2; }
            set { _Add2=value; }
        }

        [DefaultValue("")]
        [Column("Add3", TypeName ="VARCHAR")]
        [DisplayName("Address 3")]
        [GroupName("Basic Info")]
        public string? Add3
        {
            get { return  _Add3; }
            set { _Add3=value; }
        }

        [DefaultValue("")]
        [Column("State", TypeName ="VARCHAR")]
        [DisplayName("State")]
        [GroupName("Basic Info")]
        public string? State
        {
            get { return  _State; }
            set { _State=value; }
        }

        [DefaultValue("")]
        [Column("City_Code", TypeName ="VARCHAR")]
        [DisplayName("City Code")]
        [GroupName("Basic Info")]
        public string? City_Code
        {
            get { return  _City_Code; }
            set { _City_Code=value; }
        }

        [DefaultValue("")]
        [Column("Phone1", TypeName ="VARCHAR")]
        [DisplayName("Phone 1")]
        [GroupName("Basic Info")]
        public string? Phone1
        {
            get { return  _Phone1; }
            set { _Phone1=value; }
        }

        [DefaultValue("")]
        [Column("Pincode", TypeName ="VARCHAR")]
        [DisplayName("Pin Code")]
        [GroupName("Basic Info")]
        public string? Pincode
        {
            get { return  _Pincode; }
            set { _Pincode=value; }
        }

        [DefaultValue("")]
        [Column("Email", TypeName ="VARCHAR")]
        [DisplayName("Email")]
        [GroupName("Basic Info")]
        public string? Email
        {
            get { return  _Email; }
            set { _Email=value; }
        }

        [DefaultValue("")]
        [Column("Phone2", TypeName ="VARCHAR")]
        [DisplayName("Telephone")]
        [GroupName("Basic Info")]
        public string? Phone2
        {
            get { return  _Phone2; }
            set { _Phone2=value; }
        }

        [DefaultValue("")]
        [Column("Product", TypeName ="VARCHAR")]
        [DisplayName("Product")]
        [GroupName("Basic Info")]
        [NotMapped]
        [XSCodeType(Type = XSCodeType.Custom)]
        public string? Product
        {
            get { return  _Product; }
            set { _Product=value; }
        }


        [DefaultValue("")]
        [Column("Comp_Loc_Seg", TypeName ="VARCHAR")]
        [DisplayName("Location Segment")]
        [GroupName("Basic Info")]
        public string? Comp_Loc_Seg
        {
            get { return  _Comp_Loc_Seg; }
            set { _Comp_Loc_Seg=value; }
        }

        [DefaultValue("None")]
        [Column("Company_Type", TypeName ="VARCHAR")]
        [DisplayName("Company Type")]
        [GroupName("Basic Info")]
        public string? Company_Type
        {
            get { return  _Company_Type; }
            set { _Company_Type=value; }
        }

        [DefaultValue("0")]
        [Column("Non_Analyzed_Work_Hour")]
        [DisplayName("Non Analyzed Work Hour")]
        [GroupName("Basic Info")]
        public decimal? Non_Analyzed_Work_Hour
        {
            get { return  _Non_Analyzed_Work_Hour; }
            set { _Non_Analyzed_Work_Hour=value; }
        }

        [DefaultValue("")]
        [Column("SMTP_Client", TypeName ="VARCHAR")]
        [DisplayName("SMTP Client")]
        [GroupName(" Email Port Setting")]
        [NotMapped]
        [XSCodeType(Type = XSCodeType.Custom)]
        public string? SMTP_Client
        {
            get { return  _SMTP_Client; }
            set { _SMTP_Client=value; }
        }




        [DefaultValue("")]
        [Column("Port", TypeName ="VARCHAR")]
        [DisplayName("Port")]
        [GroupName(" Email Port Setting")]
        [NotMapped]
        [XSCodeType(Type = XSCodeType.Custom)]
        public string? Port
        {
            get { return  _Port; }
            set { _Port=value; }
        }




        [DefaultValue("")]
        [Column("EmailID_From", TypeName ="VARCHAR")]
        [DisplayName("EmailID From")]
        [GroupName(" Email Port Setting")]
        [NotMapped]
        [XSCodeType(Type = XSCodeType.Custom)]
        public string? EmailID_From
        {
            get { return  _EmailID_From; }
            set { _EmailID_From=value; }
        }




        [DefaultValue("")]
        [Column("Password", TypeName ="VARCHAR")]
        [DisplayName("Password")]
        [GroupName(" Email Port Setting")]
        [NotMapped]
        [XSCodeType(Type = XSCodeType.Custom)]
        public string? Password
        {
            get { return  _Password; }
            set { _Password=value; }
        }


    }
}
