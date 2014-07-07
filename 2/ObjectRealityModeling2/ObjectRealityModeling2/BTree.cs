using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRealityModeling2
{
    abstract public class BTree<T>
    {
        protected Dictionary<string, BTree<T>> indexStructure;

        protected int thickness;
        protected int nestingLevel;
        protected int length;

        protected abstract void Grow();

        public void waterandSunInfluence()
        {
            
            //other tasks

            thickness = 1;

            Grow();
        }
    }
}
