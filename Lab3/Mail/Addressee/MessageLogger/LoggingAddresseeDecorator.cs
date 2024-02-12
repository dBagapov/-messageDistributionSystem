using Lab3.Mail.Message;

namespace Lab3.Mail.Addressee.MessageLogger;

public class LoggingAddresseeDecorator : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly ILogger _logger;
    public LoggingAddresseeDecorator(IAddressee addressee, ILogger? logger)
    {
        _addressee = addressee;
        _logger = logger ?? new Logger();
    }

    public void SendMessage(IMessage message)
    {
        _logger.Log(message);
        _addressee.SendMessage(message);
    }
}