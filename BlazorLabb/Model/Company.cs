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
