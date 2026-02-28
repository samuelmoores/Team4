using Microsoft.EntityFrameworkCore;
namespace Sanctum.Models
{
    public class SancContext : DbContext
    {
        public SancContext(DbContextOptions<SancContext> options) 
            : base(options) 
        { 
        }

        public DbSet<SancContext> SancModels { get; set; }
    }
}
