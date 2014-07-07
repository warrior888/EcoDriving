using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectRealityModeling.Base
{
    abstract public class Plant
    {
        protected Root korzen;

        public bool Grow()
        {
            this.korzen.Grow();
            return true;
        }

        public virtual void test()
        { 
        }

        abstract protected void test2();
    }
}
