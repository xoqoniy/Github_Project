using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class OrganizationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<OrganizationMember> organizationMembers { get; set; }
        public List<Repository> Repositories { get; set; }
    }
}
