/// <summary>
/// Represents an address with properties for street name, city, and zipcode.
/// This model is used to store and organize address details associated with a user or entity.
/// </summary>

namespace BlazorLabb.Model
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }

        public Address(string street, string city, string zipcode)
        {
            Street = street;
            City = city;
            Zipcode = zipcode;
        }
    }
}
