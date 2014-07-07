using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectRealityModeling.Base
{
    abstract public class Flower : Plant
    {
        private Pak pak = new Pak();

        public virtual bool Bloom()
        {
            this.pak.CanBloom = true;
            //this.
            this.Grow();
            return true;
        }
    }
}
