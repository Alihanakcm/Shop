using System.Collections.Generic;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.MvcWebUI.Areas.Admin.Models
{
    public class ProductAddViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}