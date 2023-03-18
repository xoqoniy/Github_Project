using AutoMapper;
using Azure;
using Data.IRepositories;
using Data.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Service.DTOs;
using Service.Helpers;
using Service.Interfaces;

namespace Service.Services
{
    public class UserService : IUserService
    {
        IUserRepository userRepo = new UserRepository();
        private readonly IMapper mapper;
        public UserService(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public async ValueTask<Helpers.Response<UserDto>> AddUserAsync(UserForCreationDto userForCreationDto)
        {
            var users = await userRepo.SelectUserAsync(users => users.Username.Equals(userForCreationDto.Username));

            if (users is not null)
                return new Helpers.Response<UserDto>
                {
                    StatusCode = 404,
                    Message = "User is already existed",
                    Value = (UserDto)users
                };

            var addedUsers = await userRepo.InsertUserAsync(users);

            var mappedUser = this.mapper.Map<User>(userForCreationDto);
            var addedUser = await this.userRepo.InsertUserAsync(mappedUser);
            var resultDto = this.mapper.Map<UserDto>(addedUser);
            return new Helpers.Response<UserDto>
            {
                StatusCode = 200,
                Message = "Success",
                Value = resultDto
            };
        }

        public async ValueTask<Helpers.Response<UserDto>> ModifyUserAsync(long id, UserForCreationDto userForCreationDto)
        {
            var user = await userRepo.SelectUserAsync(user => user.Id.Equals(id));
            if (user is null)
                return new Helpers.Response<UserDto>
                {
                    StatusCode = 404,
                    Message = "Couldn't find for given ID",
                    Value = null
                };

            var updatedUser = await this.userRepo.UpdateUserAsync(user);
            var mappedUsers = this.mapper.Map<UserDto>(updatedUser);
            return new Helpers.Response<UserDto>
            {
                StatusCode = 200,
                Message = "Success",
                Value = mappedUsers
            };
        }



        public async ValueTask<Helpers.Response<bool>> DeleteUserAsync(long id)
        {
            var user = await userRepo.SelectUserAsync(user => user.Id.Equals(id));

            if (user is null)
                return new Helpers.Response<bool>
                {
                    StatusCode = 404,
                    Message = "Couldn't find for given ID",
                    Value = false
                };

            await this.userRepo.DeleteUserAysnyc(id);
            return new Helpers.Response<bool>
            {
                StatusCode = 200,
                Message = "Success",
                Value = true
            };
        }

        public async ValueTask<Helpers.Response<UserDto>> GetUserByIdAsync(long id)
        {
            User user = await userRepo.SelectUserAsync(user => user.Id.Equals(id));
            if (user is null)
                return new Helpers.Response<UserDto>
                {
                    StatusCode = 404,
                    Message = "Couldn't find for given ID",
                    Value = null
                };

            var mappedUsers = mapper.Map<UserDto>(user);
            return new Helpers.Response<UserDto>
            {
                StatusCode = 200,
                Message = "Success",
                Value = mappedUsers
            };
        }

        public async ValueTask<Helpers.Response<List<UserDto>>> GetAllUserAsync()
        {
            var users = await userRepo.SelectAllAsync().ToListAsync();
            if (users.Any())
                return new Helpers.Response<List<UserDto>>
                {
                    StatusCode = 404,
                    Message = "Not found",
                    Value = null
                };

            var mappedUser = mapper.Map<List<UserDto>>(users); 
            return new Helpers.Response<List<UserDto>>
            {
                StatusCode = 200,
                Message = "Success",
                Value = mappedUser
            };

        }

    }
}