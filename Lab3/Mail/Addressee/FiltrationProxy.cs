using Lab3.Mail.Message;

namespace Lab3.Mail.Addressee;

public class FiltrationProxy : IAddressee
{
    private readonly IAddressee _addressee;
    private readonly ImportanceLevel _minImportanceLevel;

    public FiltrationProxy(IAddressee addressee, ImportanceLevel minImportanceLevel)
    {
        _addressee = addressee;
        _minImportanceLevel = minImportanceLevel;
    }

    public void SendMessage(IMessage message)
    {
        if (_minImportanceLevel <= message.ImportanceLevel)
        {
            _addressee.SendMessage(message);
        }
    }
}