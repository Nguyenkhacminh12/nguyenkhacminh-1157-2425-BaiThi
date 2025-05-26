using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using nguyenkhacminh_2121051157_2425_BaiThi.Data;
using System.IO;

namespace nguyenkhacminh_2121051157_2425_BaiThi.Data
{
    public class ApplicationDbcontextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // nơi đặt file appsettings.json
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("BaiThi"));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
