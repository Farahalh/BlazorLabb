using BlazorLabb.Model;
using Microsoft.AspNetCore.Components.Forms;
using System.Text.Json;
using System.Xml.Linq;

/// <summary>

/// The RegisterUser component renders a registration form for capturing user details, including personal, address, and company information.
/// It initializes a UserRegistration object (person) with placeholder address and company values.
/// The form’s visibility is controlled by isFormVisible, which toggles off once the form is submitted.
/// The OnFormSubmitted method handles form submission by hiding the form upon completion.
/// This component allows users to enter and submit their information interactively, with dynamic visibility control.
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