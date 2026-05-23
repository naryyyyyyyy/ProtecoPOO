using bj;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtecoPOO.CasinoSQL
{
    public class usuariosDB
    {
        private string cadenaConexion = "Data Source=CasinoDB.db;";
        public bool UsuarioExistente(string nombre, string contrasena)
        {
            // 'using' asegura que la conexión se cierre automáticamente al terminar
            using (var conn = new SqliteConnection(cadenaConexion))
            {
                conn.Open();

                string query = "SELECT Id FROM usuarios WHERE Nombre = @nombre AND Contrasena = @contrasena;";

                using (var rs = conn.ExecuteReader(query, ("@nombre", nombre), ("@contrasena", contrasena)))
                {
                    if (rs.Read())
                    {
                        return true; // El usuario existe y la contraseña es correcta
                    }
                    else
                    {
                        return false; // El usuario no existe o la contraseña está mal
                    }
                }
            }
        }
        public void AgregarUsuario(string nombre, string contrasena, string personaje)
        {
            using (var conn = new SqliteConnection(cadenaConexion))
            {
                conn.Open();

                string query = "INSERT INTO Usuarios (Nombre, Contrasena, Saldo, Personaje) VALUES (@nombre, @contrasena, 1000, @personaje);";

                conn.ExecuteNonQuery(query, 
                    ("@nombre", nombre), 
                    ("@contrasena", contrasena), 
                    ("1000",1000),
                    ("@personaje", personaje));
            }
        }
        public void BorrarUsuario(int UsuarioId)
        {
            using (var conn = new SqliteConnection(cadenaConexion))
            {
                conn.Open();

                // Limpiar el historial del usuario
                string queryHistorial = "DELETE FROM historial_juegos WHERE UsuarioId = @id;";
                conn.ExecuteNonQuery(queryHistorial, ("@id", UsuarioId));

                // Borrar al usuario de la base de datos
                string queryUsuario = "DELETE FROM usuarios WHERE Id = @id;";
                conn.ExecuteNonQuery(queryUsuario, ("@id", UsuarioId));
            }
        }
        public List<Usuario> UsuariosPorPersonaje(string personaje)
        {
            var filtro = new List<Usuario>();
            using (var conn = new SqliteConnection(cadenaConexion))
            {
                string query = "SELECT Id, Nombre, Saldo, Personaje\r\nFROM usuarios\r\nWHERE Personaje = @personaje;";

                var rs = conn.ExecuteReader(query, ("@personaje", personaje));
                while (rs.Read())
                {
                    filtro.Add(new Usuario(rs.GetString("Nombre"),
                                           rs.GetInt("Id"),
                                           "",
                                           rs.GetDouble("Saldo")));
                }
            }
            return filtro;
        }
        

    }
}
