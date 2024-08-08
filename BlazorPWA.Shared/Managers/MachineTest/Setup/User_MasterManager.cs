using BlazorPWA.Shared.Data;
using BlazorPWA.Shared.Models;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using XpertStudio.Common.Data;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Globals;
using BlazorPWA.Shared.Routes;
using System.ComponentModel;
using XpertStudio.Common.Attributes;
using BlazorPWA.Shared.VMs;

namespace BlazorPWA.Shared.Managers
{
    [Description("Manager Class")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class User_MasterManager : CommonManager, IUser_MasterManager
    {
        private HttpClient _httpClient;

        public User_MasterManager(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IResult<byte[]>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
              ? Routes.User_MasterEndPoints.ExportData()
              : Routes.User_MasterEndPoints.ExportFiltered(searchString));
            if (response.IsSuccessStatusCode)
            {
            var byteArray = await response.Content.ReadAsByteArrayAsync();
            return Result<byte[]>.Success(byteArray);
            }
            else
            {
            return Result<byte[]>.Fail("Failed to export data");
            }
        }

        public async Task<IResult<string>> GetImageAsync(string ID)
        {
            var response = await _httpClient.GetAsync(Routes.User_MasterEndPoints.GetImage(ID));
            return await response.ToResult<string>();
             
             
        }

        public async Task<IEnumerable<clsUser_MasterVM>> GetAllAsync(PagedRequest request)
        {
            return  await _httpClient.GetFromJsonAsync<IEnumerable<clsUser_MasterVM>>(Routes.User_MasterEndPoints.GetAllPaged(request.PageNumber, request.PageSize, request.SearchString, request.Orderby));
        }

        public async Task<clsUser_MasterVM> GetDataAsync(string ID)
        {
            return await _httpClient.GetFromJsonAsync<clsUser_MasterVM>(Routes.User_MasterEndPoints.GetData(ID));
        }

        public async Task<clsUser_MasterVM> SaveAsync(clsUser_MasterVM entity)
        {
            entity.CompanyCode = CurrentLoginData.CurrentCompanyCode;
            entity.CreatedBy = CurrentLoginData.CurrentUserCode;
            var response = await _httpClient.PostAsJsonAsync(Routes.User_MasterEndPoints.SaveData(), entity);
            if (response.IsSuccessStatusCode)
            {
            entity = await response.Content.ReadFromJsonAsync<clsUser_MasterVM>();
            return entity;
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<clsUser_MasterVM> EditAsync(clsUser_MasterVM entity)
        {
            entity.CompanyCode = CurrentLoginData.CurrentCompanyCode;
            entity.LastModifiedBy = CurrentLoginData.CurrentUserCode;
            var response = await _httpClient.PutAsJsonAsync(Routes.User_MasterEndPoints.EditData(entity.ID), entity);
            if (response.IsSuccessStatusCode)
            {
            entity = await response.Content.ReadFromJsonAsync<clsUser_MasterVM>();
            return entity;
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var response = await _httpClient.DeleteAsync(Routes.User_MasterEndPoints.DeleteData(id));
            if (response.IsSuccessStatusCode)
            {
            return await response.Content.ReadFromJsonAsync<bool>();
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<IEnumerable<FinderData>> GetFinder(string? FinderName = null, string? WhereExpression = null)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.User_MasterEndPoints.GetFinder(FinderName,WhereExpression));
        }

        public async Task<int> GetCount(string? WhereExpression = null)
        {
            return await _httpClient.GetFromJsonAsync<int>(Routes.User_MasterEndPoints.GetCount(WhereExpression));
        }

        public async Task<clsUser_MasterVM> GetDefault()
        {
            return await _httpClient.GetFromJsonAsync<clsUser_MasterVM>(Routes.User_MasterEndPoints.GetDefault());
        }

        public async virtual Task<IEnumerable<CustomFinderData>?> GetUser_TypeList(clsUser_MasterVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CustomFinderData>>(Routes.User_MasterEndPoints.GetUser_TypeList(entity));
        }

        public async virtual Task<IEnumerable<FinderData>?> GetClientList(clsUser_MasterVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.User_MasterEndPoints.GetClientList(entity));
        }
    }
}
