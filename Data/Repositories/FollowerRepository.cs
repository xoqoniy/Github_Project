using Data.Context;
using Data.IRepositories;
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
    public class FollowerRepository : IFolllowerRepository
    {
private readonly AppDbContext appDbContext = new AppDbContext();

        public async ValueTask<Follower> InsertFolowerAsync(Follower follower)
        {
            EntityEntry<Follower> entity = await this.appDbContext.Followeres.AddAsync(follower);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }

        public IQueryable<Follower> SelectAllFollower()
        {
            var query = "select * from \"Followeres\"";
            return this.appDbContext.Followeres.FromSqlRaw(query);
        }

        public async ValueTask<Follower> SelectFollowerAsync(Predicate<Follower> predicate) =>
        await this.appDbContext.Followeres.FirstOrDefaultAsync(follower => predicate(follower));
        public async ValueTask<bool> DeleteFollowerAsync(long id)
        {
            Follower entity = await this.appDbContext.Followeres.FirstOrDefaultAsync(follow => follow.Id.Equals(id));
            if (entity is null)
                return false;

            this.appDbContext.Followeres.Remove(entity);
            await this.appDbContext.SaveChangesAsync();
            return true;
        }

        public async ValueTask<Follower> UpdateFollowerAsync(Follower follower)
        {
            EntityEntry<Follower> entity = this.appDbContext.Followeres.Update(follower);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }
    }
}
