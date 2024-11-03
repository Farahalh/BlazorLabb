/// <summary>
/// Represents an address with properties for street name, city, and zipcode.
/// This model is used to store and organize address details associated with a user or entity.
/// </summary>

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
