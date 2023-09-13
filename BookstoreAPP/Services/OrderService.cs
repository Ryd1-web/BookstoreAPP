using BookstoreAPP.Models;
using BookstoreAPP.Repository;

namespace BookstoreAPP.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public int PlaceOrder(Order order)
        {
            // Perform order processing logic here
            var neworder = new Order
            {
                UserId = order.UserId,
                BookId = order.BookId,
                Quantity = order.Quantity,
                // Other order properties
            };

            _orderRepository.PlaceOrder(order);
            return order.Id;
        }

        public Order GetOrderById(int orderId)
        {
            return _orderRepository.GetOrderById(orderId);
        }
    }


}
