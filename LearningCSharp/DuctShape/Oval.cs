using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.DuctShape
{
    internal class Oval : Shape
    {
        private double _minor_axis; // Full length
        private double _major_axis; // Full lenght

        public double MinorAxis
        {
            get { return _minor_axis; }
            set
            {
                ValidatePositive(value);
                _minor_axis = value;
            }
        }

        public double MajorAxis
        {
            get { return _major_axis; }
            set
            {
                ValidatePositive(value);
                _major_axis = value;
            }
        }

        public override double Circumference() // Formula for a duct flat oval
        {
            return System.Math.PI *
                (3 * (MajorAxis + MinorAxis) -
                System.Math.Sqrt(
                    (3 * MajorAxis + MinorAxis) *
                    (MajorAxis + 3 * MinorAxis)
                ));
        }

        public override double Area()
        {
            return System.Math.PI * (MajorAxis / 2) * (MinorAxis / 2);
        }




    }
}
