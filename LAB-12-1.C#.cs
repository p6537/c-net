using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[8];
        int positive = 0, negative = 0;

        Console.WriteLine("Enter 8 numbers:");

        // Input
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Count positive and negative
        for (int i = 0; i < 8; i++)
        {
            if (numbers[i] > 0)
                positive++;
            else if (numbers[i] < 0)
                negative++;
        }

        Console.WriteLine("Positive numbers: " + positive);
        Console.WriteLine("Negative numbers: " + negative);
    }
}