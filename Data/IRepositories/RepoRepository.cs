using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
    public interface IRepRepository
    {
        ValueTask<Repository> InsertRepositoryAsync(Repository rep);
        ValueTask<Repository> UpdateRepositoryAsync(Repository rep);
        ValueTask<bool> DeleteRepositoryAysnyc(long id);
        ValueTask<Repository> SelectRepositoryAsync(Predicate<Repository> predicate);
        IQueryable<Repository> SelectAllRepositories();

    }
}