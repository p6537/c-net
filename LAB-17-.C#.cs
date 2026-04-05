using System;

// Interface for Pass check
interface IPass
{
    bool Pass(int mark);
}

// Interface for Division check
interface IDivision
{
    string Division(int average);
}

// Class implementing both interfaces
class Result : IPass, IDivision
{
    public bool Pass(int mark)
    {
        return mark >= 50;
    }

    public string Division(int average)
    {
        if (average >= 60)
            return "First Division";
        else if (average >= 50)
            return "Second Division";
        else if (average >= 40)
            return "Third Division";
        else
            return "Fail";
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Result r = new Result();

        Console.Write("Enter Marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pass Status: " + r.Pass(marks));

        Console.Write("Enter Average Marks: ");
        int avg = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Division: " + r.Division(avg));
    }
}