using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advisor.Generic;

namespace Advisor.Model
{
    public class ProductAdvice<T, T2, T3> : ModelBase<Product<T>, Advice<T2>, Advisor<T3>>
    {
    }
}
