namespace Task_4;

public class Bike : Vehicle
{
    public override void StartEngine()
    {
        System.Console.WriteLine("Bike engine started");
    }

    public override void StopEngine()
    {
        System.Console.WriteLine("Bike engine stopped");
    }
}