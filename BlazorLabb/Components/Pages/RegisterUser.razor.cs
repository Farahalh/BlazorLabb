using BlazorLabb.Model;
using Microsoft.AspNetCore.Components.Forms;
using System.Text.Json;
using System.Xml.Linq;

namespace BlazorLabb.Components.Pages
{
    public partial class RegisterUser
    {
        Person Person = new Person
        {
            adress = new Address("", "", ""),
            company = new Company("", "")
        };
        //string jsonPersonPosted = string.Empty;
        bool formVisible = true;

        void FormSubmitted()
        {
            formVisible = false;
            //jsonPersonPosted = JsonSerializer.Serialize(Person);
        }
    }
}