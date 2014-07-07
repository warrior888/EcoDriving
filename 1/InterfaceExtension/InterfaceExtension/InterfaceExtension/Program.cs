

using System;
using InterfaceExtension.Extension;

namespace InterfaceExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            var god = God.GetInstance();

            var rose = new Rose();
            rose.ReSharperShowDown();
            Console.ReadLine();

            int a = 3;
            a.IAmExtensionMethod();
            var test = a.IAmExtensionFunnyMethod().IAmExtensionFunnyMethod().IAmExtensionFunnyMethod();
        }
    }
}
