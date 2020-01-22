using System.Collections.Generic;
using System.Linq;
using Shop.Core.DataAccess.EntityFramework;
using Shop.Northwind.DataAccess.Abstract;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindDbContext>, IProductDal
    {
        public List<ProductList> GetByView()
        {
            using (NorthwindDbContext context = new NorthwindDbContext())
            {
                return context.GetListViews.ToList();
            }
        }
    }
}
