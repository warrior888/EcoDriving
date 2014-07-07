using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    public static class ExtensionManager
    {
        public static double Add(this double item, double x)
        {
            return item + x;
        }

        public static double Subtract(this double item, double x)
        {
            return item - x;
        }

        public static double Multiply(this double item, double x)
        {
            return item * x;
        }

        public static double Divide(this double item, double x)
        {
            return item / x;
        }
    }
}
