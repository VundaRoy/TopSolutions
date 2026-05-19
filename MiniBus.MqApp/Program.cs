using Microsoft.Extensions.DependencyInjection;
using Xunit.Sdk;

var services = new ServiceCollection();

// Register your mini bus + consumers
services.AddSingleton<MessageBus>();
services.AddTransient<IConsumer<OrderSubmitted>, OrderSubmittedConsumer>();

var provider = services.BuildServiceProvider();

var bus = provider.GetRequiredService<MessageBus>();

await bus.Publish(new OrderSubmitted
{
    OrderId = Guid.NewGuid()
});

Console.WriteLine("Done. Press any key...");
Console.ReadKey();
