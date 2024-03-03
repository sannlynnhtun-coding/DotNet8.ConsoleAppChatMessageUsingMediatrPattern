namespace DotNet8.ConsoleAppChatMessageUsingMediatrPattern;

public class ChatMessageHandler : IRequestHandler<ChatMessage>
{
    private readonly UserRegister _userRegister;

    public ChatMessageHandler(UserRegister userRegister)
    {
        Console.WriteLine("Constructing chat message handler");
        _userRegister = userRegister;
    }

    public Task Handle(ChatMessage request, CancellationToken cancellationToken)
    {
        Console.WriteLine("Entering message handler...");

        // NOTE: this code isn't thread-safe in that someone in the future
        // could be trying to register a user while we're enumerating
        foreach (var user in _userRegister.Users)
        {
            if (user.Name != request.Sender)
            {
                user.ReceiveMessage(request.Content, request.Sender);
            }
        }

        Console.WriteLine("Exiting message handler.");
        return Task.CompletedTask;
    }
}