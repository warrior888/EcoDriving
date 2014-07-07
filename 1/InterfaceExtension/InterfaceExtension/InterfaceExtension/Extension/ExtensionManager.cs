using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExtension.Extension
{
    public static class ExtensionManager
    {
        public static string IAmExtensionMethod(this int item )
        {
            return "We got int a new extension method";
        }

        public static int IAmExtensionFunnyMethod(this int item)
        {
            return 8;
        }
    }
}
