// See https://aka.ms/new-console-template for more information
using RabbitMQ.Client;
using System.Text;

Console.WriteLine("RabbitMQ Publisher/Sender \n");

//var factory = new ConnectionFactory { HostName = "localhost" };
var factory = new ConnectionFactory { HostName = "", Port = 5672, UserName = "user", Password = "user" };

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "hello",
                     durable: true,
                     exclusive: false,
                     autoDelete: false,
                     arguments: null);


//var message = GetMessage(args);
//var body = Encoding.UTF8.GetBytes(message);
//channel.BasicPublish(exchange: string.Empty,
//                 routingKey: "hello",
//                 basicProperties: null,
//                 body: body);
//Console.WriteLine($" [x] Sent {message}");
//Console.ReadKey();

#region Basic Hello World
Console.WriteLine("Enter message to publish/send: ");
while (1 > 0)
{

    var message = Console.ReadLine();
    var body = Encoding.UTF8.GetBytes(message);
    channel.BasicPublish(exchange: string.Empty,
                     routingKey: "hello",
                     basicProperties: null,
                     body: body);
    Console.WriteLine($" [x] Sent {message}");
}
#endregion


static string GetMessage(string[] args)
{
    return ((args.Length > 0) ? string.Join(" ", args) : "Hello World!");
}