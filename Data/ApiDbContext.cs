using Microsoft.EntityFrameworkCore;
using Projekt.Models;
using System;

namespace Projekt.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options) { 
        
        }   

    }
}
