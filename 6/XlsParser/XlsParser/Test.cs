using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using XlsParser.Model;
using XlsParser.Parsing;
using XlsParser.Parsing.Interfaces;

namespace XlsParser
{
    public class Test
    {
        public DataMaperBase<Dictionary<string, ModelBase>, ExcelQueryFactory, ExcelQueryFactory> TestCase(string extension)
        {
            ParsersFactory factory = new ParsersFactory();
            DataMaperBase<Dictionary<string, ModelBase>, ExcelQueryFactory, ExcelQueryFactory> parser = factory.GetRelevantParser(extension);
            return parser;
        }
    }
}
