using Lab3.Mail.Addressee;
using Lab3.Mail.Message;

namespace Lab3.Mail.Topic;

public class Topic : ITopic
{
    public Topic(string name, IAddressee addressee)
    {
        Name = name;
        Addressee = addressee;
    }

    public string Name { get; }
    public IAddressee Addressee { get; }

    public static TopicBuilder Builder()
    {
        return new TopicBuilder();
    }

    public void SendMessage(IMessage message)
    {
        Addressee.SendMessage(message);
    }
}