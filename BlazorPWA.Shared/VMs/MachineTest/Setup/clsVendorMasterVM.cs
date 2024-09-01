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
    [Description("frmVendorMaster")]
    [XSProgram(Module= "MachineTest", Program= "VendorMaster")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsVendorMasterVM : XpertDomainBase
    {
        private string? _ID = "Auto";
        private string? _Description;
        private string? _TextEditor = "xpertTextEditor1";

        public clsVendorMasterVM() { }

        [DefaultValue("")]
        [DisplayName("Vendor Code")]
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
        [DisplayName("Vendor Name")]
        [GroupName("Basic Info")]
        public override string? Description
        {
            get { return  _Description; }
            set { _Description=value; }
        }

        [DefaultValue("xpertTextEditor1")]
        [GroupName("Basic Info")]
        public string? TextEditor
        {
            get { return  _TextEditor; }
            set { _TextEditor=value; }
        }

    }
}
