using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
    public interface IOrganizationRepository
    {
        ValueTask<Organization> InsertAsync(Organization organization);
        ValueTask<Organization> ModifyAsync(Organization organization);
        ValueTask<bool> RemoveAsync(long id);
        ValueTask<Organization> Select(Predicate<Organization> predicate);
        IQueryable<Organization> SelectAll();
    }
}
