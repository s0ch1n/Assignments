using System.Diagnostics;

namespace ConsoleAppAssignment2nd7G
{
    internal class Program11
    {
        //Entry point
        static void Main(string[] args)
        {
            Console.WriteLine("To Generate Electricity Bill");
            //get input from the user
            Console.Write("Enter the CustomerID: ");
            string customerID = Console.ReadLine();
            Console.Write("Enter the Customer Name: ");
            string customerName = Console.ReadLine();
            Console.Write("Enter the unit consumed: ");
            double unitConsumed = Convert.ToInt16(Console.ReadLine());
            double bill;
            //To generate bill
            if (unitConsumed <=199)
            {
                bill = unitConsumed * 1.20;
                Console.WriteLine("Electricity Bill is: Rs " + bill);
            }
            else if (unitConsumed >= 200 && unitConsumed < 400)
            {
                bill = unitConsumed * 1.50;
                Console.WriteLine("Electricity Bill is: Rs " + bill);
            }
            else if (unitConsumed >= 400 && unitConsumed < 600)
            {
                bill = unitConsumed * 1.80;
                Console.WriteLine("Electricity Bill is: Rs " + bill);
            }
            else 
            {
                bill = unitConsumed * 2.00;
                Console.WriteLine("Electricity Bill is: Rs " + bill);
            }
            Console.WriteLine("Electricity Bill: ");
            Console.WriteLine($"Customer ID: {customerID}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Unit Consumed: {unitConsumed}");
            Console.WriteLine($"Amount to be Paid: {bill}");

            // To keep the console window open
            Console.ReadKey();
        }
    }
}
