using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
    public interface IFollowingRepository
    {
        ValueTask<Following> InsertFolowingAsync(Following following);
        ValueTask<Following> UpdateFollwingAsync(Following following);
        ValueTask<bool> DeleteFollowingAsync(long id);
        ValueTask<Following> SelectFollowingAsync(Predicate<Following> predicate);
        IQueryable<Following> SelectAllFollowing();
    }
}
