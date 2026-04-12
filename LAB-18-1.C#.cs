using System;

class TryCatchDemo
{
    static void Main()
    {
        int a, b, result;

        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        try
        {
            result = a / b;   // risky code
            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }

        Console.WriteLine("Program ended.");
    }
}