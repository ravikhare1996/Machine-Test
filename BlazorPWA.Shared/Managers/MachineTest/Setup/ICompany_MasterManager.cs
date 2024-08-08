using BlazorPWA.Shared.Data;
using BlazorPWA.Shared.Models;
using System.Threading.Tasks;
using XpertStudio.Common.Data;
using XpertStudio.Common.Enums;
using BlazorPWA.Shared.Routes;
using XpertStudio.Common.Attributes;
using BlazorPWA.Shared.VMs;

namespace BlazorPWA.Shared.Managers
{
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial interface ICompany_MasterManager : IGenericManager<clsCompanyMasterVM>
    {
         Task<IEnumerable<CustomFinderData>?> GetCompany_TypeList(clsCompanyMasterVM entity);

         Task<IEnumerable<FinderData>?> GetProductList(clsCompanyMasterVM entity);

         Task<IEnumerable<FinderData>?> GetStateList(clsCompanyMasterVM entity);
    }
}
