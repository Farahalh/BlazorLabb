using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorLabb.Model;
using System.Buffers.Text;

/// <summary>
/// The UserDataAccess class provides asynchronous retrieval of user data from a JSON file.
/// _filePath specifies the file path, defaulting to "UserData.json".
/// GetUsersAsync reads and deserializes the file to a list of User objects:
/// Returns an empty list if the file is missing or empty.
/// This class supports file - based user data persistence.
/// </summary>
/// 

namespace BlazorLabb.Model
{
    public class JsonUserDataAccess : IUserDataAccess
    {
        private readonly string _filePath;
        public List<User>? _users = new List<User>();
        public int UserCount { get; set; }
        public string DataSource { get; set; }

        public List<User> Users => throw new NotImplementedException(); //Not properly implemented!!

        public JsonUserDataAccess(string filePath = "UserData.json")
        {
            _filePath = filePath;
        }

        public async Task LoadUsersAsync()
        {
            if (!File.Exists(_filePath))
            {
                _users = new List<User>();
                return;
            }

            var jsonData = await File.ReadAllTextAsync(_filePath);
            _users = string.IsNullOrWhiteSpace(jsonData)
                ? new List<User>()
                : JsonSerializer.Deserialize<List<User>>(jsonData) ?? new List<User>();
        }

    }
}
