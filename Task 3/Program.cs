// See https://aka.ms/new-console-template for more information

namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        Printer printer = new Printer();

        printer.Print("Hello World");
        printer.Print(12345);
        printer.Print("Hello world from loop", 4);
    }
}