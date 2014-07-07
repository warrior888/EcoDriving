using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLExample
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomizeAndSeek finder = new RandomizeAndSeek();
            var startTime = DateTime.Now.Ticks;
            System.Console.WriteLine(finder.randomizeAndSeek(10000000,0,10,8, 10));
            var endTime = DateTime.Now.Ticks;

            var timeSlice = endTime - startTime;
            Console.WriteLine("Comutation consumed {0} ticks", timeSlice);
            Console.ReadKey();
        }
    }
}
