using System;

class Employee
{
    // Instance variables
    int employeeId;
    string name;
    double salary; // monthly salary

    // Default Constructor
    public Employee()
    {
        employeeId = 0;
        name = "Not Assigned";
        salary = 0;
    }

    // Parameterized Constructor
    public Employee(int id, string n, double sal)
    {
        employeeId = id;
        name = n;
        salary = sal;
    }

    // Method to calculate annual salary
    public double CalculateAnnualSalary()
    {
        return salary * 12;
    }

    // Method to display employee details
    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Monthly Salary: " + salary);
        Console.WriteLine("Annual Salary: " + CalculateAnnualSalary());
        Console.WriteLine("----------------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using Default Constructor
        Employee e1 = new Employee();
        Console.WriteLine("Default Constructor Output:");
        e1.Display();

        // Using Parameterized Constructor
        Employee e2 = new Employee(101, "Amit", 25000);
        Console.WriteLine("Parameterized Constructor Output:");
        e2.Display();

        Employee e3 = new Employee(102, "Neha", 40000);
        e3.Display();
    }
}