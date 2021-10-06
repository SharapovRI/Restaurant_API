using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Restaurant_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_API
{
    [AllowAnonymous]
    public class ApplicationContext : DbContext
    {
        public DbSet<User> users { get; set; }
        
        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }
        [AllowAnonymous]
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=RestaurantDB;Username=postgres;Password=PostgreSQL");
        }
    }
}
