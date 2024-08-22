using BlazorPWA.Shared.Managers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using XpertStudio.Common.Data;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Functions;
using System.Data;
using BlazorPWA.Shared.VMs;
using Microsoft.JSInterop;

namespace BlazorPWA.Client.Pages.MachineTest.Transaction
{
    [XSProgram(Module= "MachineTest", Program= "PurchaseOrder")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class PurchaseOrderBasePage
    {
        private bool success;
        private XSTextBox<string?>? txtRemarks;
        private XSTextBox<string?>? txtComments;
        private XSFinder<FinderData?>? txtVendor;
        private FinderData? _POVCodeValue;
        private XSTextBox<string?>? txtPOCode;
        private XSDatePicker? dtpPODate;
        private XSNumberBox<decimal?>? txtDocAmt;
        private XSNumberBox<decimal?>? txtPOAmt;
        private XSImage<IBrowserFile?>? pcbPhoto;
        private IXSUploadedFile? _UploadedfilePhoto;
        private string _ImageSrcfilePhoto = string.Empty;
        private XSRadioGroup<string?>? xpertRadioButton1;
        private XSMultiSelectFinder<FinderData?>? XpertMultiSelctFinder;
        private List<FinderData>? _PO_ItemListValue;
        private XSDataGrid<clsPO_ItemVM>? gv1;

        [Inject]
        protected IPurchaseOrderManager Manager { get; set; }

        [Parameter]
        public bool ReadOnly { get; set; }

        [Parameter]
        public EditContext Context { get; set; }

        [Parameter]
        public clsPurchaseOrderVM Model { get; set; } = new clsPurchaseOrderVM();

        [Inject]
        protected IVendorMasterManager POVCodeManager { get; set; }

        protected IEnumerable<FinderData>? POVCodeList { get; set; }

        private FinderData? POVCodeValue
        {
            get { return _POVCodeValue; }
            set { 
            if (value == null)
            {
            _POVCodeValue = POVCodeList?.FirstOrDefault(d => d.IsDefault == true);
            }
            else
            {
            _POVCodeValue = value;
            }
            Model.POVCode = _POVCodeValue?.Code;
             }
        }

        private bool Validate_Document_Amount
        {
            get { return Model.POTotAmt==Model.Document_Amount? true : false; }
        }

        protected IEnumerable<FinderData>? PO_ItemListList { get; set; }

        private List<FinderData>? PO_ItemListValue
        {
            get { return _PO_ItemListValue; }
            set { 
            _PO_ItemListValue = value;
             }
        }

        private bool Visible_gbxDetails
        {
            get { return Model.Document_Amount>0? true : false; }
        }

        protected async override Task  OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            //get all Lists
            if (CrudType==XpertCrudTypes.Create )
            {
              Model = new clsPurchaseOrderVM();
            }
            else
            {
              Model = await Manager.GetDataAsync(CurrentID);
            if (Model.POVCode!=null)
            {
            var POVCodeData =await POVCodeManager.GetDataAsync(Model.POVCode);
            if (POVCodeData!=null)
            POVCodeValue = new FinderData() { Code = POVCodeData.ID, Name = POVCodeData.Description };
            POVCodeData=null;
            }
            if (Model.filePhoto!=null)
            {
            _UploadedfilePhoto = new XSUploadedFile(name:Model.filePhoto_FileName,contentType:Model.filePhoto_ContentType,data:Model.filePhoto) { File_Path=Model.filePhoto_FilePath };
            _ImageSrcfilePhoto = XpertCommonFunctions.GetImageByByteArr(Model.filePhoto);
            }
            if (Model.PO_ItemList!=null)
            {
             if(PO_ItemListValue==null)
             {
               PO_ItemListValue = new List<FinderData>();
             }
            PO_ItemListValue.AddRange(Model.PO_ItemList.Cast<IXSFinderData>().Select(item => new FinderData { Code = item.Code, Name = item.Name }));
            }
            }
            Context = new EditContext(Model);
            if (ReadOnly==false)
            {
              ReadOnly = CrudType == XpertCrudTypes.View ? true : false;
            }
            StateHasChanged();
        }

        private async Task  OnCreate(EditContext context)
        {
            //Validate Document_Amount
            if (!Validate_Document_Amount)
            {
            _snackBar.Add("Document Amount(Document_Amount) is not valid!",Severity.Warning);
            return;
            }
            Model=await Manager.SaveAsync(Model);
            success = true;
            StateHasChanged();
            _snackBar.Add("Record Added.", MudBlazor.Severity.Success);
            UriHelper.NavigateTo("/MachineTest/Transaction/PurchaseOrderEdit/" + Model.ID);
        }

        private async Task  OnEdit(EditContext context)
        {
            //Validate Document_Amount
            if (!Validate_Document_Amount)
            {
            _snackBar.Add("Document Amount(Document_Amount) is not valid!",Severity.Warning);
            return;
            }
            Model=await Manager.EditAsync(Model);
            success = true;
            StateHasChanged();
            _snackBar.Add("Record Updated.", MudBlazor.Severity.Success);
        }

        private async Task  OnDelete(EditContext context)
        {
            await Manager.DeleteAsync(Model.ID);
            success = true;
            StateHasChanged();
            _snackBar.Add("Record Deleted.", MudBlazor.Severity.Success);
            UriHelper.NavigateTo("/MachineTest/Transaction/PurchaseOrder/");
        }

        protected void  NavigateToIndex()
        {
            if (PageHistoryState.GetGoBackPage()!=null)
            {
              UriHelper.NavigateTo(PageHistoryState.GetGoBackPage());
            }
        }

        private async void  OnValidSubmit(EditContext context)
        {
            if (CrudType==XpertCrudTypes.Create)
            {
            await OnCreate(context);
            }
            else if (CrudType==XpertCrudTypes.Edit)
            {
              await OnEdit(context);
            }
            else if (CrudType == XpertCrudTypes.Delete)
            {
              await OnDelete(context);
            }
            else if (CrudType==XpertCrudTypes.View)
            {
              Model=await  Manager.GetDataAsync(CurrentID);
            }
        }

        private async Task<IEnumerable<FinderData>>  SearchPOVCode(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
            {
            return POVCodeList;
            }
            return POVCodeList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayPOVCode(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Name; 
        }

        private async Task<string> getPOVCodeName(string? Code)
        {
            string? name= (string?)(await Manager.getSingleValue("select VName from TSPL_VENDOR_MASTER where VCode='" + Code + "'"));
            return name;
        }

        private async Task<IEnumerable<FinderData>>  SearchPO_ItemList(string value)
        {
            //await Task.Delay(5);
            PO_ItemListList = await Manager.GetPO_ItemListList(Model);
           // PO_ItemListValue= PO_ItemListList.FirstOrDefault(val =>val.Code==Model.PO_ItemList);
            if (string.IsNullOrEmpty(value))
            {
            return PO_ItemListList;
            }
            return PO_ItemListList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayPO_ItemList(FinderData CurrentData)
        {
            string strList=string.Empty;
            try
            {
             if(PO_ItemListValue == null)
             {
              return strList;
             }
             foreach (var item in PO_ItemListValue)
             {
              if (XpertCommonFunctions.myLen(strList) <= 0)
              {
                strList = strList + item.Code + "-" + item.Name;
              }
              else
              {
                strList = strList + "," + item.Code + "-" + item.Name;
              }
             }
            return strList;
            }
            catch (Exception)
            {
             throw;
            }
        }

        private void SetSelectedValuesPO_ItemList(EventArgs e)
        {
            try
            {
             if (XpertMultiSelctFinder?.SelectedValues == null)
             {
              return;
             }
            PO_ItemListValue = XpertMultiSelctFinder?.SelectedValues?.Cast<FinderData>().ToList();
             Model.PO_ItemList = new List<clsFinderItemsVM>();
             foreach (var item in PO_ItemListValue)
             {
               Model.PO_ItemList.Add(new clsFinderItemsVM() { ParentID = Model.ID, RowNo = PO_ItemListValue.ToList().IndexOf(item) + 1, Code = item.Code, Name = item.Name});
             }
            }
            catch (Exception)
            {
             throw;
            }
        }

        private async Task  OnfilePhotoChanged(InputFileChangeEventArgs e)
        {
            try
            {
            var selectedFile = e.GetMultipleFiles()?.FirstOrDefault();
            if (selectedFile == null)
            {
              return;
            }
            if (selectedFile?.Size > pcbPhoto.MaxSize * 1024 * 1024 || selectedFile?.Size < pcbPhoto.MinSize * 1024 * 1024)
            {
              _snackBar.Add($"File {selectedFile.Name} is not within the allowed size limits.("+pcbPhoto.MinSize + ","+pcbPhoto.MaxSize + ")", Severity.Error);
              return;
            }
            using var stream = selectedFile?.OpenReadStream();
            using var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream);
            //map data to model properties
            //File_Path will be set if file is saved in disk instead of database at server side logic 
            Model.filePhoto_FilePath = null;
            //set Fiel_Name
            Model.filePhoto_FileName = selectedFile.Name;
            //set content
            Model.filePhoto = memoryStream.ToArray();
            //set content_Type
            Model.filePhoto_ContentType = selectedFile.ContentType;
            _ImageSrcfilePhoto = XpertCommonFunctions.GetImageByByteArr(Model.filePhoto);
            }
            catch (Exception ex)
            {
            Console.WriteLine($"An error occurred while browsing the file: {ex.Message}");
            throw;
            }
        }

        private async Task  OnfilePhotoOpen(IXSUploadedFile? file)
        {
            try
            {
            if (file?.File_Content != null)
              {
                var fileData = file?.File_Content;
                await JSRuntime.InvokeVoidAsync("openFileFromBytes", Convert.ToBase64String(fileData), file.Content_Type);
              }
            }
            catch (Exception ex)
            {
            Console.WriteLine($"An error occurred while opening the file: {ex.Message}");
            throw;
            }
        }
[XSCodeType(Type = XSCodeType.Custom)]
        private async Task GetPOItemListFinder(EventArgs args)
        {
            try
            {
                await Task.Run(() =>
                {
                    if (XpertMultiSelctFinder == null)
                    {
                        return;
                    }
                    XpertMultiSelctFinder.CustomFinderParameters = new XSCustomFinderParameters() { ReportID = "POItemList", Query = "Select ICode, IName from tspl_item_Master", CodeColumn = "ICode", NameColumn = "IName", IsCustomFinder = true };
                });
            }
            catch (Exception ex)
            {
                this.MyMessageBoxShow("Purchase Order", ex.Message);
            }
        }
    }
}
