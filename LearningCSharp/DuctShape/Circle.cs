// Circle.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.DuctShape
{
    internal class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set
            {
                ValidatePositive(value);
                _radius = value;
            }
        }

        public override double Circumference()
        {
            return 2 * System.Math.PI * Radius;
        }

        public override double Area()
        {
            return System.Math.PI * System.Math.Pow(Radius, 2);
        }
    }
}
