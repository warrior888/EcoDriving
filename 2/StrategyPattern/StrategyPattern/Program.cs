using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MorfologyAnalyzer mfan = new MorfologyAnalyzer();

            IMorfologyDeliveryStrategy randomMorfology = new RandomMorfologyGeneratorStrategy();
            IMorfologyDeliveryStrategy nfzMorfologyStrategy = new NfzMorfologyStrategy();

            mfan.AnalyzeMorfology(randomMorfology);
        }
    }
}
