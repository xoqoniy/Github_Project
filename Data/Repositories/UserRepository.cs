using Data.Context;
using Data.IRepositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext appDbContext = new AppDbContext();

        public async ValueTask<User> InsertUserAsync(User user)
        {
            EntityEntry<User> entity = await appDbContext.Users.AddAsync(user);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }

        public async ValueTask<User> UpdateUserAsync(User user)
        {
            EntityEntry<User> entity = appDbContext.Users.Update(user);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }

        public async ValueTask<bool> DeleteUserAysnyc(long id)
        {
            var entity = await appDbContext.Users.FirstOrDefaultAsync(user => user.Id.Equals(id));
            if (entity is null)
                return false;

            appDbContext.Users.Remove(entity);
            await appDbContext.SaveChangesAsync();
            return true;
        }

        public async ValueTask<User> SelectUserAsync(Predicate<User> predicate) => await appDbContext.Users.FirstOrDefaultAsync(id => predicate(id));

        public IQueryable<User> SelectAllAsync() => appDbContext.Users;

    }
}