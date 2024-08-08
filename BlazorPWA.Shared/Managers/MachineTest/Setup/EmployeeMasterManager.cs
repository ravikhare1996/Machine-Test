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
    public partial class EmployeeMasterManager : CommonManager, IEmployeeMasterManager
    {
        private HttpClient _httpClient;

        public EmployeeMasterManager(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IResult<byte[]>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
              ? Routes.EmployeeMasterEndPoints.ExportData()
              : Routes.EmployeeMasterEndPoints.ExportFiltered(searchString));
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
            var response = await _httpClient.GetAsync(Routes.EmployeeMasterEndPoints.GetImage(ID));
            return await response.ToResult<string>();
             
             
        }

        public async Task<IEnumerable<clsEmployeeVM>> GetAllAsync(PagedRequest request)
        {
            return  await _httpClient.GetFromJsonAsync<IEnumerable<clsEmployeeVM>>(Routes.EmployeeMasterEndPoints.GetAllPaged(request.PageNumber, request.PageSize, request.SearchString, request.Orderby));
        }

        public async Task<clsEmployeeVM> GetDataAsync(string ID)
        {
            return await _httpClient.GetFromJsonAsync<clsEmployeeVM>(Routes.EmployeeMasterEndPoints.GetData(ID));
        }

        public async Task<clsEmployeeVM> SaveAsync(clsEmployeeVM entity)
        {
            entity.CompanyCode = CurrentLoginData.CurrentCompanyCode;
            entity.CreatedBy = CurrentLoginData.CurrentUserCode;
            var response = await _httpClient.PostAsJsonAsync(Routes.EmployeeMasterEndPoints.SaveData(), entity);
            if (response.IsSuccessStatusCode)
            {
            entity = await response.Content.ReadFromJsonAsync<clsEmployeeVM>();
            return entity;
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<clsEmployeeVM> EditAsync(clsEmployeeVM entity)
        {
            entity.CompanyCode = CurrentLoginData.CurrentCompanyCode;
            entity.LastModifiedBy = CurrentLoginData.CurrentUserCode;
            var response = await _httpClient.PutAsJsonAsync(Routes.EmployeeMasterEndPoints.EditData(entity.ID), entity);
            if (response.IsSuccessStatusCode)
            {
            entity = await response.Content.ReadFromJsonAsync<clsEmployeeVM>();
            return entity;
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var response = await _httpClient.DeleteAsync(Routes.EmployeeMasterEndPoints.DeleteData(id));
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
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.EmployeeMasterEndPoints.GetFinder(FinderName,WhereExpression));
        }

        public async Task<int> GetCount(string? WhereExpression = null)
        {
            return await _httpClient.GetFromJsonAsync<int>(Routes.EmployeeMasterEndPoints.GetCount(WhereExpression));
        }

        public async Task<clsEmployeeVM> GetDefault()
        {
            return await _httpClient.GetFromJsonAsync<clsEmployeeVM>(Routes.EmployeeMasterEndPoints.GetDefault());
        }

        public async virtual Task<IEnumerable<CustomFinderData>?> GetPAYMENT_TYPEList(clsEmployeeVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CustomFinderData>>(Routes.EmployeeMasterEndPoints.GetPAYMENT_TYPEList(entity));
        }

        public async virtual Task<IEnumerable<FinderData>?> GetDESIGNATIONList(clsEmployeeVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.EmployeeMasterEndPoints.GetDESIGNATIONList(entity));
        }

        public async virtual Task<IEnumerable<CustomFinderData>?> GetCategory_TypeList(clsEmployeeVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CustomFinderData>>(Routes.EmployeeMasterEndPoints.GetCategory_TypeList(entity));
        }

        public async virtual Task<IEnumerable<CustomFinderData>?> GetPF_Phone_Number_TypeList(clsEmployeeVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CustomFinderData>>(Routes.EmployeeMasterEndPoints.GetPF_Phone_Number_TypeList(entity));
        }

        public async virtual Task<IEnumerable<CustomFinderData>?> GetESI_Phone_Number_TypeList(clsEmployeeVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CustomFinderData>>(Routes.EmployeeMasterEndPoints.GetESI_Phone_Number_TypeList(entity));
        }
    }
}
