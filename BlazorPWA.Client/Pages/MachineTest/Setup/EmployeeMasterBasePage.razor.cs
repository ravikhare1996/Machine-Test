using BlazorPWA.Shared.Managers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using XpertStudio.Common.Data;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Functions;
using System.Data;
using BlazorPWA.Shared.VMs;
using Microsoft.JSInterop;

namespace BlazorPWA.Client.Pages.MachineTest.Setup
{
    [XSProgram(Module= "MachineTest", Program= "EmployeeMaster")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class EmployeeMasterBasePage
    {
        private bool success;
        private XSTextBox<string?>? txtContactNumber;
        private XSTextBox<string?>? txtEmailID;
        private XSTextBox<string?>? txtMothersName;
        private XSTextBox<string?>? txtFathersName;
        private XSTextBox<string?>? txtEmployeeName;
        private XSTextBox<string?>? dfndEmployeeCode;
        private XSDropdown<FinderData?>? dpPaymentType;
        private FinderData? _PAYMENT_TYPEValue;
        private XSFinder<FinderData?>? fndDesignation;
        private FinderData? _DESIGNATIONValue;
        private XSNumberBox<decimal?>? xpertNumberBox5;
        private XSTextBox<string?>? txtAccountNumber;
        private XSTextBox<string?>? txtAccountPhoneNumber;
        private XSTextBox<string?>? txtAccountEmail;
        private XSTextBox<string?>? txtIFSCCode;
        private XSTextBox<string?>? txtBankName;
        private XSFileUploadOpen<IBrowserFile?>? fileBankProof;
        private IXSUploadedFile? _UploadedBankProof;
        private XSTextBox<string?>? txtAdhaarNumber;
        private XSTextBox<string?>? txtAdhaarPhoneNumber;
        private XSTextBox<string?>? txtAdhaarEmail;
        private XSTextBox<string?>? txtAdhaarAddress;
        private XSFileUploadOpen<IBrowserFile?>? fileAdhaarProof;
        private IXSUploadedFile? _UploadedAdhaarProof;
        private XSTextBox<string?>? txtPanNumber;
        private XSDropdown<FinderData?>? dpCategory;
        private FinderData? _Category_TypeValue;
        private XSDatePicker? dtpDateofJoining;
        private XSDatePicker? dtpDateofBirth;
        private XSImage<IBrowserFile?>? pcbPhoto;
        private IXSUploadedFile? _UploadedEmp_Photo;
        private string _ImageSrcEmp_Photo = string.Empty;
        private XSTextBox<string?>? txtLocalPINCODE;
        private XSTextBox<string?>? txtLocalRefPhoneNo;
        private XSTextBox<string?>? txtLocalAddress;
        private XSTextBox<string?>? txtLocalRefPerson;
        private XSTextBox<string?>? txtPermanentRefPhoneNo;
        private XSTextBox<string?>? txtPermanentRefPerson;
        private XSTextBox<string?>? txtParmanentPINCODE;
        private XSTextBox<string?>? txtPermanentAddress;
        private XSTextBox<string?>? txtPFNumber;
        private XSTextBox<string?>? txtPFPhoneNumber;
        private XSDropdown<FinderData?>? txtPhoneNumberType;
        private FinderData? _PF_Phone_Number_TypeValue;
        private XSTextBox<string?>? txtGSTPhoneNumber;
        private XSTextBox<string?>? txtGSTEmail;
        private XSTextBox<string?>? txtGSTAddress;
        private XSTextBox<string?>? txtGSTNumber;
        private XSTextBox<string?>? txtTDSNumber;
        private XSTextBox<string?>? txtTDSPhoneNumber;
        private XSTextBox<string?>? txtTDSEmail;
        private XSTextBox<string?>? txtTDSAddress;
        private XSTextBox<string?>? txtROCNumber;
        private XSTextBox<string?>? txtROCPhoneNumber;
        private XSTextBox<string?>? txtROCEmail;
        private XSTextBox<string?>? txtROCAddress;
        private XSTextBox<string?>? txtESINumber;
        private XSTextBox<string?>? txtESIPhoneNumber;
        private XSDropdown<FinderData?>? dpESIPhoneNumberType;
        private FinderData? _ESI_Phone_Number_TypeValue;
        private XSTextBox<string?>? txtCompRefPhoneNo;
        private XSTextBox<string?>? txtCompPINCODE;
        private XSTextBox<string?>? txtCompCode;
        private XSTextBox<string?>? txtCompRefPerson;
        private XSTextBox<string?>? txtCOMPANYADDRESS;

        [Inject]
        protected IEmployeeMasterManager Manager { get; set; }

        [Parameter]
        public bool ReadOnly { get; set; }

        [Parameter]
        public EditContext Context { get; set; }

        [Parameter]
        public clsEmployeeVM Model { get; set; } = new clsEmployeeVM();

        protected IEnumerable<FinderData>? PAYMENT_TYPEList { get; set; }

        private FinderData? PAYMENT_TYPEValue
        {
            get { return _PAYMENT_TYPEValue; }
            set { 
            if (value == null)
            {
              value = PAYMENT_TYPEList.FirstOrDefault(d => d.IsDefault == true);
            }
            _PAYMENT_TYPEValue = value;
            Model.PAYMENT_TYPE = value?.Code;
             }
        }

        protected IEnumerable<FinderData>? DESIGNATIONList { get; set; }

        private FinderData? DESIGNATIONValue
        {
            get { return _DESIGNATIONValue; }
            set { 
            if (value == null)
            {
              value = DESIGNATIONList.FirstOrDefault(d => d.IsDefault == true);
            }
            _DESIGNATIONValue = value;
            Model.DESIGNATION = value?.Code;
             }
        }

        protected IEnumerable<FinderData>? Category_TypeList { get; set; }

        private FinderData? Category_TypeValue
        {
            get { return _Category_TypeValue; }
            set { 
            if (value == null)
            {
              value = Category_TypeList.FirstOrDefault(d => d.IsDefault == true);
            }
            _Category_TypeValue = value;
            Model.Category_Type = value?.Code;
             }
        }

        protected IEnumerable<FinderData>? PF_Phone_Number_TypeList { get; set; }

        private FinderData? PF_Phone_Number_TypeValue
        {
            get { return _PF_Phone_Number_TypeValue; }
            set { 
            if (value == null)
            {
              value = PF_Phone_Number_TypeList.FirstOrDefault(d => d.IsDefault == true);
            }
            _PF_Phone_Number_TypeValue = value;
            Model.PF_Phone_Number_Type = value?.Code;
             }
        }

        protected IEnumerable<FinderData>? ESI_Phone_Number_TypeList { get; set; }

        private FinderData? ESI_Phone_Number_TypeValue
        {
            get { return _ESI_Phone_Number_TypeValue; }
            set { 
            if (value == null)
            {
              value = ESI_Phone_Number_TypeList.FirstOrDefault(d => d.IsDefault == true);
            }
            _ESI_Phone_Number_TypeValue = value;
            Model.ESI_Phone_Number_Type = value?.Code;
             }
        }

        protected async override Task  OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            //get all Lists
            PAYMENT_TYPEList = await Manager.GetPAYMENT_TYPEList(Model);
            Category_TypeList = await Manager.GetCategory_TypeList(Model);
            PF_Phone_Number_TypeList = await Manager.GetPF_Phone_Number_TypeList(Model);
            ESI_Phone_Number_TypeList = await Manager.GetESI_Phone_Number_TypeList(Model);
            if (CrudType==XpertCrudTypes.Create )
            {
              Model = new clsEmployeeVM();
            }
            else
            {
              Model = await Manager.GetDataAsync(CurrentID);
            PAYMENT_TYPEValue = new FinderData() { Code = Model.PAYMENT_TYPE, Name = "NA" };
            DESIGNATIONValue = new FinderData() { Code = Model.DESIGNATION, Name = "NA" };
            if (Model.BankProof!=null)
            {
            _UploadedBankProof = new XSUploadedFile(name:Model.BankProof_FileName,contentType:Model.BankProof_ContentType,data:Model.BankProof) { File_Path=Model.BankProof_FilePath };
            }
            if (Model.AdhaarProof!=null)
            {
            _UploadedAdhaarProof = new XSUploadedFile(name:Model.AdhaarProof_FileName,contentType:Model.AdhaarProof_ContentType,data:Model.AdhaarProof) { File_Path=Model.AdhaarProof_FilePath };
            }
            Category_TypeValue = new FinderData() { Code = Model.Category_Type, Name = "NA" };
            if (Model.Emp_Photo!=null)
            {
            _UploadedEmp_Photo = new XSUploadedFile(name:Model.Emp_Photo_FileName,contentType:Model.Emp_Photo_ContentType,data:Model.Emp_Photo) { File_Path=Model.Emp_Photo_FilePath };
            _ImageSrcEmp_Photo = XpertCommonFunctions.GetImageByByteArr(Model.Emp_Photo);
            }
            PF_Phone_Number_TypeValue = new FinderData() { Code = Model.PF_Phone_Number_Type, Name = "NA" };
            ESI_Phone_Number_TypeValue = new FinderData() { Code = Model.ESI_Phone_Number_Type, Name = "NA" };
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
            Model=await Manager.SaveAsync(Model);
            success = true;
            StateHasChanged();
            _snackBar.Add("Record Added.", MudBlazor.Severity.Success);
            UriHelper.NavigateTo("/MachineTest/Setup/EmployeeMasterEdit/" + Model.ID);
        }

        private async Task  OnEdit(EditContext context)
        {
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
            UriHelper.NavigateTo("/MachineTest/Setup/EmployeeMaster/");
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

        private async Task<IEnumerable<FinderData>>  SearchPAYMENT_TYPE(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
            {
            return PAYMENT_TYPEList;
            }
            return PAYMENT_TYPEList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayPAYMENT_TYPE(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Code + "-" + CurrentData.Name; 
        }

        private async Task<IEnumerable<FinderData>>  SearchDESIGNATION(string value)
        {
            await Task.Delay(5);
            DESIGNATIONList = await Manager.GetDESIGNATIONList(Model);
            DESIGNATIONValue= DESIGNATIONList.FirstOrDefault(val =>val.Code==Model.DESIGNATION);
            if (string.IsNullOrEmpty(value))
            {
            return DESIGNATIONList;
            }
            return DESIGNATIONList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayDESIGNATION(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Code + "-" + CurrentData.Name; 
        }

        private async Task<IEnumerable<FinderData>>  SearchCategory_Type(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
            {
            return Category_TypeList;
            }
            return Category_TypeList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayCategory_Type(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Code + "-" + CurrentData.Name; 
        }

        private async Task<IEnumerable<FinderData>>  SearchPF_Phone_Number_Type(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
            {
            return PF_Phone_Number_TypeList;
            }
            return PF_Phone_Number_TypeList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayPF_Phone_Number_Type(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Code + "-" + CurrentData.Name; 
        }

        private async Task<IEnumerable<FinderData>>  SearchESI_Phone_Number_Type(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
            {
            return ESI_Phone_Number_TypeList;
            }
            return ESI_Phone_Number_TypeList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayESI_Phone_Number_Type(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Code + "-" + CurrentData.Name; 
        }
[XSCodeType(Type = XSCodeType.Custom)]
        private async Task UpdatePAYMENT_TYPEList()
        {
            if (dpPaymentType != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Code");
                dt.Columns.Add("Name");
                DataRow dr;
                //add Daily
                dr = dt.NewRow();
                dr["Code"] = "Daily";
                dr["Name"] = "Daily";
                //add Weekly
                dr = dt.NewRow();
                dr["Code"] = "Weekly";
                dr["Name"] = "Weekly";
                //add Monthly
                dr = dt.NewRow();
                dr["Code"] = "Monthly";
                dr["Name"] = "Monthly";
            }
        }
[XSCodeType(Type = XSCodeType.Custom)]
        private async Task UpdateCategory_TypeList()
        {
            if (dpCategory != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Code");
                dt.Columns.Add("Name");
                DataRow dr;
                //add Employee
                dr = dt.NewRow();
                dr["Code"] = "Employee";
                dr["Name"] = "Employee";
                //add Individual
                dr = dt.NewRow();
                dr["Code"] = "Individual";
                dr["Name"] = "Individual";
            }
        }
[XSCodeType(Type = XSCodeType.Custom)]
        private async Task UpdatePF_Phone_Number_TypeList()
        {
            if (txtPhoneNumberType != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Code");
                dt.Columns.Add("Name");
                DataRow dr;
                //add Official
                dr = dt.NewRow();
                dr["Code"] = "Official";
                dr["Name"] = "Official";
                //add Personal
                dr = dt.NewRow();
                dr["Code"] = "Personal";
                dr["Name"] = "Personal";
            }
        }
[XSCodeType(Type = XSCodeType.Custom)]
        private async Task UpdateESI_Phone_Number_TypeList()
        {
            if (dpESIPhoneNumberType != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Code");
                dt.Columns.Add("Name");
                DataRow dr;
                //add Official
                dr = dt.NewRow();
                dr["Code"] = "Official";
                dr["Name"] = "Official";
                //add Personal
                dr = dt.NewRow();
                dr["Code"] = "Personal";
                dr["Name"] = "Personal";
            }
        }

        private async Task  OnBankProofChanged(InputFileChangeEventArgs e)
        {
            try
            {
            var selectedFile = e.GetMultipleFiles()?.FirstOrDefault();
            if (selectedFile == null)
            {
              return;
            }
            if (selectedFile?.Size > fileBankProof.MaxSize * 1024 * 1024 || selectedFile?.Size < fileBankProof.MinSize * 1024 * 1024)
            {
              _snackBar.Add($"File {selectedFile.Name} is not within the allowed size limits.("+fileBankProof.MinSize + ","+fileBankProof.MaxSize + ")", Severity.Error);
              return;
            }
            using var stream = selectedFile?.OpenReadStream();
            using var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream);
            //map data to model properties
            //File_Path will be set if file is saved in disk instead of database at server side logic 
            Model.BankProof_FilePath = null;
            //set Fiel_Name
            Model.BankProof_FileName = selectedFile.Name;
            //set content
            Model.BankProof = memoryStream.ToArray();
            //set content_Type
            Model.BankProof_ContentType = selectedFile.ContentType;
            }
            catch (Exception ex)
            {
            Console.WriteLine($"An error occurred while browsing the file: {ex.Message}");
            throw;
            }
        }

        private async Task  OnBankProofOpen(IXSUploadedFile? file)
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

        private async Task  OnAdhaarProofChanged(InputFileChangeEventArgs e)
        {
            try
            {
            var selectedFile = e.GetMultipleFiles()?.FirstOrDefault();
            if (selectedFile == null)
            {
              return;
            }
            if (selectedFile?.Size > fileAdhaarProof.MaxSize * 1024 * 1024 || selectedFile?.Size < fileAdhaarProof.MinSize * 1024 * 1024)
            {
              _snackBar.Add($"File {selectedFile.Name} is not within the allowed size limits.("+fileAdhaarProof.MinSize + ","+fileAdhaarProof.MaxSize + ")", Severity.Error);
              return;
            }
            using var stream = selectedFile?.OpenReadStream();
            using var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream);
            //map data to model properties
            //File_Path will be set if file is saved in disk instead of database at server side logic 
            Model.AdhaarProof_FilePath = null;
            //set Fiel_Name
            Model.AdhaarProof_FileName = selectedFile.Name;
            //set content
            Model.AdhaarProof = memoryStream.ToArray();
            //set content_Type
            Model.AdhaarProof_ContentType = selectedFile.ContentType;
            }
            catch (Exception ex)
            {
            Console.WriteLine($"An error occurred while browsing the file: {ex.Message}");
            throw;
            }
        }

        private async Task  OnAdhaarProofOpen(IXSUploadedFile? file)
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

        private async Task  OnEmp_PhotoChanged(InputFileChangeEventArgs e)
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
            Model.Emp_Photo_FilePath = null;
            //set Fiel_Name
            Model.Emp_Photo_FileName = selectedFile.Name;
            //set content
            Model.Emp_Photo = memoryStream.ToArray();
            //set content_Type
            Model.Emp_Photo_ContentType = selectedFile.ContentType;
            _ImageSrcEmp_Photo = XpertCommonFunctions.GetImageByByteArr(Model.Emp_Photo);
            }
            catch (Exception ex)
            {
            Console.WriteLine($"An error occurred while browsing the file: {ex.Message}");
            throw;
            }
        }

        private async Task  OnEmp_PhotoOpen(IXSUploadedFile? file)
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
    }
}
