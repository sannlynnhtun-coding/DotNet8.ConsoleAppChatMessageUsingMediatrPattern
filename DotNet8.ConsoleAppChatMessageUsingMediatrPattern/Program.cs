using DotNet8.ConsoleAppChatMessageUsingMediatrPattern;

Console.WriteLine("Creating services...");

var services = new ServiceCollection();
services.AddScoped<ChatMessageHandler>();
services.AddSingleton<UserRegister>();
services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});

var serviceProvider = services.BuildServiceProvider();

var mediator = serviceProvider.GetRequiredService<IMediator>();
var handler = serviceProvider.GetRequiredService<ChatMessageHandler>();
var userRegistrar = serviceProvider.GetRequiredService<UserRegister>();

ChatUser user1 = new ChatUser(mediator, "User 1");
ChatUser user2 = new ChatUser(mediator, "User 2");
ChatUser user3 = new ChatUser(mediator, "User 3");

userRegistrar.RegisterUser(user1);
userRegistrar.RegisterUser(user2);
userRegistrar.RegisterUser(user3);

Console.WriteLine("Sending first message...");
await user1.SendMessage("Hello, everyone!");

Console.WriteLine("Sending second message...");
await user1.SendMessage("Hello again, everyone!");