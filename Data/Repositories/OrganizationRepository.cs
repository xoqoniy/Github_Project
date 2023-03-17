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
    public class OrganizationRepository : IOrganizationRepository
    {
        private readonly AppDbContext appDbContext = new AppDbContext();
        public async ValueTask<Organization> InsertAsync(Organization organization)
        {
            EntityEntry<Organization> entity = await this.appDbContext.Organizations.AddAsync(organization);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }

      

        public async ValueTask<Organization> ModifyAsync(Organization organization)
        {
            EntityEntry<Organization> entity = this.appDbContext.Organizations.Update(organization);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }

        public async ValueTask<bool> RemoveAsync(long id)
        {
            Organization entity =
            await this.appDbContext.Organizations.FirstOrDefaultAsync(O => O.Id.Equals(id));
            if (entity is null)
                return false;

            this.appDbContext.Organizations.Remove(entity);
            await this.appDbContext.SaveChangesAsync();
            return true;
        }

        
        public async ValueTask<Organization> Select(Predicate<Organization> predicate) =>
            await this.appDbContext.Organizations.FirstOrDefaultAsync(name => predicate(name));


        public IQueryable<Organization> SelectAll() => this.appDbContext.Organizations;
    }
}
