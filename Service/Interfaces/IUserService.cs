using Service.DTOs;
using Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<Response<UserDto>> AddUserAsync(UserForCreationDto userForCreationDto);
        ValueTask<Response<UserDto>> ModifyUserAsync(long id, UserForCreationDto userForCreationDto);
        ValueTask<Response<bool>> DeleteUserAsync(long id);
        ValueTask<Response<UserDto>> GetUserByIdAsync(long id);
        ValueTask<Response<List<UserDto>>> GetAllUserAsync();

    }
}
