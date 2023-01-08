using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projekt.Models;
using System;

namespace Projekt.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options) { 
        
        }   

    }
}
