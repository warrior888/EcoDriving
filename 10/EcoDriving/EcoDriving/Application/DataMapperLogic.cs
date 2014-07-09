using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoDriving.Application.Model;
using EcoDriving.Application.Parsing;
using LinqToExcel;
using XlsParser.Model;
using XlsParser.Parsing;

namespace EcoDriving.Application
{
    public class DataMapperLogic
    {
        public Dictionary<string, EcoDriveModel> GetParsedData(string fileName, int userId, int driveNumber)
        {
            var parser = new XlsxEcoDriveParsing(userId, driveNumber);

            var result = parser.getModelData(new ExcelQueryFactory(fileName));

            return result;
        }
    }
}