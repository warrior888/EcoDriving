using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using XlsParser.Model;

namespace XlsParser.Parsing.Interfaces
{
    public interface IParsingPolymorphism
    {
        DataMaperBase<Dictionary<string, ModelBase>, ExcelQueryFactory, ExcelQueryFactory> GetRelevantParser(string fileExtension);
    }
}
