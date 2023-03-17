using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrganizationUser
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }    
        public User user { get; set; }

        public long OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
