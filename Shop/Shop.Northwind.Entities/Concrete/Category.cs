using System.Collections.Generic;
using Shop.Core.Entities;

namespace Shop.Northwind.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
