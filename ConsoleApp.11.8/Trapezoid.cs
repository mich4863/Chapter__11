using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._8
{
    public class Trapezoid : Quadrilateral
    {
        private int high;
        private int side1;
        private int side2;

        public Trapezoid(int high, int side1, int side2)
            : base()
        {
            High = high;
            Side1 = side1;
            Side2 = side2;
        }

        public int High
        {
            get
            {
                return high;
            }

            set
            {
                high = value;
            }
        }

        public int Side1
        {
            get
            {
                return side1;
            }

            set
            {
                side1 = value;
            }
        }

        public int Side2
        {
            get
            {
                return side2;
            }

            set
            {
                side2 = value;
            }
        }

        public override double Area(Quadrilateral quadrilateral)
        {
            double result = 0.5 * High * (Side1 + Side2);
            return result;
        }
    }
}
