using Microsoft.EntityFrameworkCore;

namespace Projekt.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options) { 
        


        }
    }
}
