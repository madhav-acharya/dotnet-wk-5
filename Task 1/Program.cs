// See https://aka.ms/new-console-template for more information

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("ACC1001", 1000);

            Console.WriteLine("Account Number: " + acc.AccountNumber);
            Console.WriteLine("Opening Balance: " + acc.Balance);

            acc.Deposit(500);
            Console.WriteLine("Balance after deposit: " + acc.Balance);

            acc.Withdraw(3000);
            Console.WriteLine("Balance after withdrawal: " + acc.Balance);
        }
    }
}
