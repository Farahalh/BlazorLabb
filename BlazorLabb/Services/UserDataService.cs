using System.Text.Json;
using BlazorLabb.Model;

namespace BlazorLabb.Services
{
    /// <summary>
    /// Provides utility methods for serializing and deserializing `User` objects to and from JSON files.
    /// `SerializeUsersToFile` saves a user object as JSON to a specified file, while 
    /// `DeserializeUsersFromFile` reads JSON data from a file and converts it back to a `User` object.
    /// Designed to facilitate file-based persistence of user data within the application.
    /// </summary>

    public class UserDataService
    {
        public static void SerializeUsersToFile(string fileName, List<User> users)
        {
            string jsonStr = JsonSerializer.Serialize(users);
            File.WriteAllText(fileName, jsonStr);
        }

        public static List<User>? DeserializeUsersFromFile(string fileName)
        {
            if (!File.Exists(fileName)) return new List<User>();

            string jsonStr = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<List<User>>(jsonStr);
        }

    }
}
