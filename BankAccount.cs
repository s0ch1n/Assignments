using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment6th1A
{
    public class BankAccount
    {
        // Private data members
        private int acNumber;
        private string acHolderName;
        private double acBalance;
        private string acType;
        private double acMinBalance; // Minimum balance as a variable

        // Properties
        public int AcNumber
        {
            get { return acNumber; }
            set { acNumber = value; }
        }

        public string AcHolderName
        {
            get { return acHolderName; }
            set { acHolderName = value; }
        }

        public double AcBalance
        {
            get { return acBalance; }
            set
            {
                if (value >= acMinBalance)
                {
                    acBalance = value;
                }
                else
                {
                    Console.WriteLine($"Error: Balance cannot be less than the minimum balance of {acMinBalance}.");
                }
            }
        }

        public string AcType
        {
            get { return acType; }
            set { acType = value; }
        }

        public double AcMinBalance
        {
            get { return acMinBalance; }
            set { acMinBalance = value; }
        }
        // Constructor
        public BankAccount(int number, string holderName, double initialBalance, string type)
        {
            acMinBalance = 500.0; // Default minimum balance

            if (initialBalance >= acMinBalance)
            {
                acNumber = number;
                acHolderName = holderName;
                acBalance = initialBalance;
                acType = type;
            }
            else
            {
                Console.WriteLine($"Error: Initial balance must be at least {acMinBalance}. Account not created.");
            }
        }

        // Display Customer Details
        public void DisplayCustomerDetails()
        {
            Console.WriteLine("\nCustomer Details:");
            Console.WriteLine($"Account Number: {AcNumber}");
            Console.WriteLine($"Account Holder Name: {AcHolderName}");
            Console.WriteLine($"Account Type: {AcType}");
            Console.WriteLine($"Minimum Balance: {AcMinBalance}");
        }

        // Show Account Balance
        public void ShowAccountBalance()
        {
            Console.WriteLine($"Current Balance: {AcBalance}");
        }

        // Deposit Money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                AcBalance += amount;
                Console.WriteLine($"Successfully deposited {amount}. New Balance: {AcBalance}");
            }
            else
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
            }
        }

        // Withdraw Money
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (acBalance - amount >= acMinBalance)
                {
                    AcBalance -= amount;
                    Console.WriteLine($"Successfully withdrew {amount}. Remaining Balance: {AcBalance}");
                }
                else
                {
                    Console.WriteLine($"Error: Insufficient balance or withdrawal would drop below the minimum balance of {acMinBalance}.");
                }
            }
            else
            {
                Console.WriteLine("Error: Withdrawal amount must be positive.");
            }
        }




    }
}
