using BlazorLabb.Model;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLabb.Components.Pages
{
    public partial class UsersPage
    {
        private List<User> _users = new List<User>();
        public int UserCount { get; set; }
        public IUserDataAccess? UserDataAccess { get; set; }

        //private List<User> _registeredUsers = new List<User>();
        private string searchTerm = "";
        //private readonly JsonUserDataAccess _defaultUserDataAccess = new JsonUserDataAccess();

        ////public List<User>? users;

        [Parameter]
        public int AllUsersToDisplay { get; set; }

        [Parameter]
        public int OnLoadUsersToDisplay { get; set; }

        [Parameter]
        public IUserDataAccess? DataAccess { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);
            UserDataAccess = UserDataAccessCreator.Create(DataSource.API, 10);
            await LoadUserDataAsync();
            DisplaySome();
        }

        protected override void OnParametersSet()
        {
            DataAccess ??= new UserDataAccess(UserCount);

            if (OnLoadUsersToDisplay < 1)
            {
                OnLoadUsersToDisplay = 5;
            }

            if (AllUsersToDisplay < 1)
            {
                AllUsersToDisplay = 10;
            }
        }

        private async Task LoadUserDataAsync()
        {
            try
            {
                DataAccess ??= new UserDataAccess(UserCount);
                //var allUsers = await DataAccess.LoadUsersAsync();

                //_users = allUsers?.Take(OnLoadUsersToDisplay).ToList() ?? new List<User>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading user data: {ex.Message}");
                _users = new List<User>();
            }
        }

        private void DisplayAll()
        {
            _users = DataAccess.Users;
        }

        private void DisplaySome()
        {
            _users = DataAccess.Users.GetFilteredUsers(0, OnLoadUsersToDisplay);
        }

        private void OrderByName()
        {
            _users = DataAccess.Users.GetUsersOrderedByName();
        }

        private void OrderedById()
        {
            _users = DataAccess.Users.GetUsersOrderedById(AllUsersToDisplay);
        }

        private void FilterBySearch()
        {
            _users = DataAccess.Users.GetUsersBySearch(searchTerm);
        }
    }
}
