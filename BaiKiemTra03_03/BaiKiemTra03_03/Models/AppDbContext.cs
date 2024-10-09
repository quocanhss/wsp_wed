using Microsoft.EntityFrameworkCore;

namespace BaiKiemTra03_03.Models
{
    public class AppDbContext : DbContext
    {
        // Khai báo các DbSet cho các bảng trong cơ sở dữ liệu
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }

        // Cấu hình chuỗi kết nối đến cơ sở dữ liệu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }
    }
}
