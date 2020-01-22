using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Northwind.Business.Abstract;
using Shop.Northwind.MvcWebUI.Models;

namespace Shop.Northwind.MvcWebUI.Controllers
{
    [Authorize(Roles = "User")]
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page = 1, int pageSize = 10, int category = 0)
        {
            var _products = _productService.GetbyCategory(category);
            var productListViewModel = new ProductListViewModel
            {
                Products = _products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                CurrentPage = page,
                PageSize = pageSize,
                CurrentCategory = category,
                PageCount = (int)Math.Ceiling(_products.Count / (double)pageSize)
            };
            return View(productListViewModel);
        }

        [HttpPost]
        public ActionResult Index(string key = "")
        {
            if (String.IsNullOrEmpty(key))
            {
                return RedirectToAction("Index");
            }
            var productListViewModel = new ProductListViewModel { Products = _productService.GetByKey(key) };
            return View(productListViewModel);

        }
    }
}
