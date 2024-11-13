namespace BlazorLabb.Model
{
    /// <summary>
    /// Represents a data model for user information, serving as a container for user-related properties.
    /// This class is solely for holding data and contains no functional behavior.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public Company? Company { get; set; }
        public Address? Address { get; set; }

        public User(int id, string name, string username, string email, Company company, Address address)
        {
            Id = id;
            Name = name;
            Username = username;
            Email = email;
            Company = company;
            Address = address;
        }
    }
}
