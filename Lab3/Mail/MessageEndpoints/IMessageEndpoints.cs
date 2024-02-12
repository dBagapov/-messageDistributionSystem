using Lab3.Mail.Message;

namespace Lab3.Mail.MessageEndpoints;

public interface IMessageEndpoints
{
    void GetMessage(IMessage message);
}