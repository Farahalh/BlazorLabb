
namespace BlazorLabb.Model
{
    public interface IUserDataAccess
    {
        List<User> Users {  get; }
        public string DataSource { get; set; }
        public Task LoadUsersAsync();
    }
}