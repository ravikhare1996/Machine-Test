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
    [XSProgram(Module= "MachineTest", Program= "User_Master")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class User_MasterBasePage
    {
        private bool success;
        private XSTextBox<string?>? txtPassword;
        private XSTextBox<string?>? txtUserName;
        private XSDropdown<FinderData>? ddlLevel;
        private FinderData? _User_TypeValue;
        private XSFinder<FinderData>? fndClient;
        private FinderData? _ClientValue;
        private XSTextBox<string>? XpertNavigator;
        private XSFileUploadOpen<IBrowserFile>? UploadButtonBase;
        private IXSUploadedFile? _UploadedPanCard;
        private XSTextBox<string?>? txtEmail;
        private XSTextBox<string?>? txtPhone;

        [Inject]
        protected IUser_MasterManager Manager { get; set; }

        [Parameter]
        public bool ReadOnly { get; set; }

        [Parameter]
        public EditContext Context { get; set; }

        [Parameter]
        public clsUser_MasterVM Model { get; set; } = new clsUser_MasterVM();

        protected IEnumerable<FinderData>? User_TypeList { get; set; }

        private FinderData? User_TypeValue
        {
            get { return _User_TypeValue; }
            set { 
            if (value == null)
            {
              value = User_TypeList.FirstOrDefault(d => d.IsDefault == true);
            }
            _User_TypeValue = value;
            Model.User_Type = value?.Code;
             }
        }

        protected IEnumerable<FinderData>? ClientList { get; set; }

        private FinderData? ClientValue
        {
            get { return _ClientValue; }
            set { 
            if (value == null)
            {
              value = ClientList.FirstOrDefault(d => d.IsDefault == true);
            }
            _ClientValue = value;
            Model.Client = value?.Code;
             }
        }

        protected async override Task  OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            //get all Lists
            User_TypeList = await Manager.GetUser_TypeList(Model);
            if (CrudType==XpertCrudTypes.Create )
            {
              Model = new clsUser_MasterVM();
            }
            else
            {
              Model = await Manager.GetDataAsync(CurrentID);
            User_TypeValue = new FinderData() { Code = Model.User_Type, Name = "NA" };
            ClientValue = new FinderData() { Code = Model.Client, Name = "NA" };
            if (Model.PanCard!=null)
            {
            //_UploadedPanCard = new XSUploadedFile() { File_Path=Model.PanCard_FilePath, File_Name = Model.PanCard_FileName ,Content_Type = Model.PanCard_ContentType, File_Content = Model.PanCard };
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
            Model=await Manager.SaveAsync(Model);
            success = true;
            StateHasChanged();
            _snackBar.Add("Record Added.", MudBlazor.Severity.Success);
            UriHelper.NavigateTo("/MachineTest/Setup/User_MasterEdit/" + Model.ID);
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
            UriHelper.NavigateTo("/MachineTest/Setup/User_Master/");
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

        private async Task<IEnumerable<FinderData>>  SearchUser_Type(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
            {
            return User_TypeList;
            }
            return User_TypeList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayUser_Type(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Code + "-" + CurrentData.Name; 
        }

        private async Task<IEnumerable<FinderData>>  SearchClient(string value)
        {
            await Task.Delay(5);
            ClientList = await Manager.GetClientList(Model);
            ClientValue= ClientList.FirstOrDefault(val =>val.Code==Model.Client);
            if (string.IsNullOrEmpty(value))
            {
            return ClientList;
            }
            return ClientList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayClient(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Code + "-" + CurrentData.Name; 
        }

        [XSCodeType(Type = XSCodeType.Custom)]
        private async Task UpdateUser_TypeList()
        {
            if (ddlLevel != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Code");
                dt.Columns.Add("Name");
                DataRow dr;
                //add Level 1
                dr = dt.NewRow();
                dr["Code"] = "Level 1";
                dr["Name"] = "Level 1";
                //add Level 2
                dr = dt.NewRow();
                dr["Code"] = "Level 2";
                dr["Name"] = "Level 2";
                //add Level 3
                dr = dt.NewRow();
                dr["Code"] = "Level 3";
                dr["Name"] = "Level 3";
                //add Level 4
                dr = dt.NewRow();
                dr["Code"] = "Level 4";
                dr["Name"] = "Level 4";
            }
        }


        private async Task  OnPanCardChanged(InputFileChangeEventArgs e)
        {
            try
            {
            var selectedFile = e.GetMultipleFiles()?.FirstOrDefault();
            if (selectedFile == null)
            {
              return;
            }
            if (selectedFile?.Size > UploadButtonBase.MaxSize * 1024 * 1024 || selectedFile?.Size < UploadButtonBase.MinSize * 1024 * 1024)
            {
              _snackBar.Add($"File {selectedFile.Name} is not within the allowed size limits.("+UploadButtonBase.MinSize + ","+UploadButtonBase.MaxSize + ")", Severity.Error);
              return;
            }
            using var stream = selectedFile?.OpenReadStream();
            using var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream);
            //map data to model properties
            //File_Path will be set if file is saved in disk instead of database at server side logic 
            Model.PanCard_FilePath = null;
            //set Fiel_Name
            Model.PanCard_FileName = selectedFile.Name;
            //set content
            Model.PanCard = memoryStream.ToArray();
            //set content_Type
            Model.PanCard_ContentType = selectedFile.ContentType;
            }
            catch (Exception ex)
            {
            Console.WriteLine($"An error occurred while browsing the file: {ex.Message}");
            throw;
            }
        }

        private async Task  OnPanCardOpen(IXSUploadedFile? file)
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
