using AutoMapper;
using Data.IRepositories;
using Data.Repositories;
using Domain.Entities;

using Service.DTOs;
using Service.Helpers;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp.Service.Services
{
    //    public class OrganisationService : IOrganizationService
    //    {
    //        public ValueTask<Response<OrganizationDto>> AddUserAsync(OrganizationDto OrganizationDto)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public ValueTask<Response<bool>> DeleteUserAsync(long id)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public ValueTask<Response<List<OrganizationDto>>> GetAllUserAsync()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public ValueTask<Response<OrganizationDto>> GetUserByIdAsync(long id)
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public ValueTask<Response<OrganizationDto>> ModifyUserAsync(long id, OrganizationDto userForCreationDto)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //namespace GitApp.Service.Services
    //{
    //    internal class OrganizationService : IOrganizationService
    //    {
    //        private readonly IOrganizationRepository OrganisationRepostory = new OrganizationRepository();

    //        private readonly IMapper mapper;
    //        public OrganizationService(IMapper mapper)
    //        {
    //            this.mapper = mapper;
            }
    //        public async ValueTask<Response<OrganizationDto>> AddUserAsync(OrganizationDto vOrganisationCDto)
    //        {
    //            ////var user = await this.OrganizationRepository.SelectAll();
    //            //var result = user.Any(user => user.Name.Equals(vOrganisationCDto.Name));
    //            if (result is true)
    //            {
    //                return new Response<OrganizationDto>
    //                {
    //                    StatusCode = 404,
    //                    Message = "User is already exits",
    //                    Value = (OrganizationDto)user
    //                };
    //            }

    //            var mappedOrganisation = this.mapper.Map<Organization>(vOrganisationCDto);
    //            var addedOrganisation = await this.OrganisationRepostory.InsertAsync(mappedOrganisation);
    //            var resultLast = this.mapper.Map<OrganizationDto>(addedOrganisation);

    //            return new Response<OrganizationDto>
    //            {
    //                StatusCode = 200,
    //                Message = "Succes",
    //                Value = (OrganizationDto)resultLast
    //            };
    //        }

    //        public async ValueTask<Response<bool>> DeleteUserAsync(int id)
    //        {
    //            var user = await this.OrganisationRepostory.SelectOrganisationAsync(id);
    //            if (user is null)
    //                return new Response<bool>
    //                {
    //                    Code = 404,
    //                    Message = "Not fount given Id",
    //                    Value = false
    //                };

    //            await this.OrganisationRepostory.DeleteOrganisationAsync(id);
    //            return new Response<bool>
    //            {
    //                Code = 200,
    //                Message = "Success",
    //                Value = true
    //            };
    //        }

    //        public async ValueTask<Response<List<OrganisationDto>>> GetAllUserAsync(string search = null)
    //        {
    //            var users = await this.OrganisationRepostory.SelectAllOrganisationAsync();
    //            var context = users.ToList();
    //            if (context.Any())
    //                return new Response<List<OrganisationDto>>
    //                {
    //                    Code = 404,
    //                    Message = "Success",
    //                    Value = null
    //                };

    //            var result = users.Where(user => user.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
    //            var mappedUsers = this.mapper.Map<List<OrganisationDto>>(result);
    //            return new Response<List<OrganisationDto>>
    //            {
    //                Code = 200,
    //                Message = "Success",
    //                Value = mappedUsers
    //            };
    //        }

    //        public async ValueTask<Response<OrganisationDto>> GetUserByIdAsync(int id)
    //        {
    //            var users = await this.OrganisationRepostory.SelectOrganisationAsync(id);
    //            if (users is null)
    //            {
    //                return new Response<OrganisationDto>
    //                {
    //                    Code = 404,
    //                    Message = "Not found",
    //                    Value = null
    //                };
    //            }

    //            var mappedUser = this.mapper.Map<OrganisationDto>(users);

    //            return new Response<OrganisationDto>
    //            {
    //                Code = 200,
    //                Message = "Succes",
    //                Value = mappedUser
    //            };
    //        }

    //        public async ValueTask<Response<OrganisationDto>> ModifyUserAsync(int id, OrganisationCDto OrganisationCDto)
    //        {
    //            var user = await this.OrganisationRepostory.SelectOrganisationAsync(id);
    //            if (user is null)
    //                return new Response<OrganisationDto>
    //                {
    //                    Code = 404,
    //                    Message = "Not found",
    //                    Value = null
    //                };

    //            var updatedUser = await this.OrganisationRepostory.UpdateOrganisationAsync(user);
    //            var mappedUsers = this.mapper.Map<OrganisationDto>(updatedUser);
    //            return new Response<OrganisationDto>
    //            {
    //                Code = 200,
    //                Message = "Success",
    //                Value = mappedUsers
    //            };
    //        }
    //    }

    //    internal interface IOrganisationService
    //    {
    //    }
    //}