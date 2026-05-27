using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite; // <-- El nuevo paquete

namespace ProtecoPOO.CasinoSQL
{
    public static class SqlConnectionExtensions
    {
        public static int ExecuteNonQuery(this SQLiteConnection conn, string commandText)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = commandText;
            return cmd.ExecuteNonQuery();
        }

        public static int ExecuteNonQuery(this SQLiteConnection conn,
                                          string commandText,
                                          params (string, object)[] parameters)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = commandText;

            foreach (var (name, value) in parameters)
            {
                cmd.Parameters.AddWithValue(name, value);
            }

            return cmd.ExecuteNonQuery();
        }

        public static SQLiteDataReader ExecuteReader(this SQLiteConnection conn,
                                                     string commandText)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = commandText;
            return cmd.ExecuteReader();
        }

        public static SQLiteDataReader ExecuteReader(this SQLiteConnection conn,
                                                     string commandText,
                                                     params (string, object)[] parameters)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = commandText;

            foreach (var (name, value) in parameters)
            {
                cmd.Parameters.AddWithValue(name, value);
            }

            return cmd.ExecuteReader();
        }

        public static string GetString(this SQLiteDataReader reader, string name)
            => reader.GetString(reader.GetOrdinal(name));

        public static int GetInt(this SQLiteDataReader reader, string name)
            => reader.GetInt32(reader.GetOrdinal(name));

        public static double GetDouble(this SQLiteDataReader reader, string name)
            => reader.GetDouble(reader.GetOrdinal(name));
    }
}