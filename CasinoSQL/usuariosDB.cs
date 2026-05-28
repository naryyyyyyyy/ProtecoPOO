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

        public int ObtenerPersonajeSeleccionado(int usuarioId)
        {
            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                string query = @"SELECT PersonajeId
                         FROM usuarios
                         WHERE Id = @id";

                using (var rs = conn.ExecuteReader(query, ("@id", usuarioId)))
                {
                    if (rs.Read())
                    {
                        return rs.GetInt32(0);
                    }
                }
            }

            return 1; // Bárbaro por defecto
        }
        public string ObtenerPersonajeMasJugado(int idUsuario)
        {
            using (var conn = new System.Data.SQLite.SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                // Agrupamos por personaje, contamos las partidas, ordenamos de mayor a menor y sacamos el #1
                string query = @"SELECT p.Nombre, COUNT(h.Id) AS TotalPartidas
                 FROM historial_juegos h
                 INNER JOIN personajes_guardados pg ON h.PersonajeId = pg.Id
                 INNER JOIN personajes p ON pg.PersonajeId = p.Id
                 WHERE h.UsuarioId = @idUsuario
                 GROUP BY h.PersonajeId, p.Nombre
                 ORDER BY TotalPartidas DESC
                 LIMIT 1;";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    using (var rs = cmd.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            string nombrePersonaje = rs.GetString(rs.GetOrdinal("Nombre"));
                            int totalPartidas = rs.GetInt32(rs.GetOrdinal("TotalPartidas"));

                            return $"{nombrePersonaje} ({totalPartidas} partidas)";
                        }
                    }
                }
            }

            // Si el usuario acaba de crear su cuenta y no ha jugado nada, devolvemos este texto
            return "Aún no hay partidas registradas";
        }
        public string ObtenerPersonajeMasRico(int idUsuario)
        {
            using (var conn = new System.Data.SQLite.SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                // Unimos el inventario con el catálogo, ordenamos por dinero y tomamos el #1
                string query = @"SELECT p.Nombre, pg.Saldo
                 FROM personajes_guardados pg
                 INNER JOIN personajes p ON pg.PersonajeId = p.Id
                 WHERE pg.UsuarioId = @idUsuario
                 ORDER BY pg.Saldo DESC
                 LIMIT 1;";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    using (var rs = cmd.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            string nombrePersonaje = rs.GetString(rs.GetOrdinal("Nombre"));
                            double saldoMayor = Convert.ToDouble(rs.GetValue(rs.GetOrdinal("Saldo")));

                            return $"{nombrePersonaje} (${saldoMayor})";
                        }
                    }
                }
            }

            // Por si ocurre alguna anomalía y el usuario no tiene personajes
            return "Sin personajes disponibles";
        }
        public void ActualizarSaldoPersonaje(int idRanura, double nuevoSaldo)
        {
            using (var conn = new System.Data.SQLite.SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                // Actualizamos ÚNICAMENTE la ranura específica, no todo el usuario
                string query = @"UPDATE personajes_guardados 
                 SET Saldo = @nuevoSaldo 
                 WHERE Id = @idRanura;";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                {
                    // Pasamos los valores seguros para evitar inyecciones SQL
                    cmd.Parameters.AddWithValue("@nuevoSaldo", nuevoSaldo);
                    cmd.Parameters.AddWithValue("@idRanura", idRanura);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void BorrarPersonajeCompletamente(int idRanura)
        {
            using (var conn = new System.Data.SQLite.SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                // El orden es vital: Primero borramos las partidas, luego la ranura del personaje
                string query = @"
    DELETE FROM historial_juegos WHERE PersonajeId = @idRanura;
    DELETE FROM personajes_guardados WHERE Id = @idRanura;";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                {
                    // Usamos el ID exacto de la ranura para no tocar a los otros personajes del usuario
                    cmd.Parameters.AddWithValue("@idRanura", idRanura);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public System.Data.DataTable ReportePersonajesPorSaldo(int idUsuario)
        {
            var tabla = new System.Data.DataTable();

            using (var conn = new System.Data.SQLite.SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                string query = @"SELECT p.Nombre AS Personaje, pg.Saldo 
                         FROM personajes_guardados pg
                         INNER JOIN personajes p ON pg.PersonajeId = p.Id
                         WHERE pg.UsuarioId = @idUsuario
                         ORDER BY pg.Saldo DESC;";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    using (var rs = cmd.ExecuteReader())
                    {
                        tabla.Load(rs);
                    }
                }
            }

            return tabla;
        }
        public System.Data.DataTable ReportePersonajesPorReapuestas(int idUsuario)
        {
            var tabla = new System.Data.DataTable();

            using (var conn = new System.Data.SQLite.SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                // Sumamos las reapuestas de cada partida y agrupamos por el ID de la ranura del personaje
                string query = @"SELECT p.Nombre AS Personaje, SUM(h.NumReapuestas) AS TotalReapuestas 
                         FROM historial_juegos h
                         INNER JOIN personajes_guardados pg ON h.PersonajeId = pg.Id
                         INNER JOIN personajes p ON pg.PersonajeId = p.Id
                         WHERE h.UsuarioId = @idUsuario
                         GROUP BY pg.Id, p.Nombre
                         ORDER BY TotalReapuestas DESC;";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    using (var rs = cmd.ExecuteReader())
                    {
                        tabla.Load(rs);
                    }
                }
            }

            return tabla;
        }
    }
}
