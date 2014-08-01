using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace GhostRider.DatabaseAccess.DAL
{
    public abstract class DbHandle<T>
    {
        protected int test;

        private const string connectionString =
            "Server=127.0.0.1;Port=5432;Database=szkolenie;User Id=postgres; Password=beatka;";

        private NpgsqlConnection connection;

        static DbHandle()
        {
            //connection = new NpgsqlConnection(connectionString);
        }
        private void Connect()
        {
            if (connection == null)
            {
                connection = new NpgsqlConnection(connectionString);
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void Disconnect()
        {
            connection.Close();
        }

        public List<T> GetData(string select, string[] columns = null)
        {
            Connect();
            NpgsqlCommand selectCommand = new NpgsqlCommand(select, connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(selectCommand);  // odpowiada za uruchomienie select i zwraca adapter

            NpgsqlDataReader reader = adapter.SelectCommand.ExecuteReader();

            return GetRowsList(reader, columns);
        }

        public void SaveData(string saveCommand)
        {
            Connect();
            NpgsqlCommand saveDaCommand = new NpgsqlCommand(saveCommand, connection);

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(saveDaCommand);
            adapter.SelectCommand.ExecuteNonQuery();

            Disconnect();
        }

        protected abstract T readRow(NpgsqlDataReader reader, string[] columns = null);

        protected List<T> GetRowsList(NpgsqlDataReader reader, string[] columns = null)
        {
            List<T> result = new List<T>();
            while (reader.Read())
            {
                result.Add(readRow(reader, columns));
            }

            Disconnect();

            return result;
        }


    }
}
