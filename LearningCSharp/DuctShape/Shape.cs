// Shape.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.DuctShape
{
    internal class Shape
    {
        protected void ValidatePositive(double value)
        {
            if (value <= 0)
                throw new ArgumentException($"{value} must be greater than 0");
        }

        public virtual double Circumference()
        {
            throw new NotImplementedException();
        }

        public virtual double Area()
        {
            throw new NotImplementedException();
        }
    }
}
