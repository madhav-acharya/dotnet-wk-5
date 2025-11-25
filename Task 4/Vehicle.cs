namespace Task_4;

public abstract class Vehicle
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Display()
    {
        System.Console.WriteLine("This is a vehicle");
    }
}