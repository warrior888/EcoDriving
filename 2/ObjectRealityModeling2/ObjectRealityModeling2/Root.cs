using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRealityModeling2
{
    public class Root : BTree<Root>
    {
        protected bool nitrousBubles;
        protected override void Grow()
        {
            throw new NotImplementedException();
        }
    }
}
