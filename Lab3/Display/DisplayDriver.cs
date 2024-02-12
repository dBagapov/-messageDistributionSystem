namespace Lab3.Display;

public class DisplayDriver
{
    private ConsoleColor _color = ConsoleColor.White;

    public static void ConsoleClear()
    {
        Console.Clear();
    }

    public void SetColor(ConsoleColor color)
    {
        _color = color;
    }

    public void Print(string text)
    {
        Console.ForegroundColor = _color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}