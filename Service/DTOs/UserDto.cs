using Domain.Entities;

namespace Service.DTOs
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }

        public static explicit operator UserDto(User user)
        {
            return new UserDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Description = user.Description
            };
        }
    }
}