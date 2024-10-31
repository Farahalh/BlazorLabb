using BlazorLabb.Services;

namespace BlazorLabb.Components.Pages
{
    public partial class UsersPage
    {
        private List<UserService.User>? users;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            users = await UserService.SerializeUserAsync();
            users = await UserService.DeserializeUserAsync();
        }
    }
}