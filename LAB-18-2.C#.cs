using System;

class TryCatchFinallyDemo
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Enter array index (0-4): ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value = " + numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Invalid array index!");
        }
        finally
        {
            Console.WriteLine("Finally block always executes.");
        }

        Console.WriteLine("Program finished.");
    }
}