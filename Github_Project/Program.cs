using Data.Repositories;
using Domain.Entities;
using System;
namespace Github_Project;
public class Program
{
    public static async Task Main (string[] args)
    {
        OrganizationRepository organizationRepository = new OrganizationRepository();
        Organization organization = new Organization()
        {
            Id = 1,
            Name = "Apple",
            Description = "Blla",

        };
        await organizationRepository.InsertAsync(organization);
    }

}

//User user = new User()
//{
//    FirstName= "Test",
//    LastName= "Testjonov",
//    Email = "Something#gmail",
//    Password = "12345678"
//}