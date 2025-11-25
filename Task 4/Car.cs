namespace Task_4;

public class Car : Vehicle
{
    public override void StartEngine()
    {
        System.Console.WriteLine("Car engine started");
    }

    public override void StopEngine()
    {
        System.Console.WriteLine("Car engine stopped");
    }
}