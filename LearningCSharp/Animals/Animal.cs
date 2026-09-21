using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    internal class Animal
    {
        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative");
                _age = value;
            }
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Run()
        {
            Console.WriteLine($"{Name} is running");
        }

        public void Noise()
        {
            Console.WriteLine($"{Name} is making sounds");
        }
    }
}
