// See https://aka.ms/new-console-template for more information

namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Car();
        Vehicle bike = new Bike();

        // Car demonstration
        car.Display();
        car.StartEngine();
        car.StopEngine();

        System.Console.WriteLine();

        // Bike demonstration
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();
    }
}
