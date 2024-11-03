using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents a user for use in an editable form context, capturing essential user details such as 
/// name, username, email, password, and associated address and company information. 
/// The class enforces data validation rules to ensure required fields and valid input formats, 
/// supporting accurate data collection and integrity in the application.
/// </summary>

namespace BlazorLabb.Model
{
    public class UserRegistration : IPerson
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User Name is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(4, ErrorMessage = "Password must be at least 4 characters long.")]
        public string Password { get; set; }

        [Required]
        public Company Company { get; set; }

        [Required]
        public Address Adress { get; set; }

        public UserRegistration()
        {

        }
    }
}
