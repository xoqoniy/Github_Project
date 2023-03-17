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
            string path = "Server = localhost; Database = Github_Project; User Id = posgres; password = 1968";
            optionsBuilder.UseNpgsql(path);
          
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Following> Followings { get; set; }

        public DbSet<Followers> Follow { get; set; }






    }
}
