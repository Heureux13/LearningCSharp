// Main.cs
using LearningCSharp.DuctShape;
using LearningCSharp.Ducts;
using System;
using System.Collections.Generic;
using LearningCSharp.Helpers;
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
                InputHelper input = new InputHelper();

                while (true)

                {
                    string shape = input.PickOne("Rect, Round, or Oval?");

                    // Create shape

                    Shape selectedShape = null;

                    if (shape == "round")
                    {
                        Circle round = new Circle();

                        double diameter = input.AskForNumber("What is the diameter?");
                        round.Diameter = diameter;

                        selectedShape = round;
                    }

                    else if (shape == "rect")
                    {
                        Rectangle rect = new Rectangle();

                        double width = input.AskForNumber("What is the width?");
                        rect.Width = width;

                        double height = input.AskForNumber("What is the height?");
                        rect.Height = height;

                        selectedShape = rect;
                    }

                    else if (shape == "oval")
                    {
                        Oval oval = new Oval();

                        double majorAxis = input.AskForNumber("What is the width?");
                        oval.MajorAxis = majorAxis;

                        double minorAxis = input.AskForNumber("What is the height?");
                        oval.MinorAxis = minorAxis;

                        selectedShape = oval;
                    }

                    // Create duct

                    Duct selectedDuct = new Duct();

                    selectedDuct.DuctShape = selectedShape;

                    // Get user length
                    double length = input.AskForNumber("What is the length in feet?");
                    selectedDuct.LengthFt = length;

                    // Get user leakage class
                    double leakageClass = input.PickLeakClass("What is the leakage class? ex 2, 4, 8, or 16");
                    selectedDuct.LeakageClass = leakageClass;

                    // Get user water gauge
                    double waterGauge = input.NumbersInRange("What is the W.G.? ex: 1-20", 0, 10);
                    selectedDuct.TestPressure = waterGauge;

                    // Calculate results

                    Console.WriteLine();
                    Console.WriteLine("##### RESULTS #####");
                    Console.WriteLine(
                        $"Surface Area: {selectedDuct.SurfaceAreaSqft():F2} sq ft");
                    Console.WriteLine(
                        $"Surface Area per foot: {selectedDuct.SurfaceAreaPerFoot():F2} sq ft");
                    Console.WriteLine(
                        $"Allowable Leakage: {selectedDuct.AllowableLeakage():F2} CFM");

                    // Repeate code
                    Console.WriteLine("Do you want to calculate another duct? (y/n)");
                    string again = Console.ReadLine().Trim().ToLower();

                    if (again != "yes" && again != "y")
                        break;
                }
            }
        }
    }
}
