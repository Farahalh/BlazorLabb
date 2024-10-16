namespace BlazorLabb
{
    public interface IPerson
    {
        string Name { get; set; }
        string UserName { get; set; }

        string Email { get; set; }

        string Password { get; set; }
    }
}
