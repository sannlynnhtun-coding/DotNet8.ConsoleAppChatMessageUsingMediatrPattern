namespace DotNet8.ConsoleAppChatMessageUsingMediatrPattern;

public class UserRegister
{
    private readonly List<ChatUser> _users;

    public UserRegister()
    {
        _users = new List<ChatUser>();
    }

    public IReadOnlyList<ChatUser> Users => _users;

    public void RegisterUser(ChatUser user)
    {
        _users.Add(user);
    }
}