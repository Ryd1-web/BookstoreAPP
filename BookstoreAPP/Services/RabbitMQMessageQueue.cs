namespace BookstoreAPP.Services
{
	using RabbitMQ.Client;
	using RabbitMQ.Client.Events;
	using System;
	using System.Text;

	public class RabbitMQMessageQueue : IMessageQueue
	{
		private readonly IConnection _connection;
		private readonly IModel _channel;

		public RabbitMQMessageQueue(string hostname, string username, string password)
		{
			var factory = new ConnectionFactory
			{
				HostName = hostname,
				UserName = username,
				Password = password
			};

			_connection = factory.CreateConnection();
			_channel = _connection.CreateModel();
		}

		public void Publish(string queueName, string message)
		{
			_channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

			var body = Encoding.UTF8.GetBytes(message);

			_channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: body);
		}

		public void Subscribe(string queueName, Action<string> messageHandler)
		{
			_channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

			var consumer = new EventingBasicConsumer(_channel);
			consumer.Received += (model, ea) =>
			{
				var body = ea.Body.ToArray();
				var message = Encoding.UTF8.GetString(body);
				messageHandler(message);
			};

			_channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
		}

		public void Unsubscribe(string queueName)
		{
			// Implement unsubscribe logic if needed
		}
	}

}
