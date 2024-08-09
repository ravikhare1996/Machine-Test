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
    public partial class clsFinderItems : XpertDomainChild, IXSFinderData
    {
        private int _RowNo;
        private string? _Code;
        private string? _Name;
        private string _ParentID;

        [Column("RowNo", Order =2)]
        [DisplayName("Row No")]
        [GroupName("xpertGroupBox1")]
        [XpertRequired]
        [Key]
        public override int RowNo
        {
            get { return  _RowNo; }
            set { _RowNo=value; }
        }

        [Column("Code", TypeName ="VARCHAR")]
        [DisplayName("Code")]
        [GroupName("xpertGroupBox1")]
        public string? Code
        {
            get { return  _Code; }
            set { _Code=value; }
        }

        [Column("Name", TypeName ="VARCHAR")]
        [DisplayName("Name")]
        [GroupName("xpertGroupBox1")]
        [NotMapped]
        public string? Name
        {
            get { return  _Name; }
            set { _Name=value; }
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
