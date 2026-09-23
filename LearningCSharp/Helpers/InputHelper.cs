using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Helpers
{
    internal class InputHelper
    {
        public double AskForNumber(string question)
        {
            Console.WriteLine(question);
            string userInput = Console.ReadLine();

            double number;

            while (!double.TryParse(userInput, out number))
            {
                Console.WriteLine($"{userInput} must be a number, please try again");
                userInput = Console.ReadLine();
            }

            return number;
        }

        public string Clean(string any)
        {
            return any.Trim().ToLower();
        }

        public string PickOne(string question)
        {
            Console.WriteLine(question);
            string input = Clean(Console.ReadLine());

            var validChoices = new List<string> { "rect", "round", "oval" };

            while (!validChoices.Contains(input))
            {
                Console.WriteLine($"{input} is not vaalid (rect), (round), or (oval)");
                input = Clean(Console.ReadLine());
            }

            return input;
        }

        public double PickLeakClass(string question)
        {
            Console.WriteLine(question);
            string userInput = Console.ReadLine();

            double leakClass;
            var validLeakClass = new List<double> { 2, 4, 8, 16 };

            while (!double.TryParse(userInput, out leakClass) ||
                !validLeakClass.Contains(leakClass))
            {
                Console.WriteLine($"{userInput} can only be 2, 4, 8, or 16");
                userInput = Console.ReadLine();
            }

            return leakClass;

        }

        public double NumbersInRange(string question, double min, double max)
        {
            Console.WriteLine(question);
            string userInput = Console.ReadLine();

            double number;
            
            while (!double.TryParse(userInput, out number) ||
                number < min ||
                number > max)
            {
                Console.WriteLine($"{userInput} is not valid, between 00-20");
                userInput = Console.ReadLine();
            }

            return number;
        }
    }
}
