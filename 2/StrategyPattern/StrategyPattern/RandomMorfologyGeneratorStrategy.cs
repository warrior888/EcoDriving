using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class RandomMorfologyGeneratorStrategy : IMorfologyDeliveryStrategy
    {
        public List<Morfology> GetMorfologies()
        {
            // 1 osoba definiuje encje morfology
            // losuja w jakistam zakresach przypadkowe morfologie
            // zwracacie z tej metody liste przypadkowo wylosowanych morfologii

            return null;
        }
    }
}
