using Microsoft.AspNetCore.Components;

namespace BlazorPWA.Client.Pages.Admin
{
    public partial class XSAccountManager
    {
        [Inject] IUserAccountManager userAccountManager { get; set; }
        bool _loaded = false;
        bool showError = false;
        bool showInfo = false;
        string message = string.Empty;
        bool isInAccountEditMode = false;
        UserAccountDto user = new UserAccountDto();


        protected override async Task OnInitializedAsync()
        {
            await userAccountManager.GetUserAccounts();
            _loaded = true;
        } //OnInitializedAsync


        private async Task AddUserAccount()
        {
            user = new UserAccountDto();
            isInAccountEditMode = true;
        } //AddUserAccount


        private async Task EditUser(string userId)
        {
            var result = await userAccountManager.GetUserDetails(userId);
            if (result.Success)
                user = result.Data;

            isInAccountEditMode = true;
        } //EditUser


        private void CancelEdit()
        {
            user = new UserAccountDto();
            isInAccountEditMode = false;
        } //CancelEdit


        private async Task UpdateUserAccount()
        {
            showError = false;
            showInfo = false;
            message = string.Empty;

            if (!string.IsNullOrEmpty(user.UserId))
            {
                var result = await userAccountManager.UpdateUserAccount(user);

                if (result.Success)
                {
                    showInfo = true;
                    message = result.Message;
                }
                else
                {
                    showError = true;
                    message = result.Message;
                }
            }
            else
            {
                var result = await userAccountManager.CreateNewUserAccount(user);
                if (result.Success)
                {
                    showInfo = true;
                    message = result.Message;
                }
                else
                {
                    showError = true;
                    message = result.Message;
                }
            }

            user = new UserAccountDto();
            await userAccountManager.GetUserAccounts();
            isInAccountEditMode = false;
        } //UpdateUserAccount


        private async Task DeleteUser(string userId)
        {
            var result = await userAccountManager.DeleteUserAccount(userId);
            if (result.Success)
            {
                showInfo = true;
                message = result.Message;
                await userAccountManager.GetUserAccounts();
            }
            else
            {
                showError = true;
                message = result.Message;
            }
        } //DeleteUser







    }
}
