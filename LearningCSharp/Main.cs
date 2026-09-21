// Main.cs
using LearningCSharp.DuctShape;
using LearningCSharp.Ducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    internal class Main
    {
        internal class Program
        {
            static void Main()
            {
                Console.Write("Enter the circle radius: ");
                double radius = double.Parse(Console.ReadLine());
                Circle circle = new Circle();
                circle.Radius = radius;
                Console.WriteLine($"Circle circumference: {circle.Circumference():F2}");
                Console.WriteLine($"Circle Area: {circle.Area():F2}");

                Console.Write("Enter the width of the rectangle: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Enter the height of the rectangle: ");
                double height = double.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle();
                rectangle.Width = width;
                rectangle.Height = height;
                Console.WriteLine($"Rectangle circumference: {rectangle.Circumference():F2}");
                Console.WriteLine($"Rectangle Area: {rectangle.Area():F2}");

                Console.Write("Enter the width of the oval: ");
                double majorAxis = double.Parse(Console.ReadLine());
                Console.Write("Enter the height of the oval: ");
                double minorAxis = double.Parse(Console.ReadLine());
                Oval oval = new Oval();
                oval.MajorAxis = majorAxis;
                oval.MinorAxis = minorAxis;
                Console.WriteLine($"Oval circumference: {oval.Circumference():F2}");
                Console.WriteLine($"Oval area: {oval.Area():F2}");

                Duct duct = new Duct();
                duct.DuctShape = new Rectangle();

            }
        }
    }
}
