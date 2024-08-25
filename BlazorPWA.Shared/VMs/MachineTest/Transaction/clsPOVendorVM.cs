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
    public partial class clsPOVendorVM : XpertDomainChild, IXSFinderData
    {
        private int _RowNo;
        private string? _Code;
        private string? _Name;
        private string _ParentID;

        [DisplayName("Row No")]
        [GroupName("Testing")]
        [XpertRequired]
        [Key]
        public override int RowNo
        {
            get { return  _RowNo; }
            set { _RowNo=value; }
        }

        [DisplayName("Code")]
        [GroupName("Testing")]
        public string? Code
        {
            get { return  _Code; }
            set { _Code=value; }
        }

        [DisplayName("Name")]
        [GroupName("Testing")]
        [NotMapped]
        public string? Name
        {
            get { return  _Name; }
            set { _Name=value; }
        }

        [Key]
        public override string ParentID
        {
            get { return  _ParentID; }
            set { _ParentID=value; }
        }

    }
}
