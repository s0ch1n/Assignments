using System.Drawing;
using ConsoleAppAssignment8thE.Model;

namespace ConsoleAppAssignment8thE
{
    internal class GeometricApp
    {
        static void Main(string[] args)
        {
            //Instance
            GeometricFigure geometricobj = new RectangleFigure();
            GeometricFigure geometricobj1 = new SquareFigure();
            GeometricFigure geometricobj2 = new CircleFigure();
            RectangleFigure rectDimension = new RectangleFigure();
            SquareFigure squareDimension = new SquareFigure();
            CircleFigure circleDimension = new CircleFigure();


            //Menu Driven
            Console.WriteLine("Area for Geometric Figures");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Circle");
            Console.Write("Enter the choice: ");
            // Read user input and ensure it's valid
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after user input
            if (ch == '1')
            {
                geometricobj.AcceptSides(4);
                rectDimension.AcceptDimensions(5, 6);
                geometricobj.CalculateArea();
                rectDimension.Display();
            }
            else if (ch == '2')
            {
                geometricobj1.AcceptSides(4);
                squareDimension.AcceptSide(5);
                geometricobj1.CalculateArea();
                squareDimension.Display();
            }
            else if (ch == '3')
            {
                geometricobj2.AcceptSides(0);
                circleDimension.AcceptSide(8);
                geometricobj2.CalculateArea();
                circleDimension.Display();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please restart the program.");
                return; // Exit program
            }
         
            Console.WriteLine("Press any key to exit, Thanks!");
            Console.ReadKey();

        }
    }
}
