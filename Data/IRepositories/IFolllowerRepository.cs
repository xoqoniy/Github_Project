using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
    public interface IFolllowerRepository
    {
            ValueTask<Follower> InsertFolowerAsync(Follower follower);
            ValueTask<Follower> UpdateFollowerAsync(Follower follower);
            ValueTask<bool> DeleteFollowerAsync(long id);
            ValueTask<Follower> SelectFollowerAsync(Predicate<Follower> predicate);
            IQueryable<Follower> SelectAllFollower();

        }
}
