using System.Collections.Generic;
using System.Linq;
using Shop.Northwind.Business.Abstract;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(p => p.Product.ProductId == product.ProductId);
            if (cartLine == null)
            {
                cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
                return;
            }
            cartLine.Quantity++;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(p => p.Product.ProductId == productId));
        }

        public List<CartLine> cartLines(Cart cart)
        {
            return cart.CartLines;
        }
    }
}
