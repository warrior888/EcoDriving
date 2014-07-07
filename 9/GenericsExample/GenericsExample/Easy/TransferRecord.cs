using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using GhostRider.DatabaseAccess.DAL;
using GhostRider.DatabaseAccess.DAL.Fields;
using Npgsql;

namespace GenericsExample.Easy
{
    public class TransferRecord : DbTable<TransferRecord, DbInsertField>
    {
        protected const string TransferSourceColumn = "Transfer_Source";
        protected const string SourceAccountNumberColumn = "Source_Account_Number";
        protected const string TargetAccountNumberColumn = "Target_Account_Number";
        protected const string SourceNameColumn = "Source_Name";
        protected const string TargetNameColumn = "Target_Name";
        protected override string tableName {
            get { return "Transfers"; }
        }

        public string TransferSource
        {
            get { return (string)this.dataBaseTable[TransferSourceColumn].FieldValue; }

            set
            {
                addDBfieldEntry(TransferSourceColumn, value, new DbInsertField());
            }
        }

        public string SourceAccountNumber
        {
            get { return (string)this.dataBaseTable[SourceAccountNumberColumn].FieldValue; }

            set
            {
                addDBfieldEntry(SourceAccountNumberColumn, value, new DbInsertField());
            } 
        }

        public string TargetAccountNumber
        {
            get { return (string)this.dataBaseTable[TargetAccountNumberColumn].FieldValue; }

            set
            {
                addDBfieldEntry(TargetAccountNumberColumn, value, new DbInsertField());
            } 
        }
        public string SourceName
        {
            get { return (string)this.dataBaseTable[SourceNameColumn].FieldValue; }

            set
            {
                addDBfieldEntry(SourceNameColumn, value, new DbInsertField());
            }
        }
        public string TargetName
        {
            get { return (string)this.dataBaseTable[TargetNameColumn].FieldValue; }

            set
            {
                addDBfieldEntry(TargetNameColumn, value, new DbInsertField());
            }
        }


        protected override TransferRecord readRow(NpgsqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
