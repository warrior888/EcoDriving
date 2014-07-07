﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPLExample
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomizeAndSeek finder = new RandomizeAndSeek();
            var startTime = DateTime.Now.Ticks;

            System.Console.WriteLine(finder.randomizeandSeek(1000000,0,100,8,10));
            var endTime = DateTime.Now.Ticks;

            var timeSlice = endTime - startTime;
            Console.WriteLine("Computation consumed {0} ticks", timeSlice);
            Console.ReadLine();
        }
    }
}
