using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.DuctShape
{
    internal class Triangle : Shape
    {
        private double _base;
        private double _height;

        public double Base
        {
            get { return _base; }
            set { ValidatePositive(value);
                _base = value; }
        }

        public double Height
        {
            get { return _height; }
            set { ValidatePositive(value);
                _height = value;
            }
        }

        public override double Area()
        {
            return (1.0 / 2.0) * Base * Height;
        }

        public double SideA()
        {
            return System.Math.Sqrt(
                System.Math.Pow(Base / 2, 2) +
                System.Math.Pow(Height, 2));
        }

        public double SideB()
        {
            return SideA();
        }

        public override double Perimeter()
        {
            return Base + SideA() * 2;
        }
        
    }
}
