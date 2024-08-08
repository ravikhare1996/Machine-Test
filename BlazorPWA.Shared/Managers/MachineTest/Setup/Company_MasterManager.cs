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
    public partial class Company_MasterManager : CommonManager, ICompany_MasterManager
    {
        private HttpClient _httpClient;

        public Company_MasterManager(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IResult<byte[]>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
              ? Routes.Company_MasterEndPoints.ExportData()
              : Routes.Company_MasterEndPoints.ExportFiltered(searchString));
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
            var response = await _httpClient.GetAsync(Routes.Company_MasterEndPoints.GetImage(ID));
            return await response.ToResult<string>();
             
             
        }

        public async Task<IEnumerable<clsCompanyMasterVM>> GetAllAsync(PagedRequest request)
        {
            return  await _httpClient.GetFromJsonAsync<IEnumerable<clsCompanyMasterVM>>(Routes.Company_MasterEndPoints.GetAllPaged(request.PageNumber, request.PageSize, request.SearchString, request.Orderby));
        }

        public async Task<clsCompanyMasterVM> GetDataAsync(string ID)
        {
            return await _httpClient.GetFromJsonAsync<clsCompanyMasterVM>(Routes.Company_MasterEndPoints.GetData(ID));
        }

        public async Task<clsCompanyMasterVM> SaveAsync(clsCompanyMasterVM entity)
        {
            entity.CompanyCode = CurrentLoginData.CurrentCompanyCode;
            entity.CreatedBy = CurrentLoginData.CurrentUserCode;
            var response = await _httpClient.PostAsJsonAsync(Routes.Company_MasterEndPoints.SaveData(), entity);
            if (response.IsSuccessStatusCode)
            {
            entity = await response.Content.ReadFromJsonAsync<clsCompanyMasterVM>();
            return entity;
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<clsCompanyMasterVM> EditAsync(clsCompanyMasterVM entity)
        {
            entity.CompanyCode = CurrentLoginData.CurrentCompanyCode;
            entity.LastModifiedBy = CurrentLoginData.CurrentUserCode;
            var response = await _httpClient.PutAsJsonAsync(Routes.Company_MasterEndPoints.EditData(entity.ID), entity);
            if (response.IsSuccessStatusCode)
            {
            entity = await response.Content.ReadFromJsonAsync<clsCompanyMasterVM>();
            return entity;
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var response = await _httpClient.DeleteAsync(Routes.Company_MasterEndPoints.DeleteData(id));
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
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.Company_MasterEndPoints.GetFinder(FinderName,WhereExpression));
        }

        public async Task<int> GetCount(string? WhereExpression = null)
        {
            return await _httpClient.GetFromJsonAsync<int>(Routes.Company_MasterEndPoints.GetCount(WhereExpression));
        }

        public async Task<clsCompanyMasterVM> GetDefault()
        {
            return await _httpClient.GetFromJsonAsync<clsCompanyMasterVM>(Routes.Company_MasterEndPoints.GetDefault());
        }

        public async virtual Task<IEnumerable<CustomFinderData>?> GetCompany_TypeList(clsCompanyMasterVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<CustomFinderData>>(Routes.Company_MasterEndPoints.GetCompany_TypeList(entity));
        }

        public async virtual Task<IEnumerable<FinderData>?> GetProductList(clsCompanyMasterVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.Company_MasterEndPoints.GetProductList(entity));
        }

        public async virtual Task<IEnumerable<FinderData>?> GetStateList(clsCompanyMasterVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.Company_MasterEndPoints.GetStateList(entity));
        }
    }
}
