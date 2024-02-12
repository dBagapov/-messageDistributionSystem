namespace Lab3.Display;

public class Display
{
    private readonly DisplayDriver _displayDriver;

    public Display(DisplayDriver displayDriver)
    {
        _displayDriver = displayDriver;
    }

    public void SetColor(ConsoleColor color)
    {
        _displayDriver.SetColor(color);
    }

    public void GetText(string text)
    {
        DisplayDriver.ConsoleClear();
        _displayDriver.Print(text);
    }
}