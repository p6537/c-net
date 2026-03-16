using System;

class BillDiscount
{
    static void Main()
    {
        double billAmount, discount = 0;
        int category;

        Console.WriteLine("Enter Bill Amount:");
        billAmount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select Customer Category:");
        Console.WriteLine("1. Senior Citizen");
        Console.WriteLine("2. Regular Customer");
        Console.WriteLine("3. Industrial Customer");
        category = Convert.ToInt32(Console.ReadLine());

        switch (category)
        {
            case 1:
                discount = billAmount * 0.20; // 20% discount
                break;

            case 2:
                discount = billAmount * 0.10; // 10% discount
                break;

            case 3:
                discount = billAmount * 0.15; // 15% discount
                break;

            default:
                Console.WriteLine("Invalid Category");
                return;
        }

        double finalBill = billAmount - discount;

        Console.WriteLine("Discount Amount: " + discount);
        Console.WriteLine("Final Bill Amount: " + finalBill);
    }
}