using System.Diagnostics;

namespace BlazorLabb.Model
{
    public class UserDataAccess : IUserDataAccess
    {
        private List<User> _users;
        public int UserCount { get; set; }
        public string DataSource { get; set; }
        public List<User> Users
        {
            get
            {
                if (_users == null)
                {
                    _users = GetRandomUserData();
                }
                return _users;
            }
        }

        private readonly string[] _userNames = new[]
                {
                "Alice", "Bob", "Charlie", "Diana", "Edward",
                "Fiona", "George", "Hannah", "Ian", "Julia"
                };
        private readonly string[] _userUserNames = new[]
                {
                "alice_wonder", "bob_builder", "charlie_brown", "diana_prince", "edward_snow",
                "fiona_apple", "george_clooney", "hannah_montana", "ian_fleming", "julia_roberts"
                };
        private readonly string[] _userEmails = new[]
                {
                "alice@example.com", "bob@example.com", "charlie@example.com",
                "diana@example.com", "edward@example.com", "fiona@example.com",
                "george@example.com", "hannah@example.com", "ian@example.com",
                "julia@example.com"
                };
        private readonly string[] _userCities = new[]
                {
                "New York", "Los Angeles", "Chicago", "Houston", "Phoenix",
                "Philadelphia", "San Antonio", "San Diego", "Dallas", "San Jose"
                };
        private readonly string[] _userZipcodes = new[]
                {
                "10001", "90001", "60601", "77001", "85001",
                "19101", "78201", "92101", "75201", "95101"
                };
        private readonly string[] _userStreets = new[]
                {
                "Main St", "Broadway", "Elm St", "High St", "Oak St",
                "Maple St", "Pine St", "Cedar St", "Birch St", "Willow St"
                };
        private readonly string[] _userCompanies = new[]
                {
                "TechCorp", "Innova", "Globex", "Umbrella", "Wayne Enterprises",
                "Stark Industries", "Oscorp", "Pied Piper", "Hooli", "Massive Dynamic"
                };
        private readonly string[] _userCatchphrases = new[]
                {
                "Innovate daily", "Building the future", "Excellence always",
                "Reaching new heights", "Pioneering solutions", "Your success, our mission",
                "Empowering tomorrow", "Shaping ideas", "Driving innovation", "Beyond expectations"
                };

        public UserDataAccess(int userCount)
        {
            DataSource = "RandomUsers";
            UserCount = userCount;
        }

        private List<User> GetRandomUserData()
        {
            return Enumerable.Range(1, 10).Select(index => new User(
               id: index,
               name: _userNames[Random.Shared.Next(_userNames.Length)],
               username: _userUserNames[Random.Shared.Next(_userUserNames.Length)],
               email: _userEmails[Random.Shared.Next(_userEmails.Length)],
               company: new Company(
                   name: _userCompanies[Random.Shared.Next(_userCompanies.Length)],
                   catchphrase: _userCatchphrases[Random.Shared.Next(_userCatchphrases.Length)]
               ),
               address: new Address(
                   street: _userStreets[Random.Shared.Next(_userStreets.Length)],
                   city: _userCities[Random.Shared.Next(_userCities.Length)],
                   zipcode: _userZipcodes[Random.Shared.Next(_userZipcodes.Length)]
               )
           )).ToList();
        }

        public async Task LoadUsersAsync()
        {
            //Does nothing
            await Task.Run(() => Debug.WriteLine("Users loaded but doesn't really load users"));
        }
    }
}
