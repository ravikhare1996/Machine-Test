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
    [Description("frmVendorMaster")]
    [Table("TSPL_VENDOR_MASTER")]
    [XSProgram(Module= "MachineTest", Program= "VendorMaster")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsVendorMaster : XpertDomainBase
    {
        private string? _ID = "Auto";
        private string? _Description;
        private string? _TextEditor = "xpertTextEditor1";

        public clsVendorMaster() { }

        [DefaultValue("")]
        [Column("VCode", TypeName ="VARCHAR")]
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
        [Column("VName", TypeName ="VARCHAR")]
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
