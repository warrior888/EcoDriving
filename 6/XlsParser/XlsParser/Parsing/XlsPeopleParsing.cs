using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using XlsParser.Model;

namespace XlsParser.Parsing
{
    public class XlsPeopleParsing : DataMaperBase<Dictionary<string, ModelBase>, ExcelQueryFactory, ExcelQueryFactory>
    {
        private readonly string columnID = "ID";
        private readonly string columnName = "Imie";
        private readonly string columnLastName = "Nazwisko";

        private readonly string workSheet = "DataBase";

        public override Dictionary<string, ModelBase> getModelData(ExcelQueryFactory queryFactory)
        {
            //Type t = new TypeDelegator((new Person()).GetType());

            queryFactory.AddMapping<Person>(person => person.userId, columnID);
            queryFactory.AddMapping<Person>(person => person.userName, columnName);
            queryFactory.AddMapping<Person>(person => person.userLastName, columnLastName);

            var people = queryFactory.Worksheet<Person>(workSheet).Select(x => (ModelBase) x);

            return people.ToDictionary(item => ((Person)item).userId.ToString());
        }

        public override Dictionary<string, ModelBase> getAdequateParser(ExcelQueryFactory queryFactory)
        {
            throw new NotImplementedException();
        }
    }
}
