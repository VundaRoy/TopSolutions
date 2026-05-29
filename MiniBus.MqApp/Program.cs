using Microsoft.Extensions.DependencyInjection;
using MiniBus.MqApp.Consumers;
using MiniBus.MqApp.Core;
using MiniBus.MqApp.Messages;

var services = new ServiceCollection();

// Register your mini bus + consumers
services.AddTransient<RetryExecutor>();
services.AddSingleton<MessageBus>();
services.AddTransient<IConsumer<OrderSubmitted>, OrderSubmittedConsumer>();

var provider = services.BuildServiceProvider();

var bus = provider.GetRequiredService<MessageBus>();

bus.Start();  // start background queue processing

bus.Publish(new OrderSubmitted { OrderId = Guid.NewGuid(), Name = "Sample Order", Description = "This is a sample order." });

Console.ReadLine();

//Commented out this section to demonstrate that messages are now enqueued for processing instead of being processed immediately when Publish is called.
//The background task will process the messages from the queue and dispatch them to the appropriate consumers.
//await bus.Publish(new OrderSubmitted
//{
//    OrderId = Guid.NewGuid()
//});

//Console.WriteLine("Done. Press any key...");
//Console.ReadKey();
