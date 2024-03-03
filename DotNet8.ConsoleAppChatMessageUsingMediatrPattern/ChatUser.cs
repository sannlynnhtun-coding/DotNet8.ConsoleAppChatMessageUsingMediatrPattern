namespace DotNet8.ConsoleAppChatMessageUsingMediatrPattern;

public class ChatUser(IMediator mediator, string name)
{
    public string Name { get; } = name;

    public async Task SendMessage(string message)
    {
        await mediator.Send(new ChatMessage(Name, message));
    }

    public void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"{Name} received message from {sender}: {message}");
    }
}