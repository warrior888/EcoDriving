using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsExample.Easy;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            TransferTextFileParser txtParser = new TransferTextFileParser();
            txtParser.ParseTransfers();

            var dupa = 3;

        }
        
    }
}
