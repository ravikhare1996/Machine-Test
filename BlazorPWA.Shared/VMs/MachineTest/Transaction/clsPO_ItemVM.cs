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
    [Description("frmPurchaseOrder")]
    [XSProgram(Module= "MachineTest", Program= "PurchaseOrder")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsPO_ItemVM : XpertDomainChild
    {
        private int _RowNo;
        private string _POICode;
        private string _ItemName;
        private string _POIUOM;
        private decimal? _POIRate;
        private decimal? _POIQty;
        private decimal? _POIAmt;
        private decimal? _TotalQty;
        private string _ParentID;

        [DisplayName("Row No")]
        [GroupName("Details")]
        [Key]
        public override int RowNo
        {
            get { return  _RowNo; }
            set { _RowNo=value; }
        }

        [DisplayName("Item Code")]
        [GroupName("Details")]
        [MaxLength(32767)]
        public string POICode
        {
            get { return  _POICode; }
            set { _POICode=value; }
        }

        [DisplayName("Item Name")]
        [GroupName("Details")]
        [NotMapped]
        public string ItemName
        {
            get { return  _ItemName; }
            set { _ItemName=value; }
        }

        [DisplayName("UOM")]
        [GroupName("Details")]
        public string POIUOM
        {
            get { return  _POIUOM; }
            set { _POIUOM=value; }
        }

        [DisplayName("Rate")]
        [GroupName("Details")]
        public decimal? POIRate
        {
            get { return  _POIRate; }
            set { _POIRate=value; }
        }

        [DisplayName("Quantity")]
        [GroupName("Details")]
        public decimal? POIQty
        {
            get { return  _POIQty; }
            set { _POIQty=value; }
        }

        [DisplayName("Amount")]
        [GroupName("Details")]
        public decimal? POIAmt
        {
            get { return  _POIAmt=Math.Round((_POIRate ?? 0) * (_POIQty ?? 0), 2); }
            set {  _POIAmt=Math.Round((_POIRate ?? 0) * (_POIQty ?? 0), 2); }
        }

        [DisplayName("Total Quantity")]
        [GroupName("Details")]
        [NotMapped]
        public decimal? TotalQty
        {
            get { return  _TotalQty; }
            set { _TotalQty=value; }
        }

        [Key]
        public override string ParentID
        {
            get { return  _ParentID; }
            set { _ParentID=value; }
        }

    }
}
