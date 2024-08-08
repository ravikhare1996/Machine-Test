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
    public partial interface IUser_MasterManager : IGenericManager<clsUser_MasterVM>
    {
         Task<IEnumerable<CustomFinderData>?> GetUser_TypeList(clsUser_MasterVM entity);

         Task<IEnumerable<FinderData>?> GetClientList(clsUser_MasterVM entity);
    }
}
