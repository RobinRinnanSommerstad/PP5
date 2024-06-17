using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP5
{
    internal class MakeShape
    {
        internal Square makeSquare()
        {
            Console.WriteLine("Hvor lange skal sidene være?");
            var input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hva vil du at Kvadratet skal hete?");
            var input1 = Console.ReadLine();

            return new Square(input, input1);
        }

        internal Triangle makeTriangle() {

            Console.WriteLine("Hvor lange skal bredden være?");
            var input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hvor lange skal høyden være?");
            var input1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hvor lange skal linje1 være?");
            var input2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hvor lange skal linje2 være?");
            var input3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hva vil du at Trekanten skal hete?");
            var input4 = Console.ReadLine();

            return new Triangle(input, input1, input2, input3, input4);
        }

        internal Circle makeCircle() {

            Console.WriteLine("Hvor lange skal diameteren være?");
            var input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hva vil du at Sirkelen skal hete?");
            var input1 = Console.ReadLine();

            return new Circle(input, input1);
        }

        internal Rectangle makeRectangle() {

            Console.WriteLine("Hvor lange skal bredden være?");
            var input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hvor lange skal høyden være?");
            var input1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hva vil du at Rektangelen skal hete?");
            var input2 = Console.ReadLine();

            return new Rectangle(input, input1, input2);
        }
    }
}
