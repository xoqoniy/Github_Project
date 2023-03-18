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
            optionsBuilder.UseNpgsql("Server = localhost; Database = Github_Project; User Id = postgres; password = 1968;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<Follower> Followeres { get; set;}
        public DbSet<Following> Followings{ get; set; }


    }
}
