using System.Collections.Generic;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int CurrentCategory { get; set; }
        public int PageCount { get; set; }
        public List<Category> Categories { get; set; }
    }
}