using BookstoreAPP.Models;

namespace BookstoreAPP.Repository
{
	public interface IOrderRepository
	{
		Order PlaceOrder(Order order);
		Order GetOrderById(int orderId);
	}


}
