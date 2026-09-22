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
                while (true)

                {
                    var validChoices = new List<string> { "rect", "round", "oval" };

                    // Choosing duct shape

                    Console.WriteLine("Round or Rect or Oval?");

                    string inputChoice = Console.ReadLine();
                    string cleanChoice = inputChoice.Trim().ToLower();


                    while (!validChoices.Contains(cleanChoice))
                    {
                        Console.WriteLine($"{inputChoice} is not a valid pleast type (rect) or (round)");
                        inputChoice = Console.ReadLine();
                        cleanChoice = inputChoice.Trim().ToLower();
                    }

                    // Create shape

                    Shape selectedShape = null;

                    if (cleanChoice == "round")
                    {
                        Circle round = new Circle();

                        Console.WriteLine($"What is the diameter?");
                        string userDiameter = Console.ReadLine();

                        double diameter;

                        while (!double.TryParse(userDiameter, out diameter))
                        {
                            Console.WriteLine($"{userDiameter} is not a number try again");
                            userDiameter = Console.ReadLine();
                        }

                        round.Diameter = diameter;

                        selectedShape = round;
                    }

                    else if (cleanChoice == "rect")
                    {
                        Rectangle rect = new Rectangle();

                        Console.WriteLine($"What is the width?");
                        string userWidth = Console.ReadLine();

                        double width;

                        while (!double.TryParse(userWidth, out width))
                        {
                            Console.WriteLine($"{userWidth} must be a number, please try again");
                            userWidth = Console.ReadLine();
                        }

                        Console.WriteLine($"What is the height?");
                        string userHeight = Console.ReadLine();

                        double height;

                        while (!double.TryParse(userHeight, out height))
                        {
                            Console.WriteLine($"{userHeight} must be a number, please try again");
                            userHeight = Console.ReadLine();
                        }

                        rect.Width = width;
                        rect.Height = height;

                        selectedShape = rect;
                    }

                    else if (cleanChoice == "oval")
                    {
                        Oval rect = new Oval();

                        Console.WriteLine($"What is the width?");
                        string userWidth = Console.ReadLine();

                        double width;

                        while (!double.TryParse(userWidth, out width))
                        {
                            Console.WriteLine($"{userWidth} must be a number, please try again");
                            userWidth = Console.ReadLine();
                        }

                        Console.WriteLine($"What is the height?");
                        string userHeight = Console.ReadLine();

                        double height;

                        while (!double.TryParse(userHeight, out height))
                        {
                            Console.WriteLine($"{userHeight} must be a number, please try again");
                            userHeight = Console.ReadLine();
                        }

                        rect.MajorAxis = width;
                        rect.MinorAxis = height;

                        selectedShape = rect;
                    }

                    // Create duct

                    Duct selectedDuct = new Duct();

                    selectedDuct.DuctShape = selectedShape;

                    // Get user length
                    Console.WriteLine($"What is the duct length in feet");
                    string userLength = Console.ReadLine();

                    double length;

                    while (!double.TryParse(userLength, out length))
                    {
                        Console.WriteLine($"{userLength} must be a number, please try again");
                        userLength = Console.ReadLine();
                    }

                    selectedDuct.LengthFt = length;

                    // Get user leakage class
                    Console.WriteLine($"What is the leakage class? ex: 2, 4, 8, 16");
                    string userLeakageClass = Console.ReadLine();

                    double leakageClass;
                    var validLeakClass = new List<double> { 2, 4, 8, 16 };

                    while (!double.TryParse(userLeakageClass, out leakageClass) ||
                        !validLeakClass.Contains(leakageClass))
                    {
                        Console.WriteLine($"{userLeakageClass} must be 2, 4, 8, or 16");
                        userLeakageClass = Console.ReadLine();
                    }

                    selectedDuct.LeakageClass = leakageClass;

                    // Get user water gauge
                    Console.WriteLine($"What is the water gauge? ex 1-20");
                    string userWaterGauge = Console.ReadLine();

                    double waterGauge;

                    while (!double.TryParse(userWaterGauge, out waterGauge) ||
                        waterGauge < 0 ||
                        waterGauge > 20)
                    {
                        Console.WriteLine($"{userWaterGauge} must be a number, between 0 & 20");
                        userWaterGauge = Console.ReadLine();
                    }

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
