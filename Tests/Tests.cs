using Lab3.Mail.Addressee.AddressesTypes;
using Lab3.Mail.Message;
using Lab3.Mail.MessageEndpoints;
using Lab3.Mail.Topic;
using Xunit;

namespace Tests;

public static class Tests
{
    [Fact]
    public static void ReadTest()
    {
        var message = Message.Builder().WithTitle("Title").WithBody("Body")
            .WithImportanceLevel(ImportanceLevel.Low).Build();
        var user = new User("KH34");
        var userAddressee = new UserAddressee(user);
        var topic = Topic.Builder().WithName("Name").WithAddressee(userAddressee).Build();

        topic.SendMessage(message);

        Assert.True(user.Messages.ContainsKey(message));
        Assert.Equal(IsRead.No, user.Messages[message]);

        user.ReadMessage(message);
        Assert.Equal(IsRead.Yes, user.Messages[message]);

        bool isSuccess = user.ReadMessage(message);
        Assert.False(isSuccess);
    }
}