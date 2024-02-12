using Lab3.Mail.Message;
using Lab3.Messenger;

namespace Lab3.Mail.Addressee.AddressesTypes;

public class MessengerAddressee : IAddressee
{
    private readonly IMessenger _messenger;

    public MessengerAddressee(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void SendMessage(IMessage message)
    {
        var strMessage = message.Title + message.Body;
        _messenger.GetText(strMessage);
    }
}