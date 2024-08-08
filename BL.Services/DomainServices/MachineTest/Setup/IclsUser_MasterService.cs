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
    public partial interface IclsUser_MasterService : IService<clsUser_Master,string> , IXpertCrudFunctionsDomain<clsUser_Master>
    {
         ICommand<IEnumerable<clsUser_Master>> GetAllCommand(int start, int pageSize);

         Task<IEnumerable<FinderData>> GetUser_TypeList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetClientList(string FinderType, string WhereExpression);
    }
}
