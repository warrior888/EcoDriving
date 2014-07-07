using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectRealityModeling
{
    public class Root
    {
        private Dictionary<string, Root> root = new Dictionary<string,Root>();

        protected int thickness;
        protected double length;

        public void Grow()
        {
            // dodawanie wezlow do root
            Root test = new Root();
            test.length = 3;
            test.thickness = 5;

            root.Add("a", test);

            
        }
    }
}
