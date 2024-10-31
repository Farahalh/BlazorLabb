using System.ComponentModel.DataAnnotations;

namespace BlazorLabb.Model
{
    public class Person : IPerson
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


        //public string CompanyName { get; set; }
        //public string Catchphrase { get; set; }

        [Required]
        public Company company { get; set; }

        [Required]
        public Address adress { get; set; }

        public Person()
        {

        }

        //public Person(int id, string name, string userName, string email, string password)
        //{
        //    Id = id;
        //    Name = name;
        //    UserName = userName;
        //    Email = email;
        //    Password = password;
        //}
    }
}
