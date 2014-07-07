using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace GhostRider.DataBaseAccess.DAL
{
    public abstract class DbHandle<T>
    {
        protected int Test;
        private string connectionString = 
            "Server=127.0.0.1;Port=5432;Database=szkolenie;User Id=postgres; Password=beatka;";

        private NpgsqlConnection connection;

        public DbHandle()
        {
             connection = new NpgsqlConnection(connectionString);

        }
        private void Connect()
        {
            
            if(connection.State != ConnectionState.Open)
            connection.Open();
        }

        public List<T> GetData(string select)
        {
            Connect();
            NpgsqlCommand selectCommand = new NpgsqlCommand(select, connection); 
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(selectCommand);  // odpowiada za uruchomienie select i zwraca adapter

            NpgsqlDataReader reader = adapter.SelectCommand.ExecuteReader();

            return GetRowsList(reader);
            
        }

        public void SaveData(string saveCommand)
        {
            Connect();
            NpgsqlCommand saveDaCommand = new NpgsqlCommand(saveCommand, connection);

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(saveDaCommand);
            adapter.SelectCommand.ExecuteNonQuery();
        }

        protected abstract T readRow(NpgsqlDataReader reader);

        protected List<T> GetRowsList(NpgsqlDataReader reader)
        {
            List<T> result = new List<T>();
            while (reader.Read())
            {
                result.Add(readRow(reader));
            }

            return result;
        }


    }
}
