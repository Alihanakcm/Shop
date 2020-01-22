using System.Collections.Generic;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Delete(int categoryId);
        void Add(Category category);
    }
}
