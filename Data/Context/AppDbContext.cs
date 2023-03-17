using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server = localhost; Database = Github_Project; User Id = postgres; password = 1968;";
            optionsBuilder.UseNpgsql(path);
          
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Following> Followings { get; set; }

        public DbSet<Follower> Follow { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<OrganizationUser> OrganizationUsers { get; set; }


        #region SeedData
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User>()
            {
                new User
                {
                    Id = 2,
                    FirstName = "Asadbek",
                    LastName = "Zaylobiddinov",
                    Email = "asad@gmail.com",
                    Password = "87654321",
                },
                new User
                {
                    Id = 3,
                    FirstName = "Asadbek",
                    LastName = "Zaylobiddinov",
                    Email = "asad@gmail.com",
                    Password = "87654321",
                }

            });
            modelBuilder.Entity<Repository>().HasData(new List<Repository>()
            {
                new Repository
                {
                    Id = 1,
                    Name = "Github_Project",
                    Description = "Nimadir",
                    UserId= 1,

                }

               
            });
          
        }
        
        

        #endregion




    }
}
