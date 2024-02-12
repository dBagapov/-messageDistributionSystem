using Lab3.Mail.Message;

namespace Lab3.Mail.Addressee;

public interface IAddressee
{
    void SendMessage(IMessage message);
}