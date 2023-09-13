namespace BookstoreAPP.Services
{
	public interface IMessageQueue
	{
		void Publish(string queueName, string message);
		void Subscribe(string queueName, Action<string> messageHandler);
		void Unsubscribe(string queueName);
	}

}
