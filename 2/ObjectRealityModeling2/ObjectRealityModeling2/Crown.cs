using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectRealityModeling2
{
    public class Crown : BTree<Crown>
    {
        public bool hasSomething;
        protected override void Grow()
        {
            throw new NotImplementedException();
        }
    }
}
