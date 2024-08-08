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
    [Description("frmItemMaster")]
    [XSProgram(Module= "MachineTest", Program= "ItemMaster")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsItemMasterVM : XpertDomainBase
    {
        private string? _ID = "Auto";
        private string? _Description;
        private decimal? _Rate = 0;
        private string? _Uom;

        public clsItemMasterVM() { }

        [DefaultValue("")]
        [DisplayName("Item Code")]
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
        [DisplayName("Item Name")]
        [GroupName("Basic Info")]
        public override string? Description
        {
            get { return  _Description; }
            set { _Description=value; }
        }

        [DefaultValue("0")]
        [DisplayName("Rate")]
        [GroupName("Basic Info")]
        public decimal? Rate
        {
            get { return  _Rate; }
            set { _Rate=value; }
        }

        [DefaultValue("")]
        [DisplayName("UOM")]
        [GroupName("Basic Info")]
        public string? Uom
        {
            get { return  _Uom; }
            set { _Uom=value; }
        }

    }
}
