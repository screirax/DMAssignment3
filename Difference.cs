using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetProgDM
{
    class Difference
    {

        public Difference()
            {
        Console.WriteLine("Differnce");

            List<int> da = new List<int>() { 1, 2, 4, 5, 7, };

        List<int> db = new List<int>() { 1, 2, 3, 4, 5, 6, 7, };


            var differencelist = da.Except(db).ToList();

        differencelist.ForEach(Console.WriteLine);
            }

    }
}
