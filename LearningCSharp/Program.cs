using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    internal class Dog
    {
        public string Name;
        public int Age;

        public void Bark()
        {
            Console.WriteLine(Name + " says: Woof");
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Rex";
            myDog.Age = 3;

            myDog.Bark();
        }
    }
}
