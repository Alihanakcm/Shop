using Shop.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Shop.Northwind.MvcWebUI
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}