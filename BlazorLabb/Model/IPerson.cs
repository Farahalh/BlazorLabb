/// <summary>
/// Defines the essential properties for a person, including Name, UserName, Email, and Password.
/// Serves as a contract for implementing classes, ensuring a standard structure for user-related information.
/// This interface could potentially be extended to include related data, such as company and address details.
/// </summary>

namespace BlazorLabb.Model
{
    public interface IPerson
    {
        // TODO: Can the interface be extended and nested to include company and address?
        string Name { get; set; }
        string UserName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}
