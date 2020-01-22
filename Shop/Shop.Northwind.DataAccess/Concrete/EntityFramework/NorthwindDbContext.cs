using Microsoft.EntityFrameworkCore;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbQuery<ProductList> GetListViews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<ProductList>().ToView("ProductListWithCategory");
        }
    }
}
