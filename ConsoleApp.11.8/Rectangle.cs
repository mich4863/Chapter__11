using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._8
{
    public class Rectangle : Quadrilateral
    {
        private int length;
        private int width;

        public Rectangle(int length, int width) 
            : base()
        {
            Length = length;
            Width = width;
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

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public override double Area(Quadrilateral quadrilateral)
        {
            double result = Length * Width;
            return result;
        }
    }
}
