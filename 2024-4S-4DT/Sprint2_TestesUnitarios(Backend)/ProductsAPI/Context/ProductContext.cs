using Microsoft.EntityFrameworkCore;
using ProductsAPI.Domains;

namespace ProductsAPI.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE20-SALA19\\SQLEXPRESS; Database = ProductsTest_tarde; User Id = sa; Password = Senai@134; TrustServerCertificate = True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
