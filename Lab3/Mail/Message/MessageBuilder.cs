namespace Lab3.Mail.Message;

public class MessageBuilder
{
    private string? _title;
    private string? _body;
    private ImportanceLevel? _importanceLevel;

    public MessageBuilder(IMessage? message = null)
    {
        if (message == null) return;

        _title = message.Title;
        _body = message.Body;
        _importanceLevel = message.ImportanceLevel;
    }

    public MessageBuilder WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public MessageBuilder WithBody(string body)
    {
        _body = body;
        return this;
    }

    public MessageBuilder WithImportanceLevel(ImportanceLevel importanceLevel)
    {
        _importanceLevel = importanceLevel;
        return this;
    }

    public Message Build()
    {
        return new Message(
            _title ?? throw new ArgumentNullException(nameof(_title)),
            _body ?? throw new ArgumentNullException(nameof(_body)),
            _importanceLevel ?? throw new ArgumentNullException(nameof(_importanceLevel)));
    }
}