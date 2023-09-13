using BookstoreAPP.Models;

namespace BookstoreAPP.Services
{
    public interface IOrderService
    {
        int PlaceOrder(Order order);
        Order GetOrderById(int orderId);
	}

}
