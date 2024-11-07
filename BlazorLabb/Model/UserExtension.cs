/// <summary>
/// 
/// 
/// </summary>

namespace BlazorLabb.Model
{
    public static class UserExtension
    {
        public static List<User> GetUsers(this IEnumerable<User> users, int count)
        {
            return users.Take(count).ToList();
        }


        public static List<User> GetFilteredUsers(this IEnumerable<User> users, int startIndex, int count)
        {
            if (startIndex < 0 || startIndex >= users.Count())
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }
            if (count < 0 || startIndex + count > users.Count())
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (startIndex == 0)
            {
                return users.Take(count).ToList();
            }
            else
            {
                return users.Skip(startIndex).Take(count).ToList();
            }
        }

        public static List<User> GetSomeUsers(this IEnumerable<User> users, int startIndex, int count)
        {
            return users.Take(5).ToList();
        }

        public static List<User> GetUsersOrderedById(this IEnumerable<User> users, int count)
        {
            return users.Take(count).OrderBy(i => i.Id).ToList();
        }

        public static List<User> GetUsersOrderedByName(this IEnumerable<User> users)
        {
            return users.OrderBy(n => n.Name).ToList();
        }
        public static List<User> GetUsersBySearch(this IEnumerable<User> users, string searchTerm)
        {
            return users
                .Where(user => user.Name?.ToLower().Contains(searchTerm.ToLower()) ?? false)
                .ToList();
        }

    }
}
