using Lab3.Mail.Addressee;
using Lab3.Mail.Addressee.AddressesTypes;
using Lab3.Mail.Addressee.MessageLogger;
using Lab3.Mail.Message;
using Lab3.Mail.MessageEndpoints;
using Lab3.Mail.Topic;
using Lab3.Messenger;
using Moq;
using Xunit;

namespace Tests;

public static class MocksTests
{
    [Fact]
    public static void FiltrationTest()
    {
        var message = Message.Builder().WithTitle("Title").WithBody("Body")
            .WithImportanceLevel(ImportanceLevel.Low).Build();
        var addresseeMock = new Mock<IAddressee>();

        var filtrationProxy = new FiltrationProxy(addresseeMock.Object, ImportanceLevel.Medium);
        var topic = Topic.Builder().WithName("Name").WithAddressee(filtrationProxy).Build();

        topic.SendMessage(message);

        addresseeMock.Verify(x => x.SendMessage(message), Times.Never);
    }

    [Fact]
    public static void LoggingTest()
    {
        var message = Message.Builder().WithTitle("Title").WithBody("Body")
            .WithImportanceLevel(ImportanceLevel.Low).Build();
        var user = new User("KH34");
        var userAddressee = new UserAddressee(user);

        var loggerMock = new Mock<ILogger>();
        var loggingAddresseeDecorator = new LoggingAddresseeDecorator(userAddressee, loggerMock.Object);

        var topic = Topic.Builder().WithName("Name").WithAddressee(loggingAddresseeDecorator).Build();

        topic.SendMessage(message);

        loggerMock.Verify(x => x.Log(message), Times.Once);
    }

    [Fact]
    public static void MessengerTest()
    {
        var message = Message.Builder().WithTitle("Title").WithBody("Body")
            .WithImportanceLevel(ImportanceLevel.Low).Build();
        var messengerMock = new Mock<IMessenger>();
        var messengerAddressee = new MessengerAddressee(messengerMock.Object);

        var topic = Topic.Builder().WithName("Name").WithAddressee(messengerAddressee).Build();

        topic.SendMessage(message);

        var text = message.Title + message.Body;
        messengerMock.Verify(x => x.GetText(text), Times.Once);
    }
}