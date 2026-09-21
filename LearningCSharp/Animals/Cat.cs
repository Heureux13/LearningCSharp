using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
}
