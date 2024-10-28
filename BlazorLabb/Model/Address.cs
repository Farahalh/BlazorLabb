namespace BlazorLabb.Model
{
    public class Address
    {
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }

        public Address(string streetName, string city, string zipcode)
        {
            StreetName = streetName;
            City = city;
            Zipcode = zipcode;
        }
    }
}
