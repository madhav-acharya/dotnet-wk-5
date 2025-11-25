namespace Task_2;

public class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void Start()
    {
        Console.WriteLine($"{Brand} started moving at {Speed} km/h.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} has stopped.");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}