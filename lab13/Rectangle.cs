using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal class Rectangle : Quad
    {
        private double length;
        public double Length { 
            get { return length; }
            set { length = value >= 0 ? value : throw new ArgumentOutOfRangeException("Rectangle length can't be less than 0."); } 
        }

        private double width;
        public double Width { 
            get { return width; } 
            set { width = value >= 0 ? value : throw new ArgumentOutOfRangeException("Rectangle width can't be less than 0."); } 
        }

        public Rectangle(double l, double w)
        {
            Length = l;
            Width = w;
        }

        public override double Area()
        {
            return Length * Width;
        }
    }
}
