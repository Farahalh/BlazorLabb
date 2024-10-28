namespace BlazorLabb.Model
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string UserName { get; set; }

        string Email { get; set; }

        string Password { get; set; }
    }
}
