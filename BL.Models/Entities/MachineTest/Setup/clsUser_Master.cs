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

namespace MachineTest.Domain.Entities
{
    [Description("User Master")]
    [Table("User_Master")]
    [XSProgram(Module= "MachineTest", Program= "User_Master")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsUser_Master : XpertDomainBase
    {
        private string? _ID = "Auto";
        private string? _Description;
        private string? _Client;
        private string? _Password = "Password";
        private string? _User_Type;
        private byte[]? _PanCard;
        private string? _PanCard_FilePath;
        private string? _PanCard_FileName;
        private string? _PanCard_ContentType;
        private string? _Phone;
        private string? _E_mail;

        public clsUser_Master() { }

        [DefaultValue("")]
        [Column("User_Code", TypeName ="VARCHAR")]
        [DisplayName("User Code")]
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
        [Column("User_Name", TypeName ="VARCHAR")]
        [DisplayName("User Name")]
        [GroupName("Basic Info")]
        public override string? Description
        {
            get { return  _Description; }
            set { _Description=value; }
        }

        [DefaultValue("")]
        [Column("Client", TypeName ="VARCHAR")]
        [DisplayName("Client")]
        [GroupName("Basic Info")]
        public string? Client
        {
            get { return  _Client; }
            set { _Client=value; }
        }

        [DefaultValue("Password")]
        [Column("Password", TypeName ="VARCHAR")]
        [DisplayName("Password")]
        [GroupName("Basic Info")]
        public string? Password
        {
            get { return  _Password; }
            set { _Password=value; }
        }

        [DefaultValue("")]
        [Column("User_Type", TypeName ="VARCHAR")]
        [DisplayName("Level")]
        [GroupName("Basic Info")]
        public string? User_Type
        {
            get { return  _User_Type; }
            set { _User_Type=value; }
        }

        [GroupName("Attach PanCard")]
        public byte[]? PanCard
        {
            get { return  _PanCard; }
            set { _PanCard=value; }
        }

        [Column("PanCard_FilePath", TypeName ="VARCHAR")]
        [DisplayName("Pancard File Path")]
        [GroupName("Attach PanCard")]
        public string? PanCard_FilePath
        {
            get { return  _PanCard_FilePath; }
            set { _PanCard_FilePath=value; }
        }

        [Column("PanCard_FileName", TypeName ="VARCHAR")]
        [GroupName("Attach PanCard")]
        public string? PanCard_FileName
        {
            get { return  _PanCard_FileName; }
            set { _PanCard_FileName=value; }
        }

        [Column("PanCard_ContentType", TypeName ="VARCHAR")]
        [DisplayName(" Content Type")]
        [GroupName("Attach PanCard")]
        public string? PanCard_ContentType
        {
            get { return  _PanCard_ContentType; }
            set { _PanCard_ContentType=value; }
        }

        [DefaultValue("")]
        [Column("Phone", TypeName ="VARCHAR")]
        [DisplayName("Email")]
        [GroupName("Contacts")]
        public string? Phone
        {
            get { return  _Phone; }
            set { _Phone=value; }
        }

        [DefaultValue("")]
        [Column("E_mail", TypeName ="VARCHAR")]
        [DisplayName("Email")]
        [GroupName("Contacts")]
        public string? E_mail
        {
            get { return  _E_mail; }
            set { _E_mail=value; }
        }

    }
}
