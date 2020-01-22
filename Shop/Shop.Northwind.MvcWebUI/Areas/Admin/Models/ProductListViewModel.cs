using System.Collections.Generic;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.MvcWebUI.Areas.Admin.Models
{
    public class ProductListViewModel
    {
        public List<ProductList> GetListView { get; set; }
    }
}
