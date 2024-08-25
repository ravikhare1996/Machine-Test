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
    public partial class clsPurchaseOrderVM : XpertDomainBase
    {
        private string? _ID = "Auto";
        private string? _Description;
        private DateTime? _PODate;
        private decimal? _POTotAmt = 0;
        private string? _PORemarks;
        private DateTime? _CreateDate;
        private DateTime? _ModifiyDate;
        private string? _POVCode;
        private decimal? _Document_Amount = 0;
        private byte[]? _filePhoto;
        private string? _filePhoto_FilePath;
        private string? _filePhoto_FileName;
        private string? _filePhoto_ContentType;
        private string? _PO_Options = "False";
        private List<clsPOVendorVM>? _Vendors;
        private List<clsFinderItemsVM>? _PO_ItemList;
        private List<clsPO_ItemVM>? _PO_Items;

        public clsPurchaseOrderVM()
        {
            Vendors = new List<clsPOVendorVM>();
            PO_ItemList = new List<clsFinderItemsVM>();
            PO_Items = new List<clsPO_ItemVM>();
        }

        [DefaultValue("")]
        [DisplayName("PO No")]
        [GroupName("Header")]
        [XpertRequired]
        [Key]
        [MaxLength(10)]
        public override string? ID
        {
            get { return  _ID; }
            set { _ID=value; }
        }

        [DefaultValue("")]
        [DisplayName("Comments")]
        [GroupName("Header")]
        [MaxLength(50)]
        public override string? Description
        {
            get { return  _Description; }
            set { _Description=value; }
        }

        [DefaultValue("'21-May-24 9:46:27 PM'")]
        [DisplayName("Date")]
        [GroupName("Header")]
        public DateTime? PODate
        {
            get { return  _PODate; }
            set { _PODate=value; }
        }

        [DefaultValue("0")]
        [DisplayName("Amount")]
        [GroupName("Header")]
        public decimal? POTotAmt
        {
            get { return  _POTotAmt=PO_Items.Sum(x=>x.POIAmt); }
            set {  _POTotAmt=PO_Items.Sum(x=>x.POIAmt); }
        }

        [DefaultValue("")]
        [DisplayName("Remarks")]
        [GroupName("Header")]
        [MaxLength(50)]
        public string? PORemarks
        {
            get { return  _PORemarks; }
            set { _PORemarks=value; }
        }

        [DefaultValue("'22-May-24 10:25:31 PM'")]
        [DisplayName("Create DateTime")]
        [GroupName("Header")]
        public DateTime? CreateDate
        {
            get { return  _CreateDate; }
            set { _CreateDate=value; }
        }

        [DefaultValue("'22-May-24 11:18:13 PM'")]
        [DisplayName("Modify Date")]
        [GroupName("Header")]
        public DateTime? ModifiyDate
        {
            get { return  _ModifiyDate; }
            set { _ModifiyDate=value; }
        }

        [DefaultValue("")]
        [DisplayName("Vendor")]
        [GroupName("Header")]
        public string? POVCode
        {
            get { return  _POVCode; }
            set { _POVCode=value; }
        }

        [DefaultValue("0")]
        [DisplayName("Document Amount")]
        [GroupName("Header")]
        [NotMapped]
        public decimal? Document_Amount
        {
            get { return  _Document_Amount; }
            set { _Document_Amount=value; }
        }

        [GroupName("Photograph")]
        public byte[]? filePhoto
        {
            get { return  _filePhoto; }
            set { _filePhoto=value; }
        }

        [DisplayName(" File Path")]
        [GroupName("Photograph")]
        public string? filePhoto_FilePath
        {
            get { return  _filePhoto_FilePath; }
            set { _filePhoto_FilePath=value; }
        }

        [GroupName("Photograph")]
        public string? filePhoto_FileName
        {
            get { return  _filePhoto_FileName; }
            set { _filePhoto_FileName=value; }
        }

        [DisplayName(" Content Type")]
        [GroupName("Photograph")]
        public string? filePhoto_ContentType
        {
            get { return  _filePhoto_ContentType; }
            set { _filePhoto_ContentType=value; }
        }

        [DefaultValue("False")]
        [DisplayName("Option1")]
        [GroupName("Options")]
        public string? PO_Options
        {
            get { return  _PO_Options; }
            set { _PO_Options=value; }
        }

        [ForeignKey("ParentID")]
        public virtual List<clsPOVendorVM>? Vendors
        {
            get { return  _Vendors; }
            set { _Vendors=value; }
        }

        [ForeignKey("ParentID")]
        public virtual List<clsFinderItemsVM>? PO_ItemList
        {
            get { return  _PO_ItemList; }
            set { _PO_ItemList=value; }
        }

        [ForeignKey("ParentID")]
        public virtual List<clsPO_ItemVM>? PO_Items
        {
            get { return  _PO_Items; }
            set { _PO_Items=value; }
        }

    }
}
