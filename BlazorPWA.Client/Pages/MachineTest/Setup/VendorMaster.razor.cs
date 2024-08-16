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
    public partial class VendorMaster
    {
        private IEnumerable<clsVendorMasterVM>  _pagedData;
        private XSDataGrid<clsVendorMasterVM>  _Grid;
        private int _totalItems;
        private int _currentPage;
        private string searchString;
        private bool _loaded;

        [Inject]
        public IVendorMasterManager Manager { get; set; }

        protected async override Task  OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _totalItems = await Manager.GetCount();
            _loaded = true;
        }

        private async Task<GridData<clsVendorMasterVM>> ServerReload(GridState<clsVendorMasterVM> state)
        {
            if (!string.IsNullOrWhiteSpace(searchString))
            {
              state.Page = 0;
            }
            await LoadData(state.Page, state.PageSize, state);
            if (_Grid != null && SelectedItems != null)
            {
               SetSelectedItems(SelectedItems?.ToList());
            }
            return new GridData<clsVendorMasterVM> { TotalItems = _totalItems, Items = _pagedData };
        }

        private async Task LoadData(int pageNumber, int pageSize, GridState<clsVendorMasterVM> state)
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
            var fileName = "VendorMaster.xlsx";
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
            this.JSRuntime.InvokeVoidAsync("saveAsFile", $"VendorMaster_{ DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx", Convert.ToBase64String(excelBytes));
        }

        private async Task Delete(string Id)
        {
            UriHelper.NavigateTo("/MachineTest/Setup/VendorMasterDelete/" + Id);
            PageHistoryState.AddPageToHistory(UriHelper.Uri);
        }

        protected void Save()
        {
            UriHelper.NavigateTo("/MachineTest/Setup/VendorMasterCreate/");
            PageHistoryState.AddPageToHistory(UriHelper.Uri);
        }

        protected void Edit(string Id)
        {
            UriHelper.NavigateTo("/MachineTest/Setup/VendorMasterEdit/" + Id);
            PageHistoryState.AddPageToHistory(UriHelper.Uri);
        }

        protected void View(string Id)
        {
            UriHelper.NavigateTo("/MachineTest/Setup/VendorMasterView/" + Id);
            PageHistoryState.AddPageToHistory(UriHelper.Uri);
        }

        private void RowClicked(clsVendorMasterVM item)
        {
            SelectedRowChanged(item);
        }

        private void SelectedItemsChanged(HashSet<clsVendorMasterVM> items)
        {
            var lst = new List<FinderData>();
            if (items!=null)
            {
            foreach (var item in items)
             {
              lst.Add(new FinderData() { Code = item.ID, Name = item.Description });
             }
            }
            SelectedRowsChanged(lst.ToList<IFinderData>());
        }

        private void SetSelectedItems(List<IFinderData>? selectedItems)
        {
            if (selectedItems==null)
            {
            return;
            }
            HashSet<clsVendorMasterVM> items = new HashSet<clsVendorMasterVM>();
            foreach (var finderData in selectedItems)
            {
              var selItem = _pagedData.FirstOrDefault(itm => finderData.Code == itm.ID);
              if (selItem != null)
                items.Add(selItem);
            }
            _Grid.Selection= items;
        }
    }
}
