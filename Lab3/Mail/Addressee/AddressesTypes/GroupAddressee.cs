using Lab3.Mail.Message;

namespace Lab3.Mail.Addressee.AddressesTypes;

public class GroupAddressee : IAddressee
{
    private readonly IReadOnlyCollection<IAddressee> _addressees;

    public GroupAddressee(IReadOnlyCollection<IAddressee> addressees)
    {
        _addressees = addressees;
    }

    public void SendMessage(IMessage message)
    {
        foreach (IAddressee addressee in _addressees)
        {
            addressee.SendMessage(message);
        }
    }
}