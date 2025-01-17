namespace ConsoleAppAssignment2nd4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Admission for Professional Course");
            Console.Write("Enter the mark of Physics: ");
            int physicsMark = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the mark of Maths: ");
            int mathsMark = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the mark of Chemistry: ");
            int chemistryMark = Convert.ToInt16(Console.ReadLine());
            int totalMarks = mathsMark + physicsMark + chemistryMark;
            Console.WriteLine("Total marks : " + totalMarks);
            if (mathsMark >= 65 && physicsMark >= 55 && chemistryMark >=50)
            {
                if (totalMarks >= 180)
                {
                    Console.WriteLine("Eligible for Admission");
                }
                else if ((mathsMark + physicsMark) >= 140 || (mathsMark + chemistryMark) >= 140)
                {
                    Console.WriteLine("Eligible for Admission");
                }
                else
                {
                    Console.WriteLine("Not eligible for Admission");
                }
            }
            else 
            {
                Console.WriteLine("Not eligible for Admission");
            }
            // To keep the console window open
            Console.ReadKey();
        }
    }
}
