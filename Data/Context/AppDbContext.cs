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
        DbSet<User> Users { get; set; }
        DbSet<Repository> Repositories { get; set; }
        DbSet<Languages> Languages { get; set; }
        DbSet<Organization> Organizations { get; set; }
        DbSet<Star> Stars { get; set; }
        DbSet<Follower> Followeres { get; set;}
        DbSet<Following> Followings{ get; set; }


    }
}
