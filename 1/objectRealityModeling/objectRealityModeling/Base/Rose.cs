using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectRealityModeling.Base
{
    public class Rose : Flower
    {
        protected Rose plant;

        public override void test()
        {
            
            this.plant = new Rose();
            this.plant.test();

            base.test();
        }

        public override bool Bloom()
        {
            base.Bloom();
            
            ///
            return true;
        }

        protected override void test2()
        {
            throw new NotImplementedException();
        }
    }
}
