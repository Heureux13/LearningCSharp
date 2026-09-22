// Duct.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCSharp.DuctShape;

namespace LearningCSharp.Ducts
{
    internal class Duct
    {
        private Shape _shape;

        public Shape DuctShape
        {
            get { return _shape; }
            set { _shape = value; }
        }

        private double _lengthFt;

        public double LengthFt
        {
            get { return _lengthFt; }
            set { _lengthFt = value; }
        }

        public double SurfaceAreaSqft()
        {
            return _shape.Circumference() * LengthFt / 12;
        }

        public double SurfaceAreaPerFoot()
        {
            return _shape.Circumference() / 12;
        }

        private double _leakageClass;
        public double LeakageClass
        {
            get { return _leakageClass; }
            set
            {
                ValidateLeakageClass(value);
                _leakageClass = value;
            }
        }
        private double _testPressure;
        public double TestPressure
        {
            get { return _testPressure; }
            set { _testPressure = value; }
        }

        public double AllowableLeakage()
        {
            return LeakageClass * SurfaceAreaSqft() * System.Math.Pow(TestPressure, 0.65) / 100;
        }

        protected void ValidateLeakageClass(double value)
        {
            double[] leakageList = { 2, 4, 8, 16 };

            if (!leakageList.Contains(value))
                throw new ArgumentException($"{value} must be a valid leakage class");
        }
    }
}
