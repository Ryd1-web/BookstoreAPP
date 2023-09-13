namespace BookstoreAPP.Services
{
	public class InventoryManagementService
	{
		private readonly IInventoryService _inventoryService;
		private readonly IMessageQueue _messageQueue;

		public InventoryManagementService(IInventoryService inventoryService, IMessageQueue messageQueue)
		{
			_inventoryService = inventoryService;
			_messageQueue = messageQueue;
		}

		public void StartListening()
		{
			_messageQueue.Subscribe("inventory_queue", (message) =>
			{
				// Update inventory
				//_inventoryService.UpdateInventory(message);
				Console.WriteLine("Inventory updated");
			});
		}
	}
}
