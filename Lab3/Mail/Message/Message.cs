namespace Lab3.Mail.Message;

public class Message : IMessage
{
    public Message(string title, string body, ImportanceLevel importanceLevel)
    {
        Title = title;
        Body = body;
        ImportanceLevel = importanceLevel;
    }

    public string Title { get; }
    public string Body { get; }
    public ImportanceLevel ImportanceLevel { get;  }

    public static MessageBuilder Builder()
    {
        return new MessageBuilder();
    }

    public bool Equals(IMessage? other)
    {
        if (other == null)
        {
            return false;
        }

        return Title == other.Title && Body == other.Body;
    }
}