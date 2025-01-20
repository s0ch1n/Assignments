
namespace ConsoleAppAssignment3rd1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
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
            //To count the number of duplicate elements
            for (int i = 0; i < numList.Length; i++)
            {
                for (int j = i + 1; j < numList.Length; j++)
                {
                    if (numList[j] == numList[i])
                    {
                        count += 1;
                    }   

                }

            }
            //To display the number of duplicate elements
            Console.WriteLine("Total Count of duplicate elements is: " + count);
            // To keep the console window open
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static int ConvertIntoInt32(string? v)
        {
            throw new NotImplementedException();
        }
    }
}
