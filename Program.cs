using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetProgDM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 3.");
            /* Console.WriteLine("u = Union");
             Console.WriteLine("i = intersection");
             Console.WriteLine("m = membership not make yet");
             Console.WriteLine("d = Difference not make yet");
             Console.WriteLine("c = complement not make yet");
             Console.ReadLine();*/

            // union between 2 sets
            Union unionset = new Union();


            Intersection intersectionset = new Intersection();


            Difference differenceset = new Difference();

          /*  ConsoleKeyInfo keyInfo = Console.ReadKey();
            char selectedChar = keyInfo.KeyChar;


            switch (selectedChar)
            {
                case 'u':
                    {
                        Console.WriteLine("test");
                        Union union = new Union();
                        break;
                    }
                case 'i':
                    {
                        var intersection = new Intersection();
                        intersection.Run();
                        break;
                    }
            }*/
        }
    }
}
