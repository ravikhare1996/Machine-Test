using BlazorPWA.Shared.Managers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using XpertStudio.Common.Data;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Functions;
using System.Data;
using BlazorPWA.Shared.VMs;
using Microsoft.JSInterop;
using BlazorPWA.Common.Enums;

namespace BlazorPWA.Client.Pages.MachineTest.Setup
{
    [XSProgram(Module= "MachineTest", Program= "Company_Master")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class Company_MasterBasePage
    {
        private bool success;
        private XSTextBox<string?>? txtLocationSegment;
        private XSTextBox<string?>? txtTelephone2;
        private XSTextBox<string?>? txtEmail;
        private XSTextBox<string?>? txtPinCode;
        private XSTextBox<string?>? txtTelephone1;
        private XSTextBox<string?>? txtCityCode;
        private XSTextBox<string?>? txtAdd3;
        private XSTextBox<string?>? txtAdd2;
        private XSTextBox<string?>? txtAdd1;
        private XSTextBox<string?>? txtDescription;
        private XSDropdown<FinderData?>? ddlCompanyType;
        private FinderData? _Company_TypeValue;
        private XSDropdown<clsBranchType?>? ddlBranchSelect;
        private XSFinder<FinderData?>? fndProduct;
        private FinderData? _ProductValue;
        private XSFinder<FinderData?>? fndState;
        private FinderData? _StateValue;
        private XSTextBox<string?>? fndCompanyCode;
        private XSNumberBox<decimal?>? txtNonAnalyzedWork;
        private XSTextBox<string?>? txtPassword;
        private XSTextBox<string?>? txtEmailIDFrom;
        private XSTextBox<string?>? txtPort;
        private XSTextBox<string?>? txtSMTPClient;

        [Inject]
        protected ICompany_MasterManager Manager { get; set; }

        [Parameter]
        public bool ReadOnly { get; set; }

        [Parameter]
        public EditContext Context { get; set; }

        [Parameter]
        public clsCompanyMasterVM Model { get; set; } = new clsCompanyMasterVM();

        protected IEnumerable<FinderData>? Company_TypeList { get; set; }

        private FinderData? Company_TypeValue
        {
            get { return _Company_TypeValue; }
            set { 
            if (value == null)
            {
              value = Company_TypeList.FirstOrDefault(d => d.IsDefault == true);
            }
            _Company_TypeValue = value;
            Model.Company_Type = value?.Code;
             }
        }

        protected IEnumerable<FinderData>? ProductList { get; set; }

        private FinderData? ProductValue
        {
            get { return _ProductValue; }
            set { 
            if (value == null)
            {
              value = ProductList.FirstOrDefault(d => d.IsDefault == true);
            }
            _ProductValue = value;
            Model.Product = value?.Code;
             }
        }

        protected IEnumerable<FinderData>? StateList { get; set; }

        private FinderData? StateValue
        {
            get { return _StateValue; }
            set { 
            if (value == null)
            {
              value = StateList.FirstOrDefault(d => d.IsDefault == true);
            }
            _StateValue = value;
            Model.State = value?.Code;
             }
        }

        protected async override Task  OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            //get all Lists
            Company_TypeList = await Manager.GetCompany_TypeList(Model);
            if (CrudType==XpertCrudTypes.Create )
            {
              Model = new clsCompanyMasterVM();
            }
            else
            {
              Model = await Manager.GetDataAsync(CurrentID);
            Company_TypeValue = new FinderData() { Code = Model.Company_Type, Name = "NA" };
            ProductValue = new FinderData() { Code = Model.Product, Name = "NA" };
            StateValue = new FinderData() { Code = Model.State, Name = "NA" };
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
            UriHelper.NavigateTo("/MachineTest/Setup/Company_MasterEdit/" + Model.ID);
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
            UriHelper.NavigateTo("/MachineTest/Setup/Company_Master/");
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

        private async Task<IEnumerable<FinderData>>  SearchCompany_Type(string value)
        {
            await Task.Delay(5);
            if (string.IsNullOrEmpty(value))
            {
            return Company_TypeList;
            }
            return Company_TypeList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayCompany_Type(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Code + "-" + CurrentData.Name; 
        }

        private async Task<IEnumerable<FinderData>>  SearchProduct(string value)
        {
            await Task.Delay(5);
            ProductList = await Manager.GetProductList(Model);
            ProductValue= ProductList.FirstOrDefault(val =>val.Code==Model.Product);
            if (string.IsNullOrEmpty(value))
            {
            return ProductList;
            }
            return ProductList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayProduct(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Code + "-" + CurrentData.Name; 
        }

        private async Task<IEnumerable<FinderData>>  SearchState(string value)
        {
            await Task.Delay(5);
            StateList = await Manager.GetStateList(Model);
            StateValue= StateList.FirstOrDefault(val =>val.Code==Model.State);
            if (string.IsNullOrEmpty(value))
            {
            return StateList;
            }
            return StateList.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase));
        }

        private string DisplayState(FinderData CurrentData)
        {
            if (CurrentData == null)
            {
            return string.Empty;
            }
            return CurrentData.Code + "-" + CurrentData.Name; 
        }

        [XSCodeType(Type= XSCodeType.Custom)]
        private async Task  UpdateCompany_TypeList()
        {
            if (ddlCompanyType!=null)
            {
            DataTable dt = new DataTable();
            dt.Columns.Add("Code");
            dt.Columns.Add("Name");
            DataRow dr;
            //add Internal
            dr = dt.NewRow();
            dr["Code"] = "Internal";
            dr["Name"] = "Internal";
            //add External
            dr = dt.NewRow();
            dr["Code"] = "External";
            dr["Name"] = "External";
            }
        }

    }
}
