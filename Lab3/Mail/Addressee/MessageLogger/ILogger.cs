using Lab3.Mail.Message;

namespace Lab3.Mail.Addressee.MessageLogger;

public interface ILogger
{
    void Log(IMessage message);
}