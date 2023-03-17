using Domain.Commons;
using Domain.Enums;

namespace Domain.Entities
{
    public class Repository : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Privacy_Status RepositoryType { get; set; } = Privacy_Status.Public;
        public long UserId { get; set; }
        public int StarsCount { get; set; }
        public long OrganizationId { get; set; }

    }
}
