using Lab3.Mail.Message;

namespace Lab3.Mail.MessageEndpoints;

public class User : IMessageEndpoints
{
    public User(string id)
    {
        Id = id;
        Messages = new Dictionary<IMessage, IsRead>();
    }

    public string Id { get; }
    public IDictionary<IMessage, IsRead> Messages { get; }

    public bool ReadMessage(IMessage message)
    {
        if (!Messages.ContainsKey(message) || Messages[message] == IsRead.Yes)
        {
            return false;
        }

        Messages[message] = IsRead.Yes;
        return true;
    }

    public void GetMessage(IMessage message)
    {
        Messages[message] = IsRead.No;
    }
}
