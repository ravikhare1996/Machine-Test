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
    [Description("frmItemMaster")]
    [Table("TSPL_ITEM_MASTER")]
    [XSProgram(Module= "MachineTest", Program= "ItemMaster")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsItemMaster : XpertDomainBase
    {
        private string? _ID = "Auto";
        private string? _Description;
        private decimal? _Rate = 0;
        private string? _Uom;

        public clsItemMaster() { }

        [DefaultValue("")]
        [Column("ICode", TypeName ="VARCHAR")]
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
        [Column("IName", TypeName ="VARCHAR")]
        [DisplayName("Item Name")]
        [GroupName("Basic Info")]
        public override string? Description
        {
            get { return  _Description; }
            set { _Description=value; }
        }

        [DefaultValue("0")]
        [Column("IRate")]
        [DisplayName("Rate")]
        [GroupName("Basic Info")]
        public decimal? Rate
        {
            get { return  _Rate; }
            set { _Rate=value; }
        }

        [DefaultValue("")]
        [Column("IUom", TypeName ="VARCHAR")]
        [DisplayName("UOM")]
        [GroupName("Basic Info")]
        public string? Uom
        {
            get { return  _Uom; }
            set { _Uom=value; }
        }

    }
}
