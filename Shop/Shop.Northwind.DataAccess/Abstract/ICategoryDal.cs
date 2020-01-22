using Shop.Core.DataAccess;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
