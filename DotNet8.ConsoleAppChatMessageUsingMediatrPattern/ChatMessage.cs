namespace DotNet8.ConsoleAppChatMessageUsingMediatrPattern;

public class ChatMessage(string sender, string content) : IRequest
{
    public string Sender { get; } = sender;
    public string Content { get; } = content;
}