using Shop.Northwind.Entities.Concrete;

namespace Shop.Northwind.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
