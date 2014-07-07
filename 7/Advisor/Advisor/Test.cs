using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advisor.BusinessLogic;
using Advisor.Model.Dedicated;

namespace Advisor
{
    public class Test
    {
        protected ProductAdviceLogic LogicAdvice;

        public Test()
        {
            // generic !!
            this.LogicAdvice = new ProductAdviceLogic();
            TelephoneBuyGhostRiderModel result = this.LogicAdvice.PerformFuzzyLogicComputation("a plain text explanation of a user");
        }
    }
}
