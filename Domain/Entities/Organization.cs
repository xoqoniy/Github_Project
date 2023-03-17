using Domain.Commons;

namespace Domain.Entities
{
    public class Organization : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<OrganizationMember> organizationMembers { get; set; }
        public List<Repository> Repositories { get; set; }

    }
}
