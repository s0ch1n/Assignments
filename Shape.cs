using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment8th4d
{
    public class Shape
    {
        private const double DefaultSize = 10;


        // Calculates the volume of a cube with the given side length.
        // If no side length is provided, defaults to 10.

        public double Cube(double side = DefaultSize)
        {
            return Math.Pow(side, 3);
        }


        // Calculates the volume of a sphere with the given radius.

        public double Sphere(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }


        // Calculates the volume of a cylinder with the given radius and height.

        public double Cylinder(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }


        // Calculates the volume of a cone with the given radius and height.

        public double Cone(double radius, double height)
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }

        public void CalculateAndDisplayVolume()
        {
            Console.WriteLine("Choose a shape to calculate its volume:");
            Console.WriteLine("1. Cube");
            Console.WriteLine("2. Sphere");
            Console.WriteLine("3. Cylinder");
            Console.WriteLine("4. Cone");

            try
            {
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the side length of the cube (or press Enter for default size): ");
                        string cubeInput = Console.ReadLine();
                        double cubeSide = string.IsNullOrEmpty(cubeInput) ? DefaultSize : double.Parse(cubeInput);
                        Console.WriteLine($"Volume of Cube: {Cube(cubeSide)}");
                        break;

                    case 2:
                        Console.Write("Enter the radius of the sphere: ");
                        double sphereRadius = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Volume of Sphere: {Sphere(sphereRadius)}");
                        break;

                    case 3:
                        Console.Write("Enter the radius of the cylinder: ");
                        double cylinderRadius = double.Parse(Console.ReadLine());
                        Console.Write("Enter the height of the cylinder: ");
                        double cylinderHeight = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Volume of Cylinder: {Cylinder(cylinderRadius, cylinderHeight)}");
                        break;

                    case 4:
                        Console.Write("Enter the radius of the cone: ");
                        double coneRadius = double.Parse(Console.ReadLine());
                        Console.Write("Enter the height of the cone: ");
                        double coneHeight = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Volume of Cone: {Cone(coneRadius, coneHeight)}");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
        }
    }
}
