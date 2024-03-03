namespace DotNet8.ConsoleAppChatMessageUsingMediatrPattern;

public class ChatUser
{
    private readonly IMediator _mediator;

    public string Name { get; }

    public ChatUser(IMediator mediator, string name)
    {
        _mediator = mediator;
        this.Name = name;
    }

    public async Task SendMessage(string message)
    {
        await _mediator.Send(new ChatMessage(Name, message));
    }

    public void ReceiveMessage(string message, string sender)
    {
        Console.WriteLine($"{Name} received message from {sender}: {message}");
    }
}