namespace Lab3.Mail.Message;

public interface IMessage : IEquatable<IMessage>
{
    string Title { get; }
    string Body { get; }
    ImportanceLevel ImportanceLevel { get;  }
}