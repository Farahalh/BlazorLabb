namespace BlazorLabb.Model
{
    public class User
    {
        // TODO: This structure feels wrong, how can I make sure that the classes are connected?
        // Do I need this nested class or can I open it up? Or can I use existing classes for PErson, Company, Address.
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Company? company { get; set; }
        public Address? streetName { get; set; }
    }
}
