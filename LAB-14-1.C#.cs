using System;

class Student
{
    // Instance variables
    int rollNo;
    string name;
    double marks;

    // Default Constructor
    public Student()
    {
        rollNo = 0;
        name = "Not Assigned";
        marks = 0;
    }

    // Parameterized Constructor
    public Student(int r, string n, double m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

    // Method to calculate grade
    public string CalculateGrade()
    {
        if (marks >= 80)
            return "A";
        else if (marks >= 60)
            return "B";
        else if (marks >= 40)
            return "C";
        else
            return "Fail";
    }

    // Method to display student details
    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + CalculateGrade());
        Console.WriteLine("---------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using Default Constructor
        Student s1 = new Student();
        Console.WriteLine("Default Constructor Output:");
        s1.Display();

        // Using Parameterized Constructor
        Student s2 = new Student(101, "Rahul", 75);
        Console.WriteLine("Parameterized Constructor Output:");
        s2.Display();

        Student s3 = new Student(102, "Priya", 85);
        s3.Display();
    }
}