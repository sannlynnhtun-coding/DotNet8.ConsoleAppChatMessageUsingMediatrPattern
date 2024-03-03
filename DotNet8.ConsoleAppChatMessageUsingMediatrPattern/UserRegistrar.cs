public class UserRegistrar
{
    private readonly List<ChatUser> _users;

    public UserRegistrar()
    {
        _users = new List<ChatUser>();
    }

    public IReadOnlyList<ChatUser> Users => _users;

    public void RegisterUser(ChatUser user)
    {
        _users.Add(user);
    }
}