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
    public class UserDataAccess : IUserDataAccess
    {
        private readonly string _filePath;

        public UserDataAccess(string filePath = "UserData.json")
        {
            _filePath = filePath;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            if (!File.Exists(_filePath))
            {
                return new List<User>();
            }

            var jsonData = await File.ReadAllTextAsync(_filePath);
            return string.IsNullOrWhiteSpace(jsonData)
                ? new List<User>()
                : JsonSerializer.Deserialize<List<User>>(jsonData) ?? new List<User>();
        }
    }
}
