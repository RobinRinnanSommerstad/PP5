using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP5
{
    internal class Rectangle : Shape
    {
        private double Height;
        internal override double getArea()
        {
            Area = Height * Width;
            return Area;
        }

        internal override double getCircumference()
        {
            Circumference = Height + Height + Width + Width;
            return Circumference;
        }

        public Rectangle(double width, double height, string name) : base(width, name)
        {
            Height = height;
        }
    }

}
