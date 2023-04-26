using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    internal class QuadCollection
    {
        private Stack<Quad> quads;

        public QuadCollection()
        {
            quads = new Stack<Quad>();
        }

        public void Add(Quad quad)
        {
            quads.Push(quad);
        }

        public Quad Remove()
        {
            return quads.Pop();
        }

        public int Count()
        {
            return quads.Count;
        }

        public double TotalArea()
        {
            double area = 0;

            foreach (Quad quad in quads)
            {
                area += quad.Area();
            }

            return area;
        }
    }
}
