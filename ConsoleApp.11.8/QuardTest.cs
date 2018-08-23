using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._8
{
    class QuardTest
    {
        static void Main(string[] args)
        {
            Quadrilateral quadrilateral = new Quadrilateral(2, 2, 6, 2, 6, 6, 2, 6);
            Console.WriteLine(quadrilateral.Area(quadrilateral));
            

            Parallelogram parallelogram = new Parallelogram(10, 10);
            Console.WriteLine(parallelogram.Area(parallelogram));

            Trapezoid trapezoid = new Trapezoid(10, 5, 8);
            Console.WriteLine(trapezoid.Area(trapezoid));

            Rectangle rectangle = new Rectangle(20, 10);
            Console.WriteLine(rectangle.Area(rectangle));
            Console.ReadLine();
        }
    }
}
