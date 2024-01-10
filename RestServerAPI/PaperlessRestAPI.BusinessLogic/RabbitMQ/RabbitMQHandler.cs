using RabbitMQ.Client;
using System;
using System.Text;
using System.Web;
using System.Text.Json;


namespace PaperlessRestAPI.RabbitMQ
{
    public class RabbitMQHandler : IDisposable
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly ConnectionFactory _factory;
        public string queueName;
        private bool disposedValue;


        public RabbitMQHandler(string hostname, string username, string password, int port = 5672, string? queueName = null)
        {
            _factory = new ConnectionFactory() { HostName = hostname, UserName = username, Password = password, Port = port };
            _connection = _factory.CreateConnection();
            _channel = _connection.CreateModel();
            this.queueName = queueName;
            CreateQueue(queueName);
        }
        public RabbitMQHandler(IConnection connection, IModel channel, ConnectionFactory factory , string? queueName = null)
        {
            _connection = connection;
            _channel = channel;
            _factory = factory;
            this.queueName = queueName;
            CreateQueue(queueName);
        }

        public void CreateQueue(string queueName)
        {
            _channel.QueueDeclare(queue: queueName,
               durable: true,
               exclusive: false,
               autoDelete: false,
               arguments: null);

        }

        public void DeleteQueueAsync(string queueName)
        {
            _channel.QueueDelete(queueName);
        }

        private void RabbitMQ_ConnectionShutdown(object? sender, ShutdownEventArgs e)
        {
            _connection.Close();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._connection.Dispose();
                    this._channel.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void send(string body, Guid documentId)
        {

            //var factory = new ConnectionFactory { HostName = "localhost" };
            // using var connection = factory.CreateConnection();
            //using var channel = connection.CreateModel();

            IBasicProperties properties = _channel.CreateBasicProperties();
            properties.CorrelationId = documentId.ToString();

            _channel.BasicPublish(exchange: string.Empty,
                                 routingKey: queueName,
                                 basicProperties: properties,
                                 body: System.Text.Encoding.UTF8.GetBytes(body));
        }

        public Task EnqueueAsync<T>( T messageObject)
        {
            var messageBody = JsonSerializer.Serialize(messageObject);
            var body = Encoding.UTF8.GetBytes(messageBody);
            _channel.BasicPublish(exchange: string.Empty, routingKey: queueName, basicProperties: null, body: body);
            return Task.CompletedTask;
        }
    }
}

public class RabbitMQOptions
{
    public required string Hostname { get; set; }
    public int Port { get; set; } = 5672;
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string queueName { get; set; }
}