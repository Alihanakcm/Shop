using System.Collections.Generic;
using Shop.Northwind.Business.Abstract;
using Shop.Northwind.DataAccess.Abstract;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public void Delete(int categoryId)
        {
            _categoryDal.Delete(new Category { CategoryId = categoryId });
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }
    }
}
