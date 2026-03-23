using System;

class Account
{
    protected int accountNumber;
    protected string name;
    protected double balance;

    // Constructor
    public Account(int accNo, string n, double bal)
    {
        accountNumber = accNo;
        name = n;
        balance = bal;
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    // Virtual Withdraw Method
    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    // Display Method
    public void Display()
    {
        Console.WriteLine("Account No: " + accountNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Balance: " + balance);
    }
}

// Derived Class: SavingsAccount
class SavingsAccount : Account
{
    double interestRate;

    public SavingsAccount(int accNo, string n, double bal, double rate)
        : base(accNo, n, bal)
    {
        interestRate = rate;
    }

    public void AddInterest()
    {
        double interest = balance * interestRate / 100;
        balance += interest;
        Console.WriteLine("Interest Added: " + interest);
    }

    // Overriding Withdraw
    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Savings: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance in Savings!");
        }
    }
}

// Derived Class: CurrentAccount
class CurrentAccount : Account
{
    double overdraftLimit;

    public CurrentAccount(int accNo, string n, double bal, double limit)
        : base(accNo, n, bal)
    {
        overdraftLimit = limit;
    }

    // Overriding Withdraw
    public override void Withdraw(double amount)
    {
        if (amount <= (balance + overdraftLimit))
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Current: " + amount);
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded!");
        }
    }
}

// Main Class
class Program
{
    static void Main()
    {
        // Savings Account
        SavingsAccount s = new SavingsAccount(101, "Prince", 5000, 5);
        s.Deposit(1000);
        s.Withdraw(2000);
        s.AddInterest();
        s.Display();

        Console.WriteLine();

        // Current Account
        CurrentAccount c = new CurrentAccount(102, "Kumar", 3000, 2000);
        c.Deposit(500);
        c.Withdraw(4000);
        c.Display();
    }
}