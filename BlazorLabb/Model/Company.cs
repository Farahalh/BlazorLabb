/// <summary>
/// Represents a company with a name and a catchphrase.
/// This class is used to store information about a company that may be associated with a user or other entities.
/// </summary>

namespace BlazorLabb.Model
{
    public class Company
    {
        public string CompanyName { get; set; }
        public string Catchphrase { get; set; }

        public Company(string companyName, string catchphrase)
        {
            CompanyName = companyName;
            Catchphrase = catchphrase;
        }
    }
}
