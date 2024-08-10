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
    public partial class PurchaseOrderManager : CommonManager, IPurchaseOrderManager
    {
        private HttpClient _httpClient;

        public PurchaseOrderManager(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IResult<byte[]>> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
              ? Routes.PurchaseOrderEndPoints.ExportData()
              : Routes.PurchaseOrderEndPoints.ExportFiltered(searchString));
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
            var response = await _httpClient.GetAsync(Routes.PurchaseOrderEndPoints.GetImage(ID));
            return await response.ToResult<string>();
             
             
        }

        public async Task<IEnumerable<clsPurchaseOrderVM>> GetAllAsync(PagedRequest request)
        {
            return  await _httpClient.GetFromJsonAsync<IEnumerable<clsPurchaseOrderVM>>(Routes.PurchaseOrderEndPoints.GetAllPaged(request.PageNumber, request.PageSize, request.SearchString, request.Orderby));
        }

        public async Task<clsPurchaseOrderVM> GetDataAsync(string ID)
        {
            return await _httpClient.GetFromJsonAsync<clsPurchaseOrderVM>(Routes.PurchaseOrderEndPoints.GetData(ID));
        }

        public async Task<clsPurchaseOrderVM> SaveAsync(clsPurchaseOrderVM entity)
        {
            entity.CompanyCode = CurrentLoginData.CurrentCompanyCode;
            entity.CreatedBy = CurrentLoginData.CurrentUserCode;
            var response = await _httpClient.PostAsJsonAsync(Routes.PurchaseOrderEndPoints.SaveData(), entity);
            if (response.IsSuccessStatusCode)
            {
            entity = await response.Content.ReadFromJsonAsync<clsPurchaseOrderVM>();
            return entity;
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<clsPurchaseOrderVM> EditAsync(clsPurchaseOrderVM entity)
        {
            entity.CompanyCode = CurrentLoginData.CurrentCompanyCode;
            entity.LastModifiedBy = CurrentLoginData.CurrentUserCode;
            var response = await _httpClient.PutAsJsonAsync(Routes.PurchaseOrderEndPoints.EditData(entity.ID), entity);
            if (response.IsSuccessStatusCode)
            {
            entity = await response.Content.ReadFromJsonAsync<clsPurchaseOrderVM>();
            return entity;
            }
            else
            {
            throw new Exception("Error while processing the request." + response.Content);
            }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var response = await _httpClient.DeleteAsync(Routes.PurchaseOrderEndPoints.DeleteData(id));
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
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.PurchaseOrderEndPoints.GetFinder(FinderName,WhereExpression));
        }

        public async Task<int> GetCount(string? WhereExpression = null)
        {
            return await _httpClient.GetFromJsonAsync<int>(Routes.PurchaseOrderEndPoints.GetCount(WhereExpression));
        }

        public async Task<clsPurchaseOrderVM> GetDefault()
        {
            return await _httpClient.GetFromJsonAsync<clsPurchaseOrderVM>(Routes.PurchaseOrderEndPoints.GetDefault());
        }

        public async virtual Task<IEnumerable<FinderData>?> GetPOVCodeList(clsPurchaseOrderVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.PurchaseOrderEndPoints.GetPOVCodeList(entity));
        }

        public async virtual Task<IEnumerable<FinderData>?> GetPOItemListList(clsPurchaseOrderVM entity)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<FinderData>>(Routes.PurchaseOrderEndPoints.GetPOItemListList(entity));
        }
    }
}
