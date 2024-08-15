using BlazorPWA.Shared.Managers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using XpertStudio.Common.Data;
using XpertStudio.Common.Enums;
using BlazorPWA.Shared.Routes;
using XpertStudio.Common.Attributes;
using System.Data;
using BlazorPWA.Shared.VMs;

namespace BlazorPWA.Client.Pages.MachineTest.Transaction
{
    [XSCodeType(Type = XSCodeType.Standard)]
    public partial class PurchaseOrderPO_ItemsGridPage
    {
        private List<string> editEvents = new();
        private clsPO_ItemVM SelectedItem = null;
        private clsPO_ItemVM elementBeforeEdit;
        private XSDataGrid<clsPO_ItemVM>? gv1;
        private PropertyColumn<clsPO_ItemVM, int>? POISNo;
        private XSFinder<FinderData>? POICode;
        private FinderData? _POICodeValue;
        private PropertyColumn<clsPO_ItemVM, string>? ItemName;
        private PropertyColumn<clsPO_ItemVM, string>? Uom;
        private PropertyColumn<clsPO_ItemVM, decimal?>? POIRate;
        private PropertyColumn<clsPO_ItemVM, decimal?>? POIQty;
        private AggregateDefinition<clsPO_ItemVM> _Sum_POIQty = new AggregateDefinition<clsPO_ItemVM> { Type = AggregateType.Sum, DisplayFormat = "Total: {value}" };
        private PropertyColumn<clsPO_ItemVM, decimal?>? POIAmt;
        private AggregateDefinition<clsPO_ItemVM> _Sum_POIAmt = new AggregateDefinition<clsPO_ItemVM> { Type = AggregateType.Sum, DisplayFormat = "Total: {value}" };
        private PropertyColumn<clsPO_ItemVM, decimal?>? TotalQty;

        [Parameter]
        public clsPurchaseOrderVM Model { get; set; } = new clsPurchaseOrderVM();

        [Parameter]
        public List<clsPO_ItemVM> GridData { get; set; }

        [Parameter]
        public string ParentID { get; set; }

        [Inject]
        public IPurchaseOrderManager Manager { get; set; }

        [Inject]
        protected IItemMasterManager POICodeManager { get; set; }

        protected IEnumerable<FinderData>? POICodeList { get; set; }

        private FinderData? POICodeValue
        {
            get { return _POICodeValue; }
            set
            {
                if (value == null)
                {
                    _POICodeValue = POICodeList?.FirstOrDefault(d => d.IsDefault == true);
                }
                else
                {
                    _POICodeValue = value;
                }
                SelectedItem.POICode = value?.Code;
            }
        }

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            if (SelectedItem == null)
            {
                SelectedItem = new clsPO_ItemVM();
            }
            if (SelectedItem.POICode != null)
            {
                var POICodeData = await POICodeManager.GetDataAsync(SelectedItem.POICode);
                if (POICodeData != null)
                    POICodeValue = new FinderData() { Code = POICodeData.ID, Name = POICodeData.Description };
                POICodeData = null;
            }
            StateHasChanged();
        }

        private void AddEmptyElement()
        {
            GridData.Add(new clsPO_ItemVM() { RowNo = GridData.Count + 1, ParentID = ParentID });
        }

        private void RowClicked(clsPO_ItemVM item)
        {
            SelectedItem = item;
            POICodeValue = GetPOICodeValue(item.POICode);
        }

        private void RemoveElement()
        {
            if (SelectedItem != null)
            {
                GridData.Remove(SelectedItem);
            }
        }

        private async Task<IEnumerable<FinderData>> SearchPOICode(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
            {
                return POICodeList;
            }
            return POICodeList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayPOICode(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
                return string.Empty;
            }
            if (SelectedItem != null)
            {
                SelectedItem.ItemName = CurrentData.Name;
            }
            return CurrentData.Code;
        }

        private FinderData GetPOICodeValue(string value)
        {
            if (POICodeValue == null)
            {
                POICodeValue = new FinderData();
            }
            POICodeValue.Code = value;
            return POICodeValue;
        }
    }
}
