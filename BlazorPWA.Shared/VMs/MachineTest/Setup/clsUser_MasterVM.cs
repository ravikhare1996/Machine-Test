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
    [Description("User Master")]
    [XSProgram(Module= "MachineTest", Program= "User_Master")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsUser_MasterVM : XpertDomainBase
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

        public clsUser_MasterVM() { }

        [DefaultValue("")]
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
        [DisplayName("User Name")]
        [GroupName("Basic Info")]
        public override string? Description
        {
            get { return  _Description; }
            set { _Description=value; }
        }

        [DefaultValue("")]
        [DisplayName("Client")]
        [GroupName("Basic Info")]
        public string? Client
        {
            get { return  _Client; }
            set { _Client=value; }
        }

        [DefaultValue("Password")]
        [DisplayName("Password")]
        [GroupName("Basic Info")]
        public string? Password
        {
            get { return  _Password; }
            set { _Password=value; }
        }

        [DefaultValue("")]
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

        [DisplayName("Pancard File Path")]
        [GroupName("Attach PanCard")]
        public string? PanCard_FilePath
        {
            get { return  _PanCard_FilePath; }
            set { _PanCard_FilePath=value; }
        }

        [GroupName("Attach PanCard")]
        public string? PanCard_FileName
        {
            get { return  _PanCard_FileName; }
            set { _PanCard_FileName=value; }
        }

        [DisplayName(" Content Type")]
        [GroupName("Attach PanCard")]
        public string? PanCard_ContentType
        {
            get { return  _PanCard_ContentType; }
            set { _PanCard_ContentType=value; }
        }

        [DefaultValue("")]
        [DisplayName("Email")]
        [GroupName("Contacts")]
        public string? Phone
        {
            get { return  _Phone; }
            set { _Phone=value; }
        }

        [DefaultValue("")]
        [DisplayName("Email")]
        [GroupName("Contacts")]
        public string? E_mail
        {
            get { return  _E_mail; }
            set { _E_mail=value; }
        }

    }
}
