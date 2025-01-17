namespace ConsoleAppAssignment2nd5E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char continueChoice = 'n';
            do
            {
                Console.WriteLine("To find the Area of Geometrical Shapes");
                

                //show the actions
                Console.WriteLine("1. Area of Circle");
                Console.WriteLine("2. Area of Triangle");
                Console.WriteLine("3. Area of Square");
                Console.WriteLine("4. Area of Rectangle");

                //Get choice
                Console.Write("Enter your choice (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //Process output
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the radius: ");
                        double radius = Convert.ToInt16(Console.ReadLine());
                        double areaCircle = 3.14 * radius * radius;
                        Console.WriteLine("Area of Circle is: " + (areaCircle));
                        break;
                    case 2:
                        Console.Write("Enter the breadth: ");
                        double breadth = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Enter the height: ");
                        double height = Convert.ToInt16(Console.ReadLine());
                        double areaTriangle = 0.5 * breadth * height;
                        Console.WriteLine("Area of Triangle is: " + (areaTriangle));
                        break;
                    case 3:
                        Console.Write("Enter the length: ");
                        double length = Convert.ToInt16(Console.ReadLine());
                        double areaSquare = length * length;
                        Console.WriteLine("Area of Square is: " + (areaSquare));
                        break;
                    case 4:
                        Console.Write("Enter the length: ");
                        double len = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Enter the width: ");
                        double width = Convert.ToInt16(Console.ReadLine());
                        double areaRectangle = len * width;
                        Console.WriteLine("Area of Triangle is: " + (areaRectangle));
                        break;
                    default:
                        Console.WriteLine("Invalid Choice....!");
                        break;

                }

                Console.WriteLine("Do you want to continue y/n : ");
                continueChoice = Convert.ToChar(Console.ReadLine().ToLower());
                Console.Clear();
            } while (continueChoice == 'y');
            Console.WriteLine("Thank you for using!");
        }
    }
}
