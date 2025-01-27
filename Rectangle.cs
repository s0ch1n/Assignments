using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment8th1a
{
    public class Rectangle
    {
        // Attributes
        private double xCoordinate;
        private double yCoordinate;

        // Default Constructor
        public Rectangle()
        {
            xCoordinate = 0;
            yCoordinate = 0;
        }

        // Parameterized Constructor
        public Rectangle(double xCoordinate, double yCoordinate)
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
        }

        // Getter for xCoordinate
        public double GetXCoordinate()
        {
            return xCoordinate;
        }

        // Setter for xCoordinate
        public void SetXCoordinate(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("x-coordinate cannot be negative.");
            }
            xCoordinate = value;
        }
        // Getter for yCoordinate
        public double GetYCoordinate()
        {
            return yCoordinate;
        }

        // Setter for yCoordinate
        public void SetYCoordinate(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("y-coordinate cannot be negative.");
            }
            yCoordinate = value;
        }

        // Method to compute the area of the rectangle
        public double GetArea()
        {
            return xCoordinate * yCoordinate;
        }
        // Method to display Rectangle details
        public override string ToString()
        {
            return $"Rectangle [Width = {xCoordinate}, Height = {yCoordinate}, Area = {GetArea()}]";
        }
    }
}
