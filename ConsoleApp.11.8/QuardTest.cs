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
            Console.ReadLine();
        }
    }
}
