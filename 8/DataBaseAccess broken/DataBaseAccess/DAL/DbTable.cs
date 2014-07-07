using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GhostRider.DataBaseAccess.DAL.Fields;

namespace GhostRider.DataBaseAccess.DAL
{
    public abstract class DbTable
    {
        public const string delimiter = ", ";

        protected Dictionary<string, DbField> dataBaseTable; // id , intowa kolumna; nazwa - stringowa kolumna

        // insert into tableka (kolumna1, kolumna2) values (id, nazwa);

        protected string GetInsertCommand()
        {
            string command = "insert into "; // ( , , , , , , , )



            string[] columns = dataBaseTable.Where(item => ((DbInsertField)(item.Value)).IsFilled).Select(item => item.Key).ToArray();
            command += string.Format("({0}) values ", String.Join(delimiter, columns));



            return command;
        }
    }
}
