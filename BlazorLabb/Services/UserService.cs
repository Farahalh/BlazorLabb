using System.Text.Json;
using BlazorLabb.Model;

namespace BlazorLabb.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService
    {
        // TODO: Make serialization work.
        // How do I bind the user input to this json file?
        public static async Task<List<User>> SerializeUserAsync()
        {
            //string? users = "";
            string fileName = "UserData.json";
            using FileStream createStream = File.Create(fileName);

            string jsonString = JsonSerializer.Serialize(user);
            
            //await JsonSerializer.SerializeAsync(createStream, users);
            //await createStream.DisposeAsync();
        }

        public static async Task<List<Person>> DeserializeUserAsync()
        {
            string fileName = "UserData.json";
            using FileStream openStream = File.OpenRead(fileName);

            string jsonStr = File.ReadAllText(fileName);
            List<Person> persons = JsonSerializer.Deserialize<List<Person>>(jsonStr);


            //return await JsonSerializer.DeserializeAsync<List<User>>(openStream) ?? new List<User>();
        }

    }
}
