using Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Following : Auditable
    {
        public long UserId { get; set; }
        public User user { get; set; }
    }
}
