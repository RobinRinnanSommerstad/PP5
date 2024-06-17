using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP5
{
    internal class Circle : Shape
    {

        internal override double getArea()
        {
            Area = Math.PI * Math.Pow(Width / 2, 2); 
            return Area;
        }
        internal override double getCircumference()
        {
            Circumference = (Math.PI * 2) * (Width / 2);
            return Circumference;
        }
        public Circle(double width, string name) : base(width, name) 
        {

        }

    }
}
