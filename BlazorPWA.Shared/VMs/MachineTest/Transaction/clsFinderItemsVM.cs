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
using XpertStudio.Common.Data;

namespace BlazorPWA.Shared.VMs
{
    [Description("frmPurchaseOrder")]
    [XSProgram(Module= "MachineTest", Program= "PurchaseOrder")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsFinderItemsVM : XpertDomainChild,IFinderData
    {
        private int _RowNo;
        private string _ParentID=string.Empty;

        [DisplayName("Row No")]
        [GroupName("xpertGroupBox1")]
        [XpertRequired]
        [Key]
        public override int RowNo
        {
            get { return  _RowNo; }
            set { _RowNo=value; }
        }

        [Key]
        public override string ParentID
        {
            get { return  _ParentID; }
            set { _ParentID=value; }
        }
        public string? Code
        {
            get;
            set;
        }
        [NotMapped]
        public string? Name
        {
            get;
            set;
        }
        [NotMapped]
        public string? Description
        {
            get;
            set;
        }
        [NotMapped]
        public string? Description2
        {
            get;
            set;
        }
        [NotMapped]
        public bool? IsDefault
        {
            get;
            set;
        }
        [NotMapped]
        public bool Selected
        {
            get;
            set;
        }
    }
}