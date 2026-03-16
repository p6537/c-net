using System;

class LoanEligibility
{
    static void Main()
    {
        int age;
        double income;
        int creditScore;

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Monthly Income: ");
        income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Credit Score: ");
        creditScore = Convert.ToInt32(Console.ReadLine());

        if (age >= 21)
        {
            if (income >= 25000)
            {
                if (creditScore >= 700)
                {
                    Console.WriteLine("You are eligible for the loan.");
                }
                else
                {
                    Console.WriteLine("Not eligible: Credit score is too low.");
                }
            }
            else
            {
                Console.WriteLine("Not eligible: Income is too low.");
            }
        }
        else
        {
            Console.WriteLine("Not eligible: Age must be at least 21.");
        }
    }
}