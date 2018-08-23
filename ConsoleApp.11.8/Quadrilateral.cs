using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._11._8
{
    public class Quadrilateral
    {
        private int x1;
        private int y1;

        private int x2;
        private int y2;

        private int x3;
        private int y3;

        private int x4;
        private int y4;

        public Quadrilateral(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;
        }

        public int X1
        {
            get
            {
                return x1;
            }

            set
            {
                x1 = value;
            }
        }

        public int Y1
        {
            get
            {
                return y1;
            }

            set
            {
                y1 = value;
            }
        }

        public int X2
        {
            get
            {
                return x2;
            }

            set
            {
                x2 = value;
            }
        }

        public int Y2
        {
            get
            {
                return y2;
            }

            set
            {
                y2 = value;
            }
        }

        public int X3
        {
            get
            {
                return x3;
            }

            set
            {
                x3 = value;
            }
        }

        public int Y3
        {
            get
            {
                return y3;
            }

            set
            {
                y3 = value;
            }
        }

        public int X4
        {
            get
            {
                return x4;
            }

            set
            {
                x4 = value;
            }
        }

        public int Y4
        {
            get
            {
                return y4;
            }

            set
            {
                y4 = value;
            }
        }

        public double Area(Quadrilateral quadrilateral)
        {
            double first = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double second = Math.Sqrt((x1 - x4) * (x1 - x4) + (y1 - y4) * (y1 - y4));

            return first * second;
        }
    }
}
