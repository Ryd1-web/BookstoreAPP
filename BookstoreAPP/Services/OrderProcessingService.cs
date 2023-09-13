namespace BookstoreAPP.Services
{
	public class OrderProcessingService
	{
		private readonly IOrderService _orderService;
		private readonly IMessageQueue _messageQueue;

		public OrderProcessingService(IOrderService orderService, IMessageQueue messageQueue)
		{
			_orderService = orderService;
			_messageQueue = messageQueue;
		}

		//public void StartListening()
		//{
		//	_messageQueue.Subscribe("order_queue", (message) =>
		//	{
		//		// Process the order
		//		var orderId = _orderService.ProcessOrder(message);
		//		Console.WriteLine($"Order processed: {orderId}");
		//	});
		//}
	}

}
