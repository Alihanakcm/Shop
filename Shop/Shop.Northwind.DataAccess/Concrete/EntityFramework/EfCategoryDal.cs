using Shop.Core.DataAccess.EntityFramework;
using Shop.Northwind.DataAccess.Abstract;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindDbContext>,ICategoryDal
    {
    }
}
