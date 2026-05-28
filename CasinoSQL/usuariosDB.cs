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

            string rutaProyecto = System.IO.Path.GetFullPath(System.IO.Path.Combine(rutaEjecutable, @"..\..\..\CasinoSQL\BaseDatosPoo.db"));

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
            using (var conn = new System.Data.SQLite.SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                // Armamos un query doble. 
                // Primero inserta al usuario, luego inserta a su personaje inicial.
                string query = @"
            INSERT INTO usuarios (Nombre, Contrasena) 
            VALUES (@nombre, @contrasena);

            INSERT INTO personajes_guardados (UsuarioId, PersonajeId, Saldo, EstaVivo) 
            VALUES (last_insert_rowid(), @personajeid, 1000, 1);";

                // Ejecutamos usando tu método de extensión mágico
                conn.ExecuteNonQuery(query,
                    ("@nombre", nombre),
                    ("@contrasena", contrasena),
                    ("@personajeid", personajeId)
                );
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

                string query = @"SELECT Id 
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
                                FROM Usuarios
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
        public List<Personaje> GetAllPersonajes()
        {
            var personajes = new List<Personaje>();

            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT Id, Nombre 
                                FROM personajes 
                                ORDER BY Id ASC;";

                var rs = conn.ExecuteReader(query);
                while (rs.Read())
                {
                    personajes.Add(new Personaje(rs.GetString("Nombre"),
                                             rs.GetInt("Id")));
                }
            }

            return personajes;
        }
        public List<ElementoCombo> GetAllJuegos()
        {
            var listaJuegos = new List<ElementoCombo>();

            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();
                // Leemos solo el ID y el Nombre directamente de la tabla
                string query = @"SELECT Id, Nombre
                                 FROM juegos ORDER BY Id ASC;";
                var rs = conn.ExecuteReader(query);

                while (rs.Read())
                {
                    listaJuegos.Add(new ElementoCombo
                    {
                        Id = rs.GetInt32(rs.GetOrdinal("Id")),
                        Nombre = rs.GetString(rs.GetOrdinal("Nombre"))
                    });
                }
            }

            return listaJuegos;
        }
        public List<RegistroPartida> ObtenerHistorialPersonajeActual(int idUsuario, int idPersonajeGuardado)
        {
            var historial = new List<RegistroPartida>();

            using (var conn = new System.Data.SQLite.SQLiteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT h.Id, h.UsuarioId, h.JuegoId, h.PersonajeId, 
                                h.SaldoInicial, h.NumReapuestas, h.GananciaPerdida,
                                j.Nombre AS NombreJuego
                                FROM historial_juegos h
                                INNER JOIN juegos j ON h.JuegoId = j.Id
                                WHERE h.UsuarioId = @idUsuario AND h.PersonajeId = @idPersonajeGuardado
                                ORDER BY h.Id DESC;";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@idPersonajeGuardado", idPersonajeGuardado);

                    using (var rs = cmd.ExecuteReader())
                    {
                        while (rs.Read())
                        {
                            historial.Add(new RegistroPartida
                            {
                                // Llenamos los datos técnicos...
                                Id = rs.GetInt32(rs.GetOrdinal("Id")),
                                UsuarioId = rs.GetInt32(rs.GetOrdinal("UsuarioId")),
                                JuegoId = rs.GetInt32(rs.GetOrdinal("JuegoId")),
                                PersonajeId = rs.GetInt32(rs.GetOrdinal("PersonajeId")),
                                SaldoInicial = Convert.ToDecimal(rs.GetValue(rs.GetOrdinal("SaldoInicial"))),
                                NumReapuestas = rs.GetInt32(rs.GetOrdinal("NumReapuestas")),
                                GananciaPerdida = Convert.ToDecimal(rs.GetValue(rs.GetOrdinal("GananciaPerdida"))),

                                // Y llenamos el texto visual para la tabla
                                NombreJuego = rs.GetString(rs.GetOrdinal("NombreJuego"))
                            });
                        }
                    }
                }
            }
            return historial;
        }
        public List<PersonajeGuardado> ObtenerPersonajesDelUsuario(int usuarioId)
        {
            var listaPersonajes = new List<PersonajeGuardado>();

            using (var conn = new System.Data.SQLite.SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                // Hacemos el JOIN para traernos el Nombre del catálogo
                string query = @"SELECT pg.Id, 
                                pg.UsuarioId,
                                pg.PersonajeId, 
                                p.Nombre, 
                                pg.Saldo, 
                                pg.EstaVivo
                         FROM personajes_guardados pg
                         INNER JOIN personajes p ON pg.PersonajeId = p.Id
                         WHERE pg.UsuarioId = @usuarioId
                         ORDER BY pg.Id ASC;";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuarioId", usuarioId);

                    using (var rs = cmd.ExecuteReader())
                    {
                        while (rs.Read())
                        {
                            listaPersonajes.Add(new PersonajeGuardado
                            {
                                Id = rs.GetInt32(rs.GetOrdinal("Id")),
                                UsuarioId = rs.GetInt32(rs.GetOrdinal("UsuarioId")),
                                PersonajeId = rs.GetInt32(rs.GetOrdinal("PersonajeId")),
                                Saldo = Convert.ToDouble(rs.GetValue(rs.GetOrdinal("Saldo"))),
                                EstaVivo = rs.GetInt32(rs.GetOrdinal("EstaVivo")) == 1,

                                // Llenamos el bolsillo extra visual
                                Nombre = rs.GetString(rs.GetOrdinal("Nombre"))
                            });
                        }
                    }
                }
            }

            return listaPersonajes;
        }

        public int ObtenerIdUsuario(string nombre, string contrasena)
        {
            using (var conn = new System.Data.SQLite.SQLiteConnection(cadenaConexion))
            {
                conn.Open();
                string query = "SELECT Id FROM usuarios WHERE Nombre = @nombre AND Contrasena = @contrasena;";

                using (var rs = conn.ExecuteReader(query, ("@nombre", nombre), ("@contrasena", contrasena)))
                {
                    if (rs.Read())
                    {
                        return rs.GetInt32(0); // Devuelve el ID numérico
                    }
                }
            }
            return 0; // Por si algo falla
        }
    }
}
