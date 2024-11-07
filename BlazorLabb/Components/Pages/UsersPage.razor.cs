using BlazorLabb.Model;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLabb.Components.Pages
{
    public partial class UsersPage
    {
        private List<User> _registeredUsers = new List<User>();
        private string searchTerm = "";
        private readonly UserDataAccess _defaultUserDataAccess = new UserDataAccess();

        [Parameter]
        public int TotalUsersToDisplay { get; set; } = 5;

        [Parameter]
        public IUserDataAccess UserDataAccess { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            await LoadUserDataAsync();
        }

        private async Task LoadUserDataAsync()
        {
            UserDataAccess ??= _defaultUserDataAccess;
            var allUsers = await UserDataAccess.GetUsersAsync();

            if (allUsers == null || !allUsers.Any())
            {
                Console.WriteLine("No users retrieved.");
                _registeredUsers = new List<User>();
            }
            else
            {
                _registeredUsers = allUsers.Take(TotalUsersToDisplay).ToList();
            }
        }

        private void DisplayAll()
        {
            _registeredUsers = _registeredUsers.GetUsers(TotalUsersToDisplay);
        }

        private void DisplaySome()
        {
            _registeredUsers = _registeredUsers.GetSomeUsers(0, TotalUsersToDisplay);
        }

        private void OrderByName()
        {
            _registeredUsers = _registeredUsers.GetUsersOrderedByName();
        }

        private void OrderedById()
        {
            _registeredUsers = _registeredUsers.GetUsersOrderedById(TotalUsersToDisplay);
        }

        private void FilterBySearch()
        {
            _registeredUsers = _registeredUsers.GetUsersBySearch(searchTerm);
        }
    }
}
