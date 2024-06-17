using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP5
{
    internal class Triangle : Shape
    {
        internal double Height;
        internal double Line2;
        internal double Line3;

        internal override double getArea()
        {
            Area = Width * Height / 2;
            return Area;
        }
        internal override double getCircumference()
        {
            Circumference = Height + Line2 + Line3;
            return Circumference;
        }

        public Triangle(double width, double height, double line1, double line2, string name) : base(width, name)
        {
            Height = height;
            Line2 = line1;
            Line3 = line2;
        }
    }
}
