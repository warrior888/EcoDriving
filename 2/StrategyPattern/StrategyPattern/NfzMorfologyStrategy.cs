using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class NfzMorfologyStrategy : IMorfologyDeliveryStrategy
    {
        public List<Morfology> GetMorfologies()
        {
            // logika pobrania danych ze zrodla wg specyfikacji

            return null;
        }
    }
}
