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
         public DbSet<teacher> teacher { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
                .HasOne(s => s.Subject)
                .WithMany(s => s.Students)
                .HasForeignKey(s => s.SubjectId);

            base.OnModelCreating(modelBuilder);
        }
    }
}