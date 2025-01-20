namespace ConsoleAppAssignment3rd10J
{
    internal class Program
    {
        //Accept two matrices and check whether they are equal
        static void Main(string[] args)
        {
            // Get the number of rows and columns of the matrix from the user
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int columns = Convert.ToInt16(Console.ReadLine());

            // Declaring two matrices and the result matrix
            int[,] matrix1 = new int[rows, columns];
            int[,] matrix2 = new int[rows, columns];
            int[,] resultMatrix = new int[rows, columns];

            // Get values for the first matrix
            Console.WriteLine("Enter the elements of the first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix1[i, j] = Convert.ToInt16(Console.ReadLine());

                }
            }

            // Get values for the second matrix
            Console.WriteLine("Enter the elements of the second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix2[i, j] = Convert.ToInt16(Console.ReadLine());

                }
            }
            // Check if the matrices are equal
            bool Equal = true;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        Equal = false;
                        break;
                    }
                }
                if (!Equal) break;
            }
            // Display the result
            if (Equal == true)
            {
                Console.WriteLine("The matrices are equal.");
            }
            else
            {
                Console.WriteLine("The matrices are not equal.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }
    }
}
