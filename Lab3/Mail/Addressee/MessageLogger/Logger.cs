using Lab3.Mail.Message;

namespace Lab3.Mail.Addressee.MessageLogger;

public class Logger : ILogger
{
    public IList<IMessage> Messages { get; } = new List<IMessage>();
    public void Log(IMessage message)
    {
        Messages.Add(message);
    }
}