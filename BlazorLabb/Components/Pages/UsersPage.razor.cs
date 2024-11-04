using BlazorLabb.Model;
using BlazorLabb.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Routing.Constraints;

/// <summary>
/// Represents the UsersPage component, responsible for displaying and managing a list of users 
/// within a Blazor application. This component retrieves user data from a JSON file upon 
/// initialization and allows adding new users to the list, dynamically updating the JSON file. 
/// The class uses the UserService to handle serialization and deserialization for persistent 
/// storage of user data in "UserData.json".
/// </summary>

namespace BlazorLabb.Components.Pages
{
    public partial class UsersPage
    {
        private List<User>? _registeredUsers;
        private string fileName = "UserData.json";

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            _registeredUsers = UserDataService.DeserializeUsersFromFile(fileName) ?? new List<User>();
        }

        private void AddUser(User newUser)
        {
            if (_registeredUsers == null)
            {
                _registeredUsers = new List<User>();
            }

            _registeredUsers.Add(newUser);
            UserDataService.SerializeUsersToFile(fileName, _registeredUsers);
        }

    }
}