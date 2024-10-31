namespace BlazorLabb.Model
{
    public interface IPerson
    {
        // TODO: Can the interface be extended and nested to include compnay and address?
        string Name { get; set; }
        string UserName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}
