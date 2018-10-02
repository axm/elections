using RabbitMQ.Client;
using System;
using System.Linq;
using System.Text;

namespace Spartan.Elections.ThrowawayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory { };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "hello",
                     durable: false,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);

                    string message = "Hello World!";
                    var body = Encoding.UTF8.GetBytes(message);

                    foreach (var item in Enumerable.Range(1, 100))
                    {

                        channel.BasicPublish(exchange: "",
                                             routingKey: "hello",
                                             basicProperties: null,
                                             body: body);
                    }
                    Console.WriteLine(" [x] Sent {0}", message);
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
