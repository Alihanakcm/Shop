using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Shop.Northwind.MvcWebUI.Services;

namespace Shop.Northwind.MvcWebUI.ViewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var cartSummaryViewModel = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(cartSummaryViewModel);
        }
    }
}
