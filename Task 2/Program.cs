// See https://aka.ms/new-console-template for more information

namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", 120, 5);
        Motorcycle bike = new Motorcycle("Harley-Davidson", 100, false);

        Console.WriteLine("Car Info:");
        car.DisplayInfo();
        car.Start();
        car.Stop();

        Console.WriteLine("\nMotorcycle Info:");
        bike.DisplayInfo();
        bike.Start();
        bike.Stop();
    }
}