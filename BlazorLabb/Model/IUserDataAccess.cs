namespace BlazorLabb.Model
{
    public interface IUserDataAccess
    {
        Task<List<User>> GetUsersAsync();
    }
}