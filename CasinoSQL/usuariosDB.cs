using System.Data.SQLite;
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
        private string cadenaConexion;
        public usuariosDB()
        {
            string rutaEjecutable = AppDomain.CurrentDomain.BaseDirectory;

            string rutaProyecto = System.IO.Path.GetFullPath(System.IO.Path.Combine(rutaEjecutable, @"..\..\..\CasinoSQL\CasinoDB.db"));

            cadenaConexion = $"Data Source={rutaProyecto};";
        }
        public bool UsuarioExistente(string nombre, string contrasena)
        {
            // 'using' asegura que la conexión se cierre automáticamente al terminar
            using (var conn = new SQLiteConnection(cadenaConexion))
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
        public void AgregarUsuario(string nombre, string contrasena, int personajeId)
        {
            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                string query = "INSERT INTO usuarios (Nombre, Contrasena, Saldo, PersonajeId) VALUES\r\n(@nombre, @contrasena, 1000, @personajeid);";

                conn.ExecuteNonQuery(query, 
                    ("@nombre", nombre), 
                    ("@contrasena", contrasena), 
                    ("1000",1000),
                    ("@personajeid", personajeId));
            }
        }
        public void BorrarUsuario(int UsuarioId)
        {
            using (var conn = new SQLiteConnection(cadenaConexion))
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
        /*public void AgregarRegistroPartida(int usuarioId, int juegoId, decimal saldoInicial, int numReapuestas, decimal ganancia)
        {
            RegistroPartida partida = new RegistroPartida(usuarioId, juegoId, saldoInicial, numReapuestas, ganancia);

            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();
                string query = "INSERT INTO historial_juegos (UsuarioId, JuegoId, SaldoInicial, NumReapuestas, Ganancia) \r\nVALUES (@usuarioId, @juegoid, @saldoInicial, @numReapuestas, @ganancia);";
                conn.ExecuteNonQuery(query,
                ("@usuarioId", partida.UsuarioId),
                ("@juegoid", partida.JuegoId),
                ("@saldoInicial", partida.SaldoInicial),
                ("@numReapuestas", partida.NumReapuestas),
                ("@ganancia", partida.GananciaPerdida)
                );
            }
        }*/

        public void AgregarRegistroPartida(RegistroPartida registro)
        {
            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();
                string query = "INSERT INTO historial_juegos (UsuarioId, JuegoId, SaldoInicial, NumReapuestas, Ganancia) \r\nVALUES (@usuarioId, @juegoid, @saldoInicial, @numReapuestas, @ganancia);";
                conn.ExecuteNonQuery(query,
                ("@usuarioId", registro.UsuarioId),
                ("@juegoid", registro.JuegoId),
                ("@saldoInicial", registro.SaldoInicial),
                ("@numReapuestas", registro.NumReapuestas),
                ("@ganancia", registro.GananciaPerdida)
                );
            }
        }
        
        public bool ContrasenaValida(int idUsuario, string contrasena)
        {
            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                string query = @"SELECT COUNT(1) 
                                FROM administradores 
                                WHERE Id = @idUsuario AND Contrasena = @contrasena;";

                using (var rs = conn.ExecuteReader(query, ("@idUsuario", idUsuario), ("@contrasena", contrasena)))
                {
                    if (rs.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public List<Usuario> GetAllUsuarios()
        {
            var usuarios = new List<Usuario>();

            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT Id, Nombre 
                                FROM personajes 
                                ORDER BY Id ASC;";

                var rs = conn.ExecuteReader(query);
                while (rs.Read())
                {
                    usuarios.Add(new Usuario(rs.GetString("Nombre"),
                                             rs.GetInt("Id"),
                                             ""));
                }
            }

            return usuarios;
        }
    }
}
