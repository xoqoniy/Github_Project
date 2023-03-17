using Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Star : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public long RepositoryId { get; set; }
        public Repository Repository { get; set; }
    }
}
