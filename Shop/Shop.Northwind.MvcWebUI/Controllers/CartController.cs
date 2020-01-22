using System;
using Microsoft.AspNetCore.Mvc;
using Shop.Northwind.Business.Abstract;
using Shop.Northwind.Entities.Concrete;
using Shop.Northwind.MvcWebUI.Services;

namespace Shop.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            if (TempData.ContainsKey("message"))
                TempData.Remove("message");
            var product = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, product);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("{0},succesfully added to your cart", product.ProductName));
            return RedirectToAction("Index", "Home");
        }

        public ActionResult List()
        {
            var cartSummaryViewModel = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart(),
            };
            return View(cartSummaryViewModel);
        }

        public ActionResult RemoveFromCart(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            return RedirectToAction("List");
        }
        public ActionResult CompleteShopping()
        {
            var shippingdetailsViewModel = new ShippinDetailsviewModel
            {
                ShippingDetail = new ShippingDetails()
            };
            return View(shippingdetailsViewModel);
        }

        [HttpPost]
        public ActionResult completeShopping(ShippinDetailsviewModel shippinDetailsViewModel)
        {
            if (!(ModelState.IsValid) || shippinDetailsViewModel.ShippingDetail.CheckMeOut == false)
            {
                TempData.Add("checkBox", "Please checked the checkbox!");
                return View();
            }
            TempData.Add("message", String.Format("Thank you {0}, your order is in the process", shippinDetailsViewModel.ShippingDetail.FirstName));
            return View();
        }
    }
}
