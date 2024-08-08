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
    public partial interface IclsEmployeeService : IService<clsEmployee,string> , IXpertCrudFunctionsDomain<clsEmployee>
    {
         ICommand<IEnumerable<clsEmployee>> GetAllCommand(int start, int pageSize);

         Task<IEnumerable<FinderData>> GetPAYMENT_TYPEList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetDESIGNATIONList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetCategory_TypeList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetPF_Phone_Number_TypeList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetESI_Phone_Number_TypeList(string FinderType, string WhereExpression);
    }
}
