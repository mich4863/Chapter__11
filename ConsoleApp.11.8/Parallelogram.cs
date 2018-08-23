using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._8
{
    public class Parallelogram : Quadrilateral
    {
        private int high;
        private int length;

        public Parallelogram(int high, int length) 
            : base()
        {
            High = high;
            Length = length;
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

        public int Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        public override double Area(Quadrilateral quadrilateral)
        {
            double result = High * Length;
            return result;
        }
    }
}
