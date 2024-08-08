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
    public partial interface IclsCompanyMasterService : IService<clsCompanyMaster,string> , IXpertCrudFunctionsDomain<clsCompanyMaster>
    {
         ICommand<IEnumerable<clsCompanyMaster>> GetAllCommand(int start, int pageSize);

         Task<IEnumerable<FinderData>> GetCompany_TypeList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetBranch_TypeList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetProductList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetStateList(string FinderType, string WhereExpression);
    }
}
