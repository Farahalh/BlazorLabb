using Microsoft.AspNetCore.Components.Forms;

namespace BlazorLabb.Components.Pages
{
    public partial class RegisterUser
    {
        Person Person = new Person();

        string? SubmitResult;

        void FormSubmitted()
        {
            SubmitResult = "Success - form is valid";
        }
    }
}