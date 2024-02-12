namespace Lab3.Messenger;

public class Messenger : IMessenger
{
    public void GetText(string text)
    {
        Console.WriteLine("Messenger:");
        Console.WriteLine(text);
    }
}