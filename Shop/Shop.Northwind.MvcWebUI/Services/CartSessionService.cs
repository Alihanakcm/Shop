using Microsoft.AspNetCore.Http;
using Shop.Northwind.Entities.Concrete;
using Shop.Northwind.MvcWebUI.ExtensionMethods;

namespace Shop.Northwind.MvcWebUI.Services
{
    public class CartSessionService : ICartSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObjects<Cart>("cart");
            if (cartToCheck == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObjects("cart", new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObjects<Cart>("cart");
            }

            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObjects("cart", cart);
        }
    }
}
