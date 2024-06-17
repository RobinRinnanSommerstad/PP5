using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP5
{
    internal abstract class Shape
    {
        internal string Name { get; set; }
        internal double Width { get; set; }
        internal double Area { get;  set; }
        internal double Circumference { get;  set; }

        internal abstract double getArea();
        internal abstract double getCircumference();    

        internal Shape(double width, string name)
        {
            Width = width;
            Name = name;
        }
    }
}
