using System;

// Interface 1
interface Exam
{
    bool Pass(int mark);
}

// Interface 2
interface Classify
{
    string Division(int average);
}

// Class implementing both interfaces
class Result : Exam, Classify
{
    // Implementation of Pass method
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }

    // Implementation of Division method
    public string Division(int average)
    {
        if (average >= 60)
            return "First";
        else if (average >= 50 && average < 60)
            return "Second";
        else
            return "No division";
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

        Console.Write("Enter Average: ");
        int avg = Convert.ToInt32(Console.ReadLine());

        // Check Pass/Fail
        bool result = r.Pass(marks);
        if (result)
            Console.WriteLine("Result : Pass");
        else
            Console.WriteLine("Result : Fail");

        // Display Division
        Console.WriteLine("Division : " + r.Division(avg));
    }
}