using BlazorPWA.Shared.Data;
using BlazorPWA.Shared.Models;
using BlazorPWA.Shared.Managers;
using Microsoft.JSInterop;
using MudBlazor;
using XpertStudio.Common.Data;
using BlazorPWA.Client.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Attributes;
using BlazorPWA.Shared.VMs;

namespace BlazorPWA.Client.Pages.MachineTest.Setup
{
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class Company_Master
    {
        private IEnumerable<clsCompanyMasterVM>  _pagedData;
        private MudDataGrid<clsCompanyMasterVM>  _Grid;
        private int _totalItems;
        private int _currentPage;
        private string searchString;
        private bool _loaded;

        [Inject]
        public ICompany_MasterManager Manager { get; set; }

        protected async override Task  OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _totalItems = await Manager.GetCount();
            _loaded = true;
        }

        private async Task<GridData<clsCompanyMasterVM>> ServerReload(GridState<clsCompanyMasterVM> state)
        {
            if (!string.IsNullOrWhiteSpace(searchString))
            {
              state.Page = 0;
            }
            await LoadData(state.Page, state.PageSize, state);
            return new GridData<clsCompanyMasterVM> { TotalItems = _totalItems, Items = _pagedData };
        }

        private async Task LoadData(int pageNumber, int pageSize, GridState<clsCompanyMasterVM> state)
        {
            string[] orderings = null;
            var request = new PagedRequest { PageNumber = (pageNumber) * state.PageSize,PageSize = pageSize , SearchString = searchString, Orderby = orderings };
            _pagedData =  await Manager.GetAllAsync(request);
        }

        private void OnSearch(string text)
        {
            searchString = text;
            _Grid.ReloadServerData();
        }

        private async Task ExportToExcel()
        {
            var result = await Manager.ExportToExcelAsync(searchString); 
            if (result.Succeeded)
            {
            var fileData = result.Data;
            var fileName = "Company_Master.xlsx";
            await JSRuntime.InvokeVoidAsync("saveAsFile", fileName, Convert.ToBase64String(fileData));
            }
            else
            {
            Console.WriteLine($"Failed to export data: {result.Messages}");
            }
        }

        private void DownloadExcelFile()
        {
            var excelBytes = ExcelService.GenerateExcelWorkbook(_pagedData);
            this.JSRuntime.InvokeVoidAsync("saveAsFile", $"Company_Master_{ DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx", Convert.ToBase64String(excelBytes));
        }

        private async Task Delete(string Id)
        {
            UriHelper.NavigateTo("/MachineTest/Setup/Company_MasterDelete/" + Id);
            PageHistoryState.AddPageToHistory(UriHelper.Uri);
        }

        protected void Save()
        {
            UriHelper.NavigateTo("/MachineTest/Setup/Company_MasterCreate/");
            PageHistoryState.AddPageToHistory(UriHelper.Uri);
        }

        protected void Edit(string Id)
        {
            UriHelper.NavigateTo("/MachineTest/Setup/Company_MasterEdit/" + Id);
            PageHistoryState.AddPageToHistory(UriHelper.Uri);
        }

        protected void View(string Id)
        {
            UriHelper.NavigateTo("/MachineTest/Setup/Company_MasterView/" + Id);
            PageHistoryState.AddPageToHistory(UriHelper.Uri);
        }

        private void RowClicked(clsCompanyMasterVM item)
        {
            SelectedRowChanged(item);
        }
    }
}
