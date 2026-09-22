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
        private double _diameter;

        public double Diameter
        {
            get { return _diameter; }
            set
            {
                ValidatePositive(value);
                _diameter = value;
            }
        }

        public override double Perimeter()
        {
            return 2 * System.Math.PI * Diameter / 2;
        }

        public override double Area()
        {
            return System.Math.PI * System.Math.Pow(Diameter / 2, 2);
        }
    }
}
