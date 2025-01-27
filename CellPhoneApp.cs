using ConsoleAppAssignment7th2b.DAL;
using ConsoleAppAssignment7th2b.Model;

namespace ConsoleAppAssignment7th2b
{
    internal class CellPhoneApp
    {
        static void Main(string[] args)
        {
            //Menu Driven

            while (true)
            {
                Console.WriteLine("\nWelcome to CellPhone App ");
                Console.WriteLine("Select the Account type: ");
                Console.WriteLine("1. Contract: ");
                Console.WriteLine("2. Pay As You Go: ");
                Console.WriteLine("3. Display ");
                Console.WriteLine("4. Search ");
                Console.WriteLine("5. Exit ");

                // Read user input and ensure it's valid
                char ch = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Move to the next line after user input

                if (ch == '1')
                {
                    // Handle Contract option
                    //add contract account 
                    Console.WriteLine("\n--- Add Contract Account ---");

                    //add and save cellphone number
                    Console.Write("Enter Cellphone Number: ");
                    string contractPhoneNumber = Console.ReadLine();

                    //add and save total call time
                    Console.Write("Enter Total Call Time (in minutes): ");
                    double contractCallTime = Convert.ToDouble(Console.ReadLine());

                    //add and save total cost
                    Console.Write("Enter Total Cost: ");
                    double contractCost = Convert.ToDouble(Console.ReadLine());

                    //add and save account holder name
                    Console.Write("Enter Account Holder Name: ");
                    string accountHolderName = Console.ReadLine();

                    //add and save address
                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();

                    //add and save the length of contract
                    Console.Write("Enter Contract Length (in months): ");
                    int contractLength = Convert.ToInt32(Console.ReadLine());

                    // Create Contract object and add to system
                    Contract contract = new Contract(contractPhoneNumber, contractCallTime, contractCost, accountHolderName, address, contractLength);
                    CellPhoneAccountCred.AddNewAccount(contract);

                }
                else if (ch == '2')
                {
                    // Handle PayAsYouGo option
                    Console.WriteLine("\n--- Add PayAsYouGo Account --- \n");

                    //add cellphone number
                    Console.Write("Enter Cellphone Number: ");
                    string payAsYouGoPhoneNumber = Console.ReadLine();

                    //add total call time
                    Console.Write("Enter Total Call Time: ");
                    double payAsYouGoCallTime = Convert.ToDouble(Console.ReadLine());

                    //add total cost
                    Console.Write("Enter Total Cost: ");
                    double payAsYouGoCost = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Account Type (C for Callmore, P for Peak Time, A for Any Time): ");
                    char accountType = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    // Validate input for account type
                    if (accountType != 'C' && accountType != 'P' && accountType != 'A')
                    {
                        Console.WriteLine("Invalid account type! Please enter C, P, or A.");
                        //break;
                    }

                    // Create PayAsYouGo object and add to system
                    PayAsYouGo payAsYouGo = new PayAsYouGo(payAsYouGoPhoneNumber, payAsYouGoCallTime, payAsYouGoCost, accountType);
                    CellPhoneAccountCred.AddNewAccount(payAsYouGo);
                    // break;

                }
                else if (ch == '3')
                {
                    // Display all accounts
                    Console.WriteLine("\n--- Display All Accounts ---");
                    CellPhoneAccountCred.DisplayAllAccounts();

                }
                else if (ch == '4')
                {
                    // Search for an account by phone number
                    Console.Write("\nEnter phone number to search: ");
                    string phoneNumber = Console.ReadLine();
                    CellPhoneAccountCred.SearchByPhoneNumber(phoneNumber);

                }
                else if (ch == '5')
                {
                    // Exit the application
                    Console.WriteLine("Exiting...");
                    return;

                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");

                }

                Console.WriteLine("Press any key to restart the program, Thanks!");
                Console.ReadKey();
            }
        }

    }
}

