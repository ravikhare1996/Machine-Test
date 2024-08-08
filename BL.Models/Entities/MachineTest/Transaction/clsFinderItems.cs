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
    [Table("FinderItems")]
    [XSProgram(Module= "MachineTest", Program= "PurchaseOrder")]
    [XSCodeType(Type= XSCodeType.Standard)]
    [PrimaryKey("ParentID","RowNo")]
    public partial class clsFinderItems : XpertDomainChild
    {
        private int _RowNo;
        private string _ParentID;

        [Column("Row No", Order =2)]
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
        [Column("POCode", TypeName ="VARCHAR", Order =1)]
        public override string ParentID
        {
            get { return  _ParentID; }
            set { _ParentID=value; }
        }

    }
}
