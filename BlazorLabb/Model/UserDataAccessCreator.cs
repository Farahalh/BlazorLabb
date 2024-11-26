namespace BlazorLabb.Model
{
    public class UserDataAccessCreator
    {
        public static IUserDataAccess Create(DataSource dataSource, int userCount)
        {
            return dataSource switch
            {
                DataSource.Random => new UserDataAccess(userCount),
                DataSource.Json => new JsonUserDataAccess(),
                DataSource.API => new APIUserDataAccess(userCount),
                _ => throw new ArgumentException("Argument Not Valid", nameof(dataSource)),
            };
        }
    }
}
