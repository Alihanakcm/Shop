using Shop.Core.DataAccess;
using Shop.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Shop.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductList> GetProductWithDetails();
    }
}
