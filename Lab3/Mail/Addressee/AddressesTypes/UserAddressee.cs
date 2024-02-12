using Lab3.Mail.Message;
using Lab3.Mail.MessageEndpoints;

namespace Lab3.Mail.Addressee.AddressesTypes;

public class UserAddressee : IAddressee
{
    private readonly User _user;

    public UserAddressee(User user)
    {
        _user = user;
    }

    public void SendMessage(IMessage message)
    {
        _user.GetMessage(message);
    }
}