// Ví dụ: Data/TenDbContextCuaBan.cs
using Microsoft.EntityFrameworkCore;
using nguyenkhacminh_2121051157_2425_BaiThi.Models; // Namespace của Model

namespace nguyenkhacminh_2121051157_2425_BaiThi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Test> Test { get; set; } // Đặt tên cho DbSet (ví dụ: TenModelCuaBanItems)
        // ... các DbSet khác nếu có
    }
}