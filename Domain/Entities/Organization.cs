using Domain.Commons;

namespace Domain.Entities
{
    public class Organization : Auditable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public string People { get; set; }


        public long UserId { get; set; }
        public User user { get; set; }

        public long RepositoryId { get; set; }
        public Repository repository { get; set; }    

    }
}
