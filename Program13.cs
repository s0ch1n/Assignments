using System.Linq;
namespace ConsoleAppAssignment3rd2B
{
    internal class Program
    {
        //To find the maximum and minimum element of an array
        static void Main(string[] args)
        {

            // Read the size of the array
            Console.Write("Enter the number of elements in the array: ");
            int size = Convert.ToInt16(Console.ReadLine());

            int[] numList = new int[size];
            Console.WriteLine($"Enter {size} integers:");

            // Populate the array with user input
            for (int i = 0; i < size; i++)
            {
                numList[i] = Convert.ToInt16(Console.ReadLine());
            }

            int maxNum = numList.Max();
            int minNum = numList.Min();
            
            Console.WriteLine("The maximum element in the array is: " + maxNum);
            Console.WriteLine("The minimum element in the array is: " + minNum);
            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
