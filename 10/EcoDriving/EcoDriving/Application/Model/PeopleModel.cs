using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GhostRider.DatabaseAccess.DAL;
using GhostRider.DatabaseAccess.DAL.Fields;
using Npgsql;

namespace EcoDriving.Application.Model
{
    public class PeopleModel : DbTable<PeopleModel, DbField>
    {
        protected override string tableName
        {
            get { return "EcoDrivePeople"; }
        }

        public string TableName
        {
            get { return tableName; }
        }

        public const string idColumn = "id";
        public const string nameColumn = "name";
        public const string surnameColumn = "surname";

        public int Id
        {
            get { return (int)this.dataBaseTable[idColumn].FieldValue; }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(idColumn, value, new DbInsertField());
            }
        }

        public string FullName
        {
            get { return Name + " " + Surname; }
            
        }

        public string Name
        {
            get { return this.dataBaseTable[nameColumn].FieldValue.ToString(); }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(nameColumn, value, new DbInsertField());
            }
        }

        public string Surname
        {
            get { return this.dataBaseTable[surnameColumn].FieldValue.ToString(); }

            set // wartoscia jest slowo kluczowe value
            {
                addDBfieldEntry(surnameColumn, value, new DbInsertField());
            }
        }

        protected override PeopleModel readRow(NpgsqlDataReader reader)
        {
            PeopleModel result = new PeopleModel();

            result.Id = (int)reader[idColumn];
            result.Name = reader[nameColumn].ToString();
            result.Surname = reader[surnameColumn].ToString();

            return result;
        }
    }
}