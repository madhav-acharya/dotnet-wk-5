// See https://aka.ms/new-console-template for more information

namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        // Printer demonstration
        Printer printer = new Printer();
        printer.Print("Hello World");
        printer.Print(12345);
        printer.Print("Repeat this message", 3);

        System.Console.WriteLine("\n--- Teacher Demonstration ---\n");

        // Teacher demonstration
        NepaliTeacher nepaliTeacher = new NepaliTeacher { Name = "Ram" };
        EnglishTeacher englishTeacher = new EnglishTeacher { Name = "John" };

        System.Console.WriteLine($"{nepaliTeacher.Name}:");
        nepaliTeacher.Teaching();
        nepaliTeacher.SalaryInfo();

        System.Console.WriteLine($"\n{englishTeacher.Name}:");
        englishTeacher.Teaching();
        englishTeacher.SalaryInfo();
    }
}
