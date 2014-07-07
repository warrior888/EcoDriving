using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GhostRider.DatabaseAccess.DAL.Fields;

namespace GhostRider.DatabaseAccess.DAL
{
    public abstract class DbTable<T, T2> : DbHandle<T> where T2 : DbField
    {
        protected virtual string tableName { get; set; }
        public const string delimiter = ",";
        protected Dictionary<string, DbField> dataBaseTable = new Dictionary<string, DbField>();

        protected string GetInsertCommand()
        {
            string command = string.Format("Insert into {0} ", tableName);

            /* List<string> columns = new List<string>();

            foreach (var item in dataBaseTable)
            {
                columns.Add(item.Key);

            }
            LingQ => List<string> columns = dataBaseTable.Select(item => item.Key).ToList(); */

            string[] columns = dataBaseTable.Where(item=> ((DbInsertField)(item.Value)).IsFilled).Select(item => item.Key).ToArray();
            command += string.Format("({0}) values ", String.Join(delimiter, columns));
            string[] values =
                dataBaseTable.Where(item => ((DbInsertField) (item.Value)).IsFilled)
                    .Select(item => item.Value.ToString())
                    .ToArray();
            command += string.Format("({0});", String.Join(delimiter, values)) ;

            return command;
        }

        protected void addDBfieldEntry(string columnName, object value, T2 emptyInstance)
        {
            emptyInstance.FieldValue = value;

            if (this.dataBaseTable.ContainsKey(columnName))
            {
                this.dataBaseTable[columnName].FieldValue = value;

                return; 
            }

             this.dataBaseTable.Add(columnName, emptyInstance); //wartoscia jest slowo kluczowe
        }

        public void SaveData()
        {
            string insert = GetInsertCommand();
            this.SaveData(insert);
        }
    }
}
