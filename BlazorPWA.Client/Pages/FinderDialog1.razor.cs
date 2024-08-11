
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using MudBlazor.XS.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using XpertStudio.Common.Data;

namespace BlazorPWA.Client.Pages
{
#nullable enable
    public partial class FinderDialog1
    {
        //private IEnumerable<IFinderData> _pagedData;
        //private MudTable<IFinderData> _table;
        //private int _totalItems;
        //private int _currentPage;
        //private string searchString;
        //private bool _loaded;

        [Parameter]
        public string? Header { get; set; }


        [Parameter]
        public string? FinderUrl { get; set; }

        [Parameter]
        public Type? FinderPage { get; set; }

        [Parameter]
        public DataTable? DataSource { get; set; }

        [Parameter]
        public IEnumerable<IFinderData>? Items { get; set; }

        [Parameter]
        public IFinderData? SelectedData { get; set; }
        public XSCustomFinderParameters? CustomFinderParameters { get; set; }

        //property to control the multi selection in finder and its dialog
        [Parameter]
        public bool IsMultiSelectFinder { get; set; } = false;
        public bool IsCustomFinder { get; set; }=false;
        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            if (DataSource != null)
            {
                TotalItems = DataSource.Rows.Count;
                Items = new List<IFinderData>();
                foreach (DataRow item in DataSource.Rows)
                {
                    Items.ToList().Add(new FinderData() { Code = (string)item["Code"], Name = (string)item["Name"] });
                }
            }

            else if (FinderPage != null && FinderUrl != null)
            {
                //do something
            }
            else if (GetPaginatedDataAsync != null)
            {
                //do something
            }
            else if (Items != null)
            {
                TotalItems = Items.Count();
            }

            Loaded = true;
        }

        private async Task<TableData<IFinderData>> ServerReload(TableState state)
        {
            if (!string.IsNullOrWhiteSpace(SearchString))
            {
                state.Page = 0;
            }
            await LoadData(state.Page, state.PageSize, state);
            return new TableData<IFinderData> { TotalItems = TotalItems, Items = PagedData };
        }

        private async Task LoadData(int pageNumber, int pageSize, TableState state)
        {
            string[]? orderings = null;
            if (!string.IsNullOrEmpty(state.SortLabel))
            {
                orderings = state.SortDirection != SortDirection.None ? new[] { $"{state.SortLabel}{state.SortDirection}" } : new[] { $"{state.SortLabel}" };
            }
            //var request = new PagedRequest { PageNumber = (pageNumber) * state.PageSize, PageSize = pageSize, SearchString = searchString, Orderby = orderings };
            //_pagedData = await Manager.GetAllAsync(request);
            if (GetPaginatedDataAsync != null)
            {
                var request = new PagedRequest { PageNumber = (pageNumber) * state.PageSize, PageSize = pageSize, SearchString = SearchString, Orderby = orderings };
                PagedData = await GetPaginatedDataAsync(request);
            }
            else
            {
                if (Items == null)
                {
                    return;
                }
                if (SearchString != null && SearchString.Length > 0)
                {
                    PagedData = Items.Where(i => (i.Code.Contains(SearchString, StringComparison.CurrentCultureIgnoreCase) == true || i.Name.Contains(SearchString, StringComparison.CurrentCultureIgnoreCase) == true)).ToList();
                }
                else
                {
                    PagedData = Items;
                }
            }


        }

        private void OnSearch(string text)
        {
            SearchString = text;
            mTable?.ReloadServerData();
        }


        protected void SelectRow(string Code)
        {
            SelectedData = Items?.FirstOrDefault(i => i.Code == Code);
        }
        //Finder rendering logic
        private RenderFragment? FinderComponentRenderer(string? componentUrl)
        {
            try
            {
                if (componentUrl == null || FinderPage == null)
                    return null;
                return builder =>
                {
#pragma warning disable IL2072
                    builder.OpenComponent(0, FinderPage);
#pragma warning restore IL2072
                    //builder.AddAttribute(1, "ChildContent", (RenderFragment)(builder2 =>
                    //{
                    //    //builder2.OpenComponent(0, Type.GetType(componentUrl));
                    //    builder2.OpenComponent(0, FinderPage);
                    //    builder2.CloseComponent();
                    //}));
                    if (IsMultiSelectFinder == false)
                    {
                        builder.AddAttribute(1, "OnSelectedDataChanged", new Action<IFinderData>(OnFinderDataChanged));
                        //New Code(07082024)
                        builder.AddAttribute(2, "SelectedData", SelectedData);
                    }
                    else
                    {
                        builder.AddAttribute(1, "OnSelectedRowsChanged", new Action<List<IFinderData>>(OnFinderSelectedRowsChanged));
                        builder.AddAttribute(2, "SelectedRows", SelectedItems?.ToList());
                        //New Code(07082024)
                        //var items=new List<IFinderData>();
                        //items.Add(new FinderData() { Code = "I005", Name = "Bag" });
                        //items.Add(new FinderData() { Code = "I006", Name = "Mouse" });
                        //builder.AddAttribute(2, "SelectedRows", items);
                    }

                    if (CustomFinderParameters != null)
                    {
                        //New Code(07082024)
                        builder.AddAttribute(3, "ReportID", CustomFinderParameters.ReportID);
                        builder.AddAttribute(4, "Query", CustomFinderParameters.Query);
                        builder.AddAttribute(5, "CodeColumn", CustomFinderParameters.CodeColumn);
                        builder.AddAttribute(6, "NameColumn", CustomFinderParameters.NameColumn);
                        builder.AddAttribute(7, "WhereClause", CustomFinderParameters.WhereClause);
                        builder.AddAttribute(8, "strCurrCode", CustomFinderParameters.strCurrCode);
                        builder.AddAttribute(9, "strOrderByColumns", CustomFinderParameters.strOrderByColumns);
                        builder.AddAttribute(10, "isShowSelectForm", CustomFinderParameters.isShowSelectForm);
                        builder.AddAttribute(11, "strFormName", CustomFinderParameters.strFormName);
                        builder.AddAttribute(12, "DateColumn", CustomFinderParameters.DateColumn);
                        builder.AddAttribute(13, "IsMultiSelect", IsMultiSelectFinder);
                        builder.AddAttribute(14, "dt", CustomFinderParameters.dt);
                        builder.AddAttribute(15, "GetPaginatedDataMethod", CustomFinderParameters.GetPaginatedDataMethod);
                        builder.AddAttribute(16, "Items", CustomFinderParameters.Items);
                        builder.AddAttribute(17, "IsCustomFinder", CustomFinderParameters.IsCustomFinder);
                    }
                    else
                    {
                        //New Code(07082024)
                        builder.AddAttribute(3, "IsFinder", true);
                        builder.AddAttribute(4, "IsMultiSelect", IsMultiSelectFinder);
                        builder.AddAttribute(5, "IsCustomFinder", IsCustomFinder);
                    }

                    builder.CloseComponent();
                };
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        public void OnFinderDataChanged(IFinderData selectedData)
        {
            // Do something with the new data
            SelectedData = selectedData;
            HidePage = true;
            SelectedDataChanged(this.SelectedData);
        }
        private void SelectedDataChanged(IFinderData newData)
        {
            OnSelectedDataChanged?.Invoke(newData);
        }

        public void OnFinderSelectedRowsChanged(List<IFinderData> SelectedRows)
        {
            // Do something with the new data
            SelectedItems = SelectedRows;
            //HidePage = true;
            OnSelectedRowsChanged?.Invoke(this.SelectedItems);
        }

    }
}
