using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sql
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TAKI.adi.Models
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            object value = optionsBuilder.UseSqlServer(configuration.GetConnectionString("AppDbContext"));

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}