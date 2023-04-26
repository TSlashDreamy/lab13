using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal class Square : Quad
    {
        private double side;
        public double Side {
            get { return side; } 
            set { side = value >= 0 ? value : throw new ArgumentOutOfRangeException("Square side can't be less than 0."); } 
        }

        public Square(double s)
        {
            Side = s;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
