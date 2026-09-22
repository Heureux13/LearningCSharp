using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.DuctShape
{
    internal class Pentagon : Shape
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set
            {
                ValidatePositive(value);
                _side = value;
            }
        }

        private readonly double GoldenRatio = (1 + Math.Sqrt(5)) / 2;

        private double Radiants()

        {
            return 36 * (System.Math.PI / 180);
        }

        public double Vertex()
        {
            return Side * GoldenRatio;
        }

        public double Apothem()
        {
            return Side / (
                2.0 * System.Math.Tan(Radiants()));
        }

        public override double Area()
        {
            return (5.0 / 4.0) *
                System.Math.Pow(Side, 2) *
                System.Math.Tan(3.0 * System.Math.PI / 10);
        }

        public override double Perimeter()
        {
            return Side * 5;
        }
    }
}
