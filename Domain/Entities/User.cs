using Domain.Commons;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Description { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        [Required, MinLength(4)]
        public string Password { get; set; }

    }
}
