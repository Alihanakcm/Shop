using System.Collections.Generic;
using System.Linq;
using Shop.Core.DataAccess.EntityFramework;
using Shop.Northwind.DataAccess.Abstract;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindDbContext>, IProductDal
    {
        public List<ProductList> GetProductWithDetails()
        {
            using (NorthwindDbContext context = new NorthwindDbContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductList
                             {
                                 ProductId = p.ProductId,
                                 CategoryName = c.CategoryName,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
