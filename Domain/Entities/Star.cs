using Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Star : Auditable
    {
        [Key]
         public long Id { get; set; }
         public long RepositoryId { get; set; }
         public Repository Repository { get; set; }
    }
}
