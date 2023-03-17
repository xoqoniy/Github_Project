using Data.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class FollowingRepository
    {
        private readonly AppDbContext appDbContext = new AppDbContext();

        public async ValueTask<Following> InsertFolowingAsync(Following following)
        {
            EntityEntry<Following> entity = await this.appDbContext.Followings.AddAsync(following);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }

        public IQueryable<Following> SelectAllFollowing()
        {
            var query = "select * from \"Followeres\"";
            return this.appDbContext.Followings.FromSqlRaw<Following>(query);
        }

        public async ValueTask<Follower> SelectFollowerAsync(Predicate<Follower> predicate) =>
            await this.appDbContext.Followeres.FirstOrDefaultAsync(following => predicate(following));
        public async ValueTask<bool> DeleteFollowerAsync(long id)
        {
            Follower entity = await this.appDbContext.Followeres.FirstOrDefaultAsync(follow => follow.Id.Equals(id));
            if (entity is null)
                return false;

            this.appDbContext.Followeres.Remove(entity);
            await this.appDbContext.SaveChangesAsync();
            return true;
        }

        public async ValueTask<Following> UpdateFollowingAsync(Following following)
        {
            EntityEntry<Following> entity = this.appDbContext.Followings.Update(following);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }
    }
}
