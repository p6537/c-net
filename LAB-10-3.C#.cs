using System;

class ATM
{
    static void Main()
    {
        int correctPin = 1234;
        int pin;
        double balance = 10000;
        double withdraw;

        Console.Write("Enter PIN: ");
        pin = Convert.ToInt32(Console.ReadLine());

        if (pin == correctPin)
        {
            Console.Write("Enter amount to withdraw: ");
            withdraw = Convert.ToDouble(Console.ReadLine());

            if (withdraw <= balance)
            {
                balance = balance - withdraw;
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine("Remaining Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }
        else
        {
            Console.WriteLine("Incorrect PIN.");
        }
    }
}