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
    [XSProgram(Module= "MachineTest", Program= "ItemMaster")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class ItemMasterBasePage
    {
        private bool success;
        private XSTextBox<string?>? txtUom;
        private XSTextBox<string?>? txtDescription;
        private XSTextBox<string?>? txtItemCode;
        private XSNumberBox<decimal?>? txtRate;

        [Inject]
        protected IItemMasterManager Manager { get; set; }

        [Parameter]
        public bool ReadOnly { get; set; }

        [Parameter]
        public EditContext Context { get; set; }

        [Parameter]
        public clsItemMasterVM Model { get; set; } = new clsItemMasterVM();

        protected async override Task  OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            //get all Lists
            if (CrudType==XpertCrudTypes.Create )
            {
              Model = new clsItemMasterVM();
            }
            else
            {
              Model = await Manager.GetDataAsync(CurrentID);
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
            UriHelper.NavigateTo("/MachineTest/Setup/ItemMasterEdit/" + Model.ID);
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
            UriHelper.NavigateTo("/MachineTest/Setup/ItemMaster/");
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
    }
}
