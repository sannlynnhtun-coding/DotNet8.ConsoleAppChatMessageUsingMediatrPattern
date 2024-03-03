namespace DotNet8.ConsoleAppChatMessageUsingMediatrPattern;

public class ChatMessage : IRequest
{
    public string Sender { get; }
    public string Content { get; }

    public ChatMessage(string sender, string content)
    {
        Sender = sender;
        Content = content;
    }
}