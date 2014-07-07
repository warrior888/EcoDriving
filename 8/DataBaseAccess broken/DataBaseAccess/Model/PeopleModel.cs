using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GhostRider.DataBaseAccess.DAL;
using GhostRider.DataBaseAccess.DAL.Fields;

namespace GhostRider.DataBaseAccess.Model
{
    public class PeopleModel : DbTable
    {
        public PeopleModel()
        {
            dataBaseTable = new Dictionary<string, DbField>
            {
                {IdColumn, new DbInsertField() }, 
                {NameColumn, new DbInsertField() }, 
            };
        }

        //public const column names
        public const string IdColumn = "Id";

        public const string NameColumn = "name";

        public int Id
        {
            get
            {
                return (int)this.dataBaseTable[IdColumn].FieldValue;
            }
            set // wartoscia jest slowo kluczowe value
            {
                //this.dataBaseTable.ContainsKey(IdColumn)
                //    ? this.dataBaseTable[IdColumn].FieldValue = (int)value
                //    : this.dataBaseTable.Add(IdColumn, new DbInsertField((int)value));

                this.dataBaseTable[IdColumn].FieldValue = (int)value;
            }
        }

        public string Name
        {
            get
            {
                return (string) this.dataBaseTable[NameColumn].FieldValue;
            }
            set
            {
                this.dataBaseTable[NameColumn].FieldValue = (string) value;
            }
        }
    }
}
