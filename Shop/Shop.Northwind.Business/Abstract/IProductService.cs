using Shop.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Shop.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        List<Product> GetbyCategory(int category);
        List<Product> GetByKey(string key);
        Product GetById(int productId);
        List<ProductList> GetProductDetails();
    }
}
