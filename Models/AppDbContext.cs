using Microsoft.EntityFrameworkCore;



namespace TAKI.adi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSets go here, e.g.:
         public DbSet<Students> Students { get; set; }
    }
}