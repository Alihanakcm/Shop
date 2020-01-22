using System.Collections.Generic;
using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> cartLines(Cart cart);
    }
}
