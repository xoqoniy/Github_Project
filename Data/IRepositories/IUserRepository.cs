using Domain.Entities;

namespace Data.IRepositories
{
    public interface IUserRepository
    {
        ValueTask<User> InsertUserAsync(User user);
        ValueTask<User> UpdateUserAsync(User user);
        ValueTask<bool> DeleteUserAysnyc(long id);
        ValueTask<User> SelectUserAsync(Predicate<User> predicate);
        IQueryable<User> SelectAllAsync();
    }
}