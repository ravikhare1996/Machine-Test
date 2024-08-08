using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpertStudio.Framework.Attributes;
using XpertStudio.Common.Enums;

namespace MachineTest.Domain.Entities
{
    public partial class clsCompanyMaster
    {

        private string? _CompanyCode;

        [DefaultValue("")]        
        [DisplayName("Company Code")]
        [GroupName("Basic Info")]
        [NotMapped]

        public override string? CompanyCode
        {
            get { return _CompanyCode; }
            set { _CompanyCode = value; }
        }
        private string? _CreatedBy;
        [DefaultValue("")]              
        [GroupName("Basic Info")]
        [NotMapped]
        public override string? CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        private DateTime? _CreatedDatetime;
        [DefaultValue("")]         
        [GroupName("Basic Info")]
        [NotMapped]
        public override DateTime? CreatedDatetime
        {
            get { return _CreatedDatetime; }
            set { _CreatedDatetime = value; }
        }
        private string? _Doc_Prefix;
        [DefaultValue("")]            
        [GroupName("Basic Info")]
        [NotMapped]
        public override string? Doc_Prefix
        {
            get { return _Doc_Prefix; }
            set { _Doc_Prefix = value; }
        }
        private XpertDocumentTypes? _Document_Type;
        [DefaultValue("")]                
        [GroupName("Basic Info")]
        [NotMapped]
        public override XpertDocumentTypes? Document_Type
        {
            get { return _Document_Type; }
            set { _Document_Type = value; }
        }
        private bool? _InActivated;
        [DefaultValue("")]        
        [GroupName("Basic Info")]
        [NotMapped]
        public override bool? InActivated
        {
            get { return _InActivated; }
            set { _InActivated = value; }
        }
        private string? _LastModifiedBy;
        [DefaultValue("")]
        [GroupName("Basic Info")]
        [NotMapped]
        public override string? LastModifiedBy
        {
            get { return _LastModifiedBy; }
            set { _LastModifiedBy = value; }
        }
        private DateTime? _LastModifiedDatetime;
        [DefaultValue("")]                
        [GroupName("Basic Info")]
        [NotMapped]
        public override DateTime? LastModifiedDatetime
        {
            get { return _LastModifiedDatetime; }
            set { _LastModifiedDatetime = value; }
        }
        private bool? _IsDefault;
        [DefaultValue("")]
        [GroupName("Basic Info")]
        [NotMapped]
        public override bool? IsDefault
        {
            get { return _IsDefault; }
            set { _IsDefault = value; }
        }
    }
}
