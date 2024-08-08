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
    public partial class ItemMasterManager : CommonManager, IItemMasterManager
    {
        private HttpClient _httpClient;

        public ItemMasterManager(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IResult<byte[]>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
              ? Routes.ItemMasterEndPoints.ExportData()
              : Routes.ItemMasterEndPoints.ExportFiltered(searchString));
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
            var response = await _httpClient.GetAsync(Routes.ItemMasterEndPoints.GetImage(ID));
            return await response.ToResult<string>();
             
             
        }

        public async Task<IEnumerable<clsItemMasterVM>> GetAllAsync(PagedRequest request)
        {
            return  await _httpClient.GetFromJsonAsync<IEnumerable<clsItemMasterVM>>(Routes.ItemMasterEndPoints.GetAllPaged(request.PageNumber, request.PageSize, request.SearchString, request.Orderby));
        }

        public async Task<clsItemMasterVM> GetDataAsync(string ID)
        {
            return await _httpClient.GetFromJsonAsync<clsItemMasterVM>(Routes.ItemMasterEndPoints.GetData(ID));
        }

        public async Task<clsItemMasterVM> SaveAsync(clsItemMasterVM entity)
        {
            entity.CompanyCode = CurrentLoginData.CurrentCompanyCode;
            entity.CreatedBy = CurrentLoginData.CurrentUserCode;
            var response = await _httpClient.PostAsJsonAsync(Routes.ItemMasterEndPoints.SaveData(), entity);
            if (response.IsSuccessStatusCode)
            {
            entity = await response.Content.ReadFromJsonAsync<clsItemMasterVM>();
            return entity;
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<clsItemMasterVM> EditAsync(clsItemMasterVM entity)
        {
            entity.CompanyCode = CurrentLoginData.CurrentCompanyCode;
            entity.LastModifiedBy = CurrentLoginData.CurrentUserCode;
            var response = await _httpClient.PutAsJsonAsync(Routes.ItemMasterEndPoints.EditData(entity.ID), entity);
            if (response.IsSuccessStatusCode)
            {
            entity = await response.Content.ReadFromJsonAsync<clsItemMasterVM>();
            return entity;
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var response = await _httpClient.DeleteAsync(Routes.ItemMasterEndPoints.DeleteData(id));
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
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.ItemMasterEndPoints.GetFinder(FinderName,WhereExpression));
        }

        public async Task<int> GetCount(string? WhereExpression = null)
        {
            return await _httpClient.GetFromJsonAsync<int>(Routes.ItemMasterEndPoints.GetCount(WhereExpression));
        }

        public async Task<clsItemMasterVM> GetDefault()
        {
            return await _httpClient.GetFromJsonAsync<clsItemMasterVM>(Routes.ItemMasterEndPoints.GetDefault());
        }
    }
}
