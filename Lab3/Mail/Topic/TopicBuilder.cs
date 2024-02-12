using Lab3.Mail.Addressee;

namespace Lab3.Mail.Topic;

public class TopicBuilder
{
    private string? _name;
    private IAddressee? _addressee;

    public TopicBuilder(ITopic? topic = null)
    {
        if (topic == null) return;

        _name = topic.Name;
        _addressee = topic.Addressee;
    }

    public TopicBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public TopicBuilder WithAddressee(IAddressee addressee)
    {
        _addressee = addressee;
        return this;
    }

    public Topic Build()
    {
        return new Topic(
            _name ?? throw new ArgumentNullException(nameof(_name)),
            _addressee ?? throw new ArgumentNullException(nameof(_addressee)));
    }
}