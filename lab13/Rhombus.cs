using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal class Rhombus : Quad
    {
        private double diagonal1;
        public double Diagonal1 { 
            get { return diagonal1; } 
            set { diagonal1 = value >= 0 ? value : throw new ArgumentOutOfRangeException("Rhombus first diagonal can't be less than 0."); } 
        }

        private double diagonal2;
        public double Diagonal2 { 
            get { return diagonal2; } 
            set { diagonal2 = value >= 0 ? value : throw new ArgumentOutOfRangeException("Rhombus second diagonal can't be less than 0."); } 
        }

        public Rhombus(double d1, double d2)
        {
            Diagonal1 = d1;
            Diagonal2 = d2;
        }

        public override double Area()
        {
            return 0.5 * Diagonal1 * Diagonal2;
        }
    }
}
