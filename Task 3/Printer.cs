namespace Task_3;

public class Printer
{
    public void Print(string message)
    {
        System.Console.WriteLine("Message: " + message);
    }

    public void Print(int number)
    {
        System.Console.WriteLine("Number: " + number);
    }

    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            System.Console.WriteLine($"[{i + 1}] {message}");
        }
    }
}