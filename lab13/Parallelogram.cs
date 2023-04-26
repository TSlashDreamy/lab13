using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal class Parallelogram : Quad
    {
        private double quadBase;
        public double QuadBase 
        {
            get { return quadBase; }
            set { quadBase = value >= 0 ? value : throw new ArgumentOutOfRangeException("Parallelogram base can't be less than 0."); }
        }

        private double height;
        public double Height {
            get { return height; } 
            set { height = value >= 0 ? value : throw new ArgumentOutOfRangeException("Parallelogram height can't be less than 0."); } 
        }

        public Parallelogram(double b, double h)
        {
            QuadBase = b;
            Height = h;
        }

        public override double Area()
        {
            return QuadBase * Height;
        }
    }
}
