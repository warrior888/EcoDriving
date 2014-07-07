using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using XlsParser.Model;
using XlsParser.Parsing.Interfaces;

namespace XlsParser.Parsing
{
    public abstract class ParserBase : IParsingPolymorphism
    {
        protected Dictionary<string, DataMaperBase<Dictionary<string, ModelBase>, ExcelQueryFactory, ExcelQueryFactory>> ParsersMap = new Dictionary<string, DataMaperBase<Dictionary<string, ModelBase>, ExcelQueryFactory, ExcelQueryFactory>>
        {
            { "XLS", new XlsPeopleParsing() },
            { "CSV", new CsvEcoDriveParsing() },
            { "XLSX", new CsvEcoDriveParsing() },
        };

        public DataMaperBase<Dictionary<string, ModelBase>, ExcelQueryFactory, ExcelQueryFactory> GetRelevantParser(string fileExtension)
        {
            fileExtension = fileExtension.ToUpper();
            if (!ParsersMap.ContainsKey(fileExtension))
            {
                throw new ArgumentException(String.Format("No parser for {0} found.", fileExtension));
            }
            return ParsersMap[fileExtension];
        }
    }
}
