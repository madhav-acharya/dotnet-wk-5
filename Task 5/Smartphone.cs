namespace Task_5;

public class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price)
    {
    }

    public void EnableCamera()
    {
        System.Console.WriteLine($"{Brand}'s smartphone camera is now ENABLED.");
    }

    public override void ShowInfo()
    {
        System.Console.WriteLine($"Smartphone Brand: {Brand}, Price: {Price}");
    }
}