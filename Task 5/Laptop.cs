namespace Task_5;

public class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price)
    {
    }

    public void TurnOnBattery()
    {
        System.Console.WriteLine($"{Brand}'s laptop battery is now ON.");
    }

    public override void ShowInfo()
    {
        System.Console.WriteLine($"Laptop Brand: {Brand}, Price: {Price}");
    }
}