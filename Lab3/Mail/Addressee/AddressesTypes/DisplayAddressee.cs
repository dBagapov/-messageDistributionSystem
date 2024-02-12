using Lab3.Mail.Message;

namespace Lab3.Mail.Addressee.AddressesTypes;

public class DisplayAddressee : IAddressee
{
    private readonly Display.Display _display;

    public DisplayAddressee(Display.Display display)
    {
        _display = display;
    }

    public void SendMessage(IMessage message)
    {
        var strMessage = message.Title + message.Body;
        _display.GetText(strMessage);
    }
}