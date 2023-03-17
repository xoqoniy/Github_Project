using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
    public interface IOrganizationMember
    {
        ValueTask<User> InsertAsync(User user);
        ValueTask<User> ModifyAsync(User user);
        ValueTask<bool> RemoveAsync( long id);
        ValueTask<User> Select(Predicate<User> predicate);
        IQueryable<User> SelectAll();
    }
}
