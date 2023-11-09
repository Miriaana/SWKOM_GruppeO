using RabbitMQ.Client;
using System;
using System.Text;
using System.Web;

namespace PaperlessRestAPI.RabbitMQ
{
    public class RabbitMQHandler
    {
        protected IConnection RabbitMqConnection;
        protected IModel RabbitMqChannel;
        private readonly string _url;
        protected string QueueName;
        protected string ExchangeName;
        private bool disposedValue;


        public RabbitMQHandler()
        {
           
            QueueName = "TestQueue";
            ExchangeName = string.Empty;

            // factory.Uri = new Uri("amqp://guest:guest@localhost:5672/vhost");
            InitRabbitMQ();
        }

        private void InitRabbitMQ()
        {
            var factory = new ConnectionFactory { HostName = "localhost" };

            // create connection  
            RabbitMqConnection = factory.CreateConnection();

            //factory.Uri = new Uri("amqp://guest:guest@localhost:5672/vhost");

            // create channel  
            RabbitMqChannel = RabbitMqConnection.CreateModel();

            //RabbitMqChannel.ExchangeDeclare(ExchangeName, ExchangeType.Topic);
           
            RabbitMqConnection.ConnectionShutdown += RabbitMQ_ConnectionShutdown;
        }

        private void RabbitMQ_ConnectionShutdown(object? sender, ShutdownEventArgs e)
        {
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.RabbitMqConnection.Dispose();
                    this.RabbitMqChannel.Dispose();
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

            IBasicProperties properties = RabbitMqChannel.CreateBasicProperties();
            properties.CorrelationId = documentId.ToString();

            RabbitMqChannel.QueueDeclare(queue: QueueName,
                                 durable: true,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            //const string message = "Hello World!";
            //var body = Encoding.UTF8.GetBytes(message);

            RabbitMqChannel.BasicPublish(exchange: string.Empty,
                                 routingKey: "TestQueue",
                                 basicProperties: properties,
                                 body: System.Text.Encoding.UTF8.GetBytes(body));
        }
    }
}
