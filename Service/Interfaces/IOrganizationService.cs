using Service.DTOs;
using Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IOrganizationService
    {
        ValueTask<Response<OrganizationDto>> AddUserAsync(OrganizationDto OrganizationDto);
        ValueTask<Response<OrganizationDto>> ModifyUserAsync(long id, OrganizationDto userForCreationDto);
        ValueTask<Response<bool>> DeleteUserAsync(long id);
        ValueTask<Response<OrganizationDto>> GetUserByIdAsync(long id);
        ValueTask<Response<List<OrganizationDto>>> GetAllUserAsync();
    }
}
