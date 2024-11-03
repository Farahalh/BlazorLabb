using BlazorLabb.Model;
using Microsoft.AspNetCore.Components.Forms;
using System.Text.Json;
using System.Xml.Linq;

/// <summary>
/// Represents a registration form component for capturing user details.
/// Initializes a new `EditFormPerson` object with placeholder address and company data.
/// Handles form submission, updating the form's visibility status upon completion.
/// Optionally, user data can be serialized to JSON for further processing (currently commented out).
/// </summary>

namespace BlazorLabb.Components.Pages
{
    public partial class RegisterUser
    {
        UserRegistration person = new UserRegistration
        {
            Adress = new Address("", "", ""),
            Company = new Company("", "")
        };

        bool isFormVisible = true;

        void OnFormSubmitted()
        {
            isFormVisible = false;
        }
    }
}