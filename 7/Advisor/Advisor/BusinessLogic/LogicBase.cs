using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advisor.BusinessLogic
{
    abstract public class LogicBase<T>
    {
        public abstract T PerformFuzzyLogicComputation(string text);
    }
}
