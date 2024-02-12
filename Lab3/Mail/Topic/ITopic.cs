using Lab3.Mail.Addressee;
using Lab3.Mail.Message;

namespace Lab3.Mail.Topic;

public interface ITopic
{
    string Name { get; }
    IAddressee Addressee { get; }

    void SendMessage(IMessage message);
}