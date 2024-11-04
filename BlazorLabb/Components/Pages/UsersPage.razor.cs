using BlazorLabb.Model;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

/// <summary>
/// The `UsersPage` component loads and displays a list of registered users.
/// Initializes `_registeredUsers` with data loaded asynchronously from a JSON file using `UserData`.
/// Adds a delay to simulate data loading.
/// This component provides a user interface to view registered users on initialization.
/// </summary>

namespace BlazorLabb.Components.Pages
{
    public partial class UsersPage
    {
        private List<User> _registeredUsers = new List<User>();
        private readonly UserData _userData = new UserData();

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            _registeredUsers = await _userData.GetUsersAsync();
        }
    }
}
