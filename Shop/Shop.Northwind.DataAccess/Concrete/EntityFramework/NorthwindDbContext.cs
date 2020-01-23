using Microsoft.EntityFrameworkCore;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
        }

    }
}
