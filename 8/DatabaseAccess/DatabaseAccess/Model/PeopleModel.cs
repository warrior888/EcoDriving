using System.Collections.Generic;
using GhostRider.DatabaseAccess.DAL;
using GhostRider.DatabaseAccess.DAL.Fields;
using Npgsql;

namespace GhostRider.DatabaseAccess.Model
{
    public class PeopleModel : DbTable<PeopleModel, DbInsertField>
    {
        public PeopleModel()
        {
            dataBaseTable = new Dictionary<string, DbField>();

        }

        protected override string tableName
        {
            get { return "People"; }
        }

        //public const column names
        public const string idColumn = "id";
        public const string nameColumn = "name";

        public int Id
        {
            get { return (int)this.dataBaseTable[idColumn].FieldValue; }

            set // wartoscia jest slowo kluczowe value
            {
               addDBfieldEntry(idColumn, value, new DbInsertField());

            }
        }

        public string Name
        {
            get { return (string) this.dataBaseTable[nameColumn].FieldValue; }

            set
            {
               addDBfieldEntry(nameColumn, value, new DbInsertField()); 
            }
        }

        protected override PeopleModel readRow(NpgsqlDataReader reader)
        {
            throw new System.NotImplementedException();
        }
    }
}
