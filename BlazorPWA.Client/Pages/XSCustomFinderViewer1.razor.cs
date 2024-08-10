using MudBlazor.XS.Common;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpertStudio.Common.Attributes;
using XpertStudio.Common.Data;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Functions;
using XpertStudio.Common.Managers;

namespace BlazorPWA.Client.Pages
{
//#nullable enable
    [XSCodeType(Type = XSCodeType.Standard)]
    public partial class XSCustomFinderViewer1
    {
        private List<ICustomFinderData> _pagedData;
        private MudDataGrid<ICustomFinderData> _Grid;
        private int _totalItems;
        //private int _currentPage;
        private string searchString=string.Empty;
        private bool _loaded;

        [Inject]
        public IManager Manager { get; set; }
        //string ReportID, string strQry, string strSelectedColCode, string strWhrCls, string strCurrCode, string strOrderByColumns, bool isShowSelectForm, string strFormName = ""
        [Parameter]
        public string? ReportID { get; set; }

        [Parameter]
        public DataTable? dt { get; set; }

        [Parameter]
        public string? Query { get; set; }

        [Parameter]
        public string? CodeColumn { get; set; }

        [Parameter]
        public string? NameColumn { get; set; }

        [Parameter]
        public string? WhereClause { get; set; }

        [Parameter]
        public string? strCurrCode { get; set; }

        [Parameter]
        public string? strOrderByColumns { get; set; }

        [Parameter]
        public bool isShowSelectForm { get; set; }

        [Parameter]
        public string? strFormName { get; set; }

        [Parameter]
        public string? DateColumn { get; set; }

        //[Parameter]
        //public bool IsMultiSelect { get; set; }

        private List<string> columns { get; set; } = new List<string>();
        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _loaded = true;
        }

        private async Task<GridData<ICustomFinderData>> ServerReload(GridState<ICustomFinderData> state)
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
            return new GridData<ICustomFinderData> { TotalItems = _totalItems, Items = _pagedData };
        }

        private async Task LoadData(int pageNumber, int pageSize, GridState<ICustomFinderData> state)
        {
            try
            {
                await Task.Run(async () =>
                {
                    //Get datatable by executing the sql query
                    System.Data.DataTable? dataTable=null;
                    if (XpertCommonFunctions.myLen(CodeColumn) <= 0)
                    {
                        CodeColumn = "Code";
                    }
                    if (XpertCommonFunctions.myLen(NameColumn) <= 0)
                    {
                        CodeColumn = "Description";
                    }
                    if (dt!=null)
                    {
                        dataTable = dt;
                    }
                    else
                    {
                        string result = string.Empty;
                        string empty = string.Empty;
                        DateTime sERVERDATE = await Manager.GetServerDate(); //XpertCommonFunctions.GETSERVERDATE();
                        DateTime fromDate = sERVERDATE.AddMonths(-1);
                        
                        if (XpertCommonFunctions.myLen(ReportID) <= 0)
                        {
                            throw new Exception("ReportId parameter can not be empty in XSCustomFinderViewer1!");
                        }
                        if (XpertCommonFunctions.myLen(Query) <= 0)
                        {
                            throw new Exception("Query parameter can not be empty in XSCustomFinderViewer1!");
                        }

                        string strQuery = Query + " Where 2=2 ";
                        if (XpertCommonFunctions.myLen(WhereClause) > 0)
                        {
                            strQuery = strQuery + " and " + WhereClause;
                        }
                        if (SearchString != null && SearchString.Length > 0)
                        {
                            strQuery = strQuery + "and (" + CodeColumn + " like '%" + SearchString + "%' or " + NameColumn + " like '%" + SearchString + "%')";
                        }
                        string[] orderings = null;
                        if (XpertCommonFunctions.myLen(strOrderByColumns) > 0)
                        {
                            orderings = strOrderByColumns.Split(",");
                        }
                        if (orderings == null || orderings?.Count() <= 0)
                        {
                            orderings = new string[] { CodeColumn };
                        }
                        //get total count
                        var strcount = "select count(*) from (" + strQuery + ") as t1";
                        _totalItems = (int)XpertCommonFunctions.myCdbl((await Manager.getSingleValue(strcount)));
                        var request = new PagedRequest { PageNumber = (pageNumber) * state.PageSize, PageSize = pageSize, SearchString = searchString, Orderby = orderings };
                        dataTable = await Manager.GetDataTablePaginated(strQuery, request);
                    }

                    _pagedData = new List<ICustomFinderData>();
                    var row = new CustomFinderData();
                    //List<string> columns = new List<string>();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        if (!(column.ColumnName == CodeColumn || column.ColumnName == NameColumn))
                        {
                            columns.Add(column.ColumnName);
                        }
                    }
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        row = new CustomFinderData();
                        row.Code = XpertCommonFunctions.myCstr(dataRow[CodeColumn]);
                        row.Name = XpertCommonFunctions.myCstr(dataRow[NameColumn]);
                        row.Description = XpertCommonFunctions.myCstr(dataRow[NameColumn]);

                        //fill oter columns
                        foreach (var col in columns)
                        {
                            string column = "Description" + (columns.IndexOf(col) + 2).ToString();
                            row.GetType().GetProperty(column)?.SetValue(row, dataRow[col].ToString());
                        }
                        _pagedData.Add(row);
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to Load Data: {ex.Message}");
            }
        }

        private void OnSearch(string text)
        {
            SearchString = text;
            _Grid.ReloadServerData();
        }

        private async Task ExportToExcel()
        {
            try
            {
                if (_pagedData != null)
                {
                    //var fileData = _pagedData;
                    var fileName = "" + ReportID + ".xlsx";
                    await JSRuntime.InvokeVoidAsync("saveAsFile", fileName, _pagedData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to export data: {ex.Message}");
            }
        }

        
        private void RowClicked(ICustomFinderData item)
        {
            SelectedRowChanged(item);
        }
        void SelectedItemsChanged(HashSet<ICustomFinderData> items)
        {
            SelectedRowsChanged(items.ToList<IFinderData>());
        }
        private static List<T> ConvertDataTableToList<T>(DataTable dt) where T : new()
        {
            List<T> list = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T obj = new T();
                foreach (DataColumn col in dt.Columns)
                {
                    var prop = obj.GetType().GetProperty(col.ColumnName);
                    if (prop != null && row[col] != DBNull.Value)
                        prop.SetValue(obj, row[col]);
                }
                list.Add(obj);
            }
            return list;
        }
        private void SetSelectedItems(List<IFinderData>? selectedItems)
        {
            try
            {
                if (selectedItems == null)
                {
                    return;
                }
                HashSet<ICustomFinderData> items = new HashSet<ICustomFinderData>();
                foreach (var finderData in selectedItems)
                {
                    var selItem = _pagedData?.FirstOrDefault(itm => finderData.Code == itm.Code);
                    if (selItem != null)
                        items.Add(selItem);
                }
                _Grid.Selection = items;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
