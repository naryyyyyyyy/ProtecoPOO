using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ProtecoPOO.CasinoSQL
{
    public class usuariosDB
    {
        private string cadenaConexion = "Data Source=CasinoDB.db;";

        // Método para inicializar la base de datos (crear las tablas si no existen)
        public void CrearTablaSiNoExiste()
        {
            // El bloque 'using' abre la conexión y la cierra automáticamente al terminar
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open(); // Abrimos la conexión

                string sql = @"CREATE TABLE IF NOT EXISTS Historial (
                                  Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                  NombreJuego TEXT,
                                  Ganancia DECIMAL
                               );";

                // AQUÍ usamos el método de tu archivo SqlConnectionExtensions.cs
                conexion.ExecuteNonQuery(sql);
            }
        }

        public void GuardarRegistro(string nombreJuego, decimal ganancia)
        {
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();

                string sql = "INSERT INTO Historial (NombreJuego, Ganancia) VALUES (@juego, @ganancia)";

                // Otra vez usamos tu archivo, pasándole los parámetros súper fácil
                conexion.ExecuteNonQuery(sql,
                    ("@juego", nombreJuego),
                    ("@ganancia", ganancia)
                );
            }
        }
    }
}
