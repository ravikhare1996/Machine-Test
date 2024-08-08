using  System;
using  System.Collections.Generic;
using  System.ComponentModel;
using  System.ComponentModel.DataAnnotations;
using  System.ComponentModel.DataAnnotations.Schema;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;
using  XpertStudio.Framework.Domain;
using  XpertStudio.Framework;
using  XpertStudio.Framework.Attributes;
using  XpertStudio.Common.Enums;
using  XpertStudio.Common.Attributes;
using  MachineTest.Domain.Entities;

namespace MachineTest.Domain.Rules
{
    [Description("Domain Rules")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsVendorMasterRules : XpertDomainRuleBase<clsVendorMaster> 
    {
        protected clsVendorMaster _domain;

        public clsVendorMasterRules(clsVendorMaster domain)
        {
             _domain = domain;
        }


        protected override void OnValidate()
        {
            OnValidateDomain(_domain);
        }
    }
}
