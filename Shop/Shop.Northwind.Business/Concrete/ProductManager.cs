using System.Collections.Generic;
using Shop.Northwind.Business.Abstract;
using Shop.Northwind.DataAccess.Abstract;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public List<Product> GetbyCategory(int category)
        {
            return _productDal.GetList(p => p.CategoryId == category || category == 0);
        }

        public List<Product> GetByKey(string key)
        {
            return _productDal.GetList(p => p.ProductName.ToLower().Contains(key.ToLower()));
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<ProductList> GetProductDetails()
        {
            return _productDal.GetProductWithDetails();
        }
    }
}
