using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using nguyenkhacminh_2121051157_2425_BaiThi.Models;

namespace NguyenKhacMinh_2121051157_BaiThi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<nguyenkhacminh_2121051157_2425_BaiThi.Models.DemoABC> DemoABC { get; set; } = default!;
    }
}
