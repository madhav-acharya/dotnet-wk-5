namespace Task_1;

public class BankAccount
{
    private string accountNumber;
    private double balance;

    public string AccountNumber => accountNumber;

    public double Balance
    {
        get => balance;
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Balance cannot be zero or negative.");
            balance = value;
        }
    }

    public BankAccount(string accountNumber, double balance)
    {
        if (string.IsNullOrWhiteSpace(accountNumber))
            throw new ArgumentException("Invalid account number.");

        if (balance <= 0)
            throw new ArgumentException("Opening balance must be greater than zero.");

        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be greater than zero.");
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be greater than zero.");
        if (amount > balance)
            throw new InvalidOperationException("Insufficient funds.");
        balance -= amount;
    }
}