using System;

namespace ConsoleAppAssignment2nd3C
{
    internal class Program7
    {
        //Entry point
        static void Main(string[] args)
        {
            Console.WriteLine("Program to enter and view the details of student mark sheet");
            //get input from the user
            Console.Write("Enter the Roll No: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of the student: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter the mark of Physics: ");
            float physicsMark = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the mark of Maths: ");
            float mathsMark = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the mark of Chemistry: ");
            float chemistryMark = Convert.ToInt16(Console.ReadLine());
            //To calculate the marks and percentage
            float totalMarks = mathsMark + physicsMark + chemistryMark;
            Console.WriteLine("Total marks : " + totalMarks);
            float percentage = (totalMarks / 300)*100;
            Console.WriteLine("Total percentage : " + percentage+"%");
            string grade;
            //To check the division
            if (percentage >= 80)
            {
                grade = "Distinction";
            }
            else if (percentage >= 70 && percentage < 80)
            {
                grade = "First Class";
            }
            else if (percentage >= 60 && percentage < 70)
            {
                grade = "Second Class";
            }
            else if (percentage >= 50 && percentage < 60)
            {
                grade = "Third Class";
            }
            else if (percentage >= 40 && percentage < 50)
            {
                grade = "Passed";
            }
            else
            {
                grade = "Failed";
            }

            Console.WriteLine("Student Details: ");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Percentage: {percentage}");
            Console.Write($"Grade: {grade}");
            // To keep the console window open
            Console.ReadKey();
        }
    }
}
