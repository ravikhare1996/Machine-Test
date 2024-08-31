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
    [Description("frmPurchaseOrder")]
    [Table("TSPL_PO")]
    [XSProgram(Module= "MachineTest", Program= "PurchaseOrder")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsPurchaseOrder : XpertDomainBase
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
        private List<clsFinderItems>? _PO_ItemList;
        private List<clsPO_Item>? _PO_Items;

        public clsPurchaseOrder()
        {
            PO_ItemList = new List<clsFinderItems>();
            PO_Items = new List<clsPO_Item>();
        }

        [DefaultValue("")]
        [Column("POCode", TypeName ="VARCHAR")]
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
        [Column("POComment", TypeName ="VARCHAR")]
        [DisplayName("Comments")]
        [GroupName("Header")]
        [MaxLength(50)]
        public override string? Description
        {
            get { return  _Description; }
            set { _Description=value; }
        }

        [DefaultValue("'21-May-24 9:46:27 PM'")]
        [Column("PODate")]
        [DisplayName("Date")]
        [GroupName("Header")]
        public DateTime? PODate
        {
            get { return  _PODate; }
            set { _PODate=value; }
        }

        [DefaultValue("0")]
        [Column("POTotAmt")]
        [DisplayName("Amount")]
        [GroupName("Header")]
        public decimal? POTotAmt
        {
            get { return  _POTotAmt=PO_Items.Sum(x=>x.POIAmt); }
            set {  _POTotAmt=PO_Items.Sum(x=>x.POIAmt); }
        }

        [DefaultValue("")]
        [Column("PORemarks", TypeName ="VARCHAR")]
        [DisplayName("Remarks")]
        [GroupName("Header")]
        [MaxLength(50)]
        public string? PORemarks
        {
            get { return  _PORemarks; }
            set { _PORemarks=value; }
        }

        [DefaultValue("'22-May-24 10:25:31 PM'")]
        [Column("CreateDate")]
        [DisplayName("Create DateTime")]
        [GroupName("Header")]
        public DateTime? CreateDate
        {
            get { return  _CreateDate; }
            set { _CreateDate=value; }
        }

        [DefaultValue("'22-May-24 11:18:13 PM'")]
        [Column("ModifiyDate")]
        [DisplayName("Modify Date")]
        [GroupName("Header")]
        public DateTime? ModifiyDate
        {
            get { return  _ModifiyDate; }
            set { _ModifiyDate=value; }
        }

        [DefaultValue("")]
        [Column("POVCode", TypeName ="VARCHAR")]
        [DisplayName("Vendor")]
        [GroupName("Header")]
        public string? POVCode
        {
            get { return  _POVCode; }
            set { _POVCode=value; }
        }

        [DefaultValue("0")]
        [Column("Document_Amount")]
        [DisplayName("Document Amount")]
        [GroupName("Header")]
        [NotMapped]
        public decimal? Document_Amount
        {
            get { return  _Document_Amount; }
            set { _Document_Amount=value; }
        }

        [XSCodeType(Type = XSCodeType.Custom)]
        [GroupName("Photograph")]
        [Column("File_Content")]
        public byte[]? filePhoto
        {
            get { return  _filePhoto; }
            set { _filePhoto=value; }
        }



        [XSCodeType(Type = XSCodeType.Custom)]
        [Column("filePhoto_FilePath", TypeName ="VARCHAR")]
        [DisplayName(" File Path")]
        [GroupName("Photograph")]
        [NotMapped]
        public string? filePhoto_FilePath
        {
            get { return  _filePhoto_FilePath; }
            set { _filePhoto_FilePath=value; }
        }



        [XSCodeType(Type = XSCodeType.Custom)]
        [Column("File_Name", TypeName ="VARCHAR")]
        [GroupName("Photograph")]
        public string? filePhoto_FileName
        {
            get { return  _filePhoto_FileName; }
            set { _filePhoto_FileName=value; }
        }



        [XSCodeType(Type = XSCodeType.Custom)]
        [Column("Conytent_Type", TypeName ="VARCHAR")]
        [DisplayName("Content Type")]
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
        public virtual List<clsFinderItems>? PO_ItemList
        {
            get { return  _PO_ItemList; }
            set { _PO_ItemList=value; }
        }

        [ForeignKey("ParentID")]
        public virtual List<clsPO_Item>? PO_Items
        {
            get { return  _PO_Items; }
            set { _PO_Items=value; }
        }


        [NotMapped]
        [XSCodeType(Type = XSCodeType.Custom)]
        public override DateTime? CreatedDatetime 
        {
            get { return _CreateDate; }
            set 
            { 
                base.CreatedDatetime = value;
                _CreateDate = value;
            }
        }



        [NotMapped]        
        [XSCodeType(Type = XSCodeType.Custom)]
        public override DateTime? LastModifiedDatetime
        {
            get { return _ModifiyDate; }
            set 
            { 
                base.LastModifiedDatetime = value;
                _ModifiyDate = value;
            }
        }


    }
}
