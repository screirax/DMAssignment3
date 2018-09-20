using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetProgDM
{
    class Intersection
    {

        public Intersection()
        {
            Console.WriteLine("intersection");

            List<int> ia = new List<int>() { 2, 5, 7, 9 };

            List<int> ib = new List<int>() { 2, 4, 5 };


            List<int> intersect = ia.Intersect(ib).ToList();

            intersect.ForEach(Console.WriteLine);

        }

        internal void Run()
        {
            throw new NotImplementedException();
        }
    }
}
