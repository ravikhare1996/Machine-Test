using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;
using  XpertStudio.Framework;
using  XpertStudio.Framework.Domain;
using  XpertStudio.Common.Data;
using  XpertStudio.Common.Enums;
using  XpertStudio.Common.Attributes;
using  XpertStudio.Common.Globals;
using  MachineTest.Domain.Entities;

namespace MachineTest.Services.DomainServices
{
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial interface IclsVendorMasterService : IService<clsVendorMaster,string> , IXpertCrudFunctionsDomain<clsVendorMaster>
    {
         ICommand<IEnumerable<clsVendorMaster>> GetAllCommand(int start, int pageSize);
    }
}