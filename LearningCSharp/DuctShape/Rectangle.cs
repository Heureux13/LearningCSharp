// Rectangle.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.DuctShape
{
    internal class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public double Width
        {
            get { return _width; }
            set
            {
                ValidatePositive(value);
                _width = value;
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                ValidatePositive(value);
                _height = value;
            }
        }

        public override double Circumference()
        {
            return 2 * Width + 2 * Height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
