namespace ConsoleAppAssignment1A
{
    /*Write a C# program that takes userid and password as input (type string). After 3 wrong attempts, user will 
     * be rejected.
     */
    internal class Program
    {
        //Entry point
        static void Main(string[] args)
        {
            // Initializing and Declaring variables 
            int count = 1;
            string userName = "sachin", password = "admin";
            Console.Write("Enter the username: ");
            userName = Console.ReadLine();
            //compares the username 
            if(userName == "sachin")
            {
                Console.Write("Enter the password: ");
                password = Console.ReadLine();
                //checks whether the correct password is entered within 3 attempts
                while (password != "admin")
                {
                    //To count the no of times 
                    count = count + 1;
                    Console.WriteLine("Please enter the correct password: ");
                    password = Console.ReadLine();
                 
                    if (count == 3)
                    {
                        Console.WriteLine("User rejected due to 3 wrong attempts");
                        break;
                    }
                }
                if (count < 3)
                {
                    Console.WriteLine("User accepted");
                }
            }
            else
            {
                Console.WriteLine("Wrong Username");
            }
            // To Keep the console window open
            Console.ReadKey();
        }
    }
}
