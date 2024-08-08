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
    public partial interface IEmployeeMasterManager : IGenericManager<clsEmployeeVM>
    {
         Task<IEnumerable<CustomFinderData>?> GetPAYMENT_TYPEList(clsEmployeeVM entity);

         Task<IEnumerable<FinderData>?> GetDESIGNATIONList(clsEmployeeVM entity);

         Task<IEnumerable<CustomFinderData>?> GetCategory_TypeList(clsEmployeeVM entity);

         Task<IEnumerable<CustomFinderData>?> GetPF_Phone_Number_TypeList(clsEmployeeVM entity);

         Task<IEnumerable<CustomFinderData>?> GetESI_Phone_Number_TypeList(clsEmployeeVM entity);
    }
}
