using System.Diagnostics;

namespace BlazorLabb.Model
{
    public class APIUserDataAccess : IUserDataAccess
    {
        public List<User>? _users;
        public string DataSource { get; set; }
        public int UserCount { get; set; }

        public List<User> Users
        {
            get 
            {
                _users ??= new List<User>();
                return _users;
            }
            set 
            {
                _users = value;
            }
        }

        public APIUserDataAccess(int userCount)
        {
            DataSource = "API";
            UserCount = 10;
        }

        public async Task LoadUsersAsync()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    _users = await httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "Could not fetch users from API.");
            }
        }

    }
}
