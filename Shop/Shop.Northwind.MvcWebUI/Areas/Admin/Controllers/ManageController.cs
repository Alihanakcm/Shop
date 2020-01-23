using System;
using Microsoft.AspNetCore.Mvc;
using Shop.Northwind.Business.Abstract;
using Shop.Northwind.Entities.Concrete;
using Shop.Northwind.MvcWebUI.Areas.Admin.Models;


namespace Shop.Northwind.MvcWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManageController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public ManageController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            ProductListViewModel model = new ProductListViewModel
            {
                GetListView = _productService.GetProductDetails()
            };
            return View(model);
        }

        public ActionResult Add()
        {
            ProductAddViewModel model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempDataControl();
                TempData.Add("Add", String.Format("{0}, is added", product.ProductName));
            }

            return RedirectToAction("Index");
        }

        public ActionResult Update(int productId)
        {
            UpdateViewModel model = new UpdateViewModel
            {
                Product = _productService.GetById(productId),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                TempDataControl();
                TempData.Add("update", String.Format("{0}, is updated", product.ProductName));
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int productId)
        {
            _productService.Delete(productId);
            TempDataControl();
            TempData.Add("delete", "Product deleted!");
            return RedirectToAction("Index");
        }

        private void TempDataControl()
        {
            if (TempData.ContainsKey("delete") || TempData.ContainsKey("add") || TempData.ContainsKey("update"))
            {
                TempData.Remove("add");
                TempData.Remove("delete");
                TempData.Remove("update");
            }
        }

        public ActionResult Categories()
        {
            CategoryListViewModel model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        public ActionResult DeleteCategory(int categoryId)
        {
            _categoryService.Delete(categoryId);
            TempDataControl();
            TempData.Add("delete", "Category deleted!");
            return RedirectToAction("Categories");
        }

        public ActionResult AddCategory()
        {
            CategoryAddViewModel model=new CategoryAddViewModel
            {
                Category=new Category()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(category);
                TempDataControl();
                TempData.Add("add", String.Format("{0}, is added", category.CategoryName));
            }

            return RedirectToAction("Categories");
        }
    }
}
