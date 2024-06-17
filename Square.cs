using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP5
{
    internal class Square : Shape
    {
        internal override double getArea()
        {
            Area = Width * Width;
            return Area;
        }
        internal override double getCircumference()
        {
            Circumference = Width * 4;
            return Circumference;
        }

        public Square(double width, string name) : base(width, name)
        {
            
        }
    }
}
