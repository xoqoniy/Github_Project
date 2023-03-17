using Domain.Commons;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; } = "";
        public string Link { get; set; } = "";
        public string Email { get; set; }
        [Required, MinLength(4)]
        public string Password { get; set; }
        public int FollowingPeople { get; set; } = 0;
        public int FollowersCount { get; set; } = 0;


        public List<Star> Stars { get; set; }
        public List<Organization> Organizations
        {
            get; set;
        }
        public List<Repository> Repositories { get; set; }
        public List<Follower> Followers { get; set; }
        public List<Following> Followings { get; set; }
    }
}
