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
    public class OrganisationMemberRepository : IOrganizationMember
    {
        private readonly AppDbContext appDbContext = new AppDbContext();
        public async ValueTask<User> InsertAsync(User user)
        {
            EntityEntry<User> entity = await this.appDbContext.Users.AddAsync(user);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }


        public async ValueTask<User> ModifyAsync(User user)
        {
            EntityEntry<User> entity = this.appDbContext.Users.Update(user);
            await appDbContext.SaveChangesAsync();
            return entity.Entity;
        }

        public async ValueTask<bool> RemoveAsync(long id)
        {
            User entity =
           await this.appDbContext.Users.FirstOrDefaultAsync(user => user.Id.Equals(id));
            if (entity is null)
                return false;

            this.appDbContext.Users.Remove(entity);
            await this.appDbContext.SaveChangesAsync();
            return true;
        }

        public async  ValueTask<User> Select(Predicate<User> predicate) =>
        
            await this.appDbContext.Users.FirstOrDefaultAsync(user => predicate(user));
        

        public IQueryable<User> SelectAll() => this.appDbContext.Users;
        
    }
}
