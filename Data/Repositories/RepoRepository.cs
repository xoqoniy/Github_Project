using Data.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IRepositories;

namespace Data.Repositories
{
    public class RepRepository : IRepRepository
    {
        private readonly AppDbContext appDbContext = new AppDbContext();

        public async ValueTask<Repository> InsertRepositoryAsync(Repository repository)
        {
            EntityEntry<Repository> entity = await this.appDbContext.Repositories.AddAsync(repository);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }

        public async ValueTask<Repository> UpdateRepositoryAsync(Repository repository)
        {
            EntityEntry<Repository> entity = this.appDbContext.Repositories.Update(repository);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }

        public async ValueTask<bool> DeleteRepositoryAysnyc(long id)
        {
            Repository entity = await this.appDbContext.Repositories.FirstOrDefaultAsync(repo => repo.Id.Equals(id));
            if (entity is null)
                return false;

            this.appDbContext.Repositories.Remove(entity);
            await this.appDbContext.SaveChangesAsync();
            return true;
        }

        public async ValueTask<Repository> SelectRepositoryAsync(Predicate<Repository> predicate) =>
            await this.appDbContext.Repositories.FirstOrDefaultAsync(repo => predicate(repo));

        public IQueryable<Repository> SelectAllRepositories()
        {
            var query = "select * from \"Repositories\"";
            return this.appDbContext.Repositories.FromSqlRaw(query);
        }
    }
}