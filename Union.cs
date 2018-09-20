using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SetProgDM
{
    class Union
    {
        
        

        public Union()
        {
            Console.WriteLine("Union");
        List<int> ua = new List<int>() { 1, 2, 3 };
        
        List<int> ub = new List<int>() {1, 2, 5};

        
        List<int> uintersect = ua.Intersect(ub).ToList();
        List<int> union = ua.Union(ub).ToList();
        List<int> except = ua.Except(ub).ToList();

            union.ForEach(Console.WriteLine);
            //except.ForEach(Console.WriteLine);
        }

       /* internal void Run()
        {
            throw new NotImplementedException();
        }*/
    }
    
}
