using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ProtecoPOO.CasinoSQL
{
    public class ReportesDB
    {
        private string cadenaConexion = "Data Source=CasinoDB.db;";
        public List<Personaje> GetAllPersonajes()
        {
            var personajes = new List<Personaje>();

            using (var conn = new SqliteConnection(cadenaConexion))
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
        public List<Juego> GetAllJuegos()
        {
            var juegos = new List<Juego>();

            using (var conn = new SqliteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT Id, Nombre 
                                FROM juegos 
                                ORDER BY Id ASC;";

                var rs = conn.ExecuteReader(query);
                while (rs.Read())
                {
                    int id = rs.GetInt("Id");

                    string nombreJuegoDb = rs.GetString("Nombre");
                    string nombreClase = FormatearNombreClase(nombreJuegoDb);

                    // PASO 2: Le decimos a la Reflexión que busque esa clase en tu proyecto.
                    
                    Type tipoClase = Type.GetType($"ProtecoPOO.{nombreClase}");

                    // PASO 3: Si encontró la clase, la construye y la agrega a la lista
                    if (tipoClase != null)
                    {
                        Juego juegoInstancia = (Juego)Activator.CreateInstance(tipoClase, new object[] { nombreJuegoDb, id });
                        juegos.Add(juegoInstancia);
                    }
                }
            }

            return juegos;
        }
        public List<Usuario> GetUsuariosPorPersonaje(string personaje)
        {
            var filtro = new List<Usuario>();

            using (var conn = new SqliteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT 
                                    u.Id AS UsuarioId, 
                                    u.Nombre AS Jugador, 
                                    u.Saldo, 
                                    p.Nombre AS PersonajeElegido
                                FROM usuarios u
                                INNER JOIN personajes p ON u.PersonajeId = p.Id
                                WHERE p.Nombre = @nombrePersonaje;";

                var rs = conn.ExecuteReader(query, ("@nombrePersonaje", personaje));
                while (rs.Read())
                {
                    filtro.Add(new Usuario(rs.GetString("Nombre"),
                                           rs.GetInt("Id"),
                                           "",
                                           Convert.ToDecimal(rs.GetDouble("Saldo"))));
                }
            }

            return filtro;
        }
        public List<Usuario> GetUsuariosPorPersonaje(int personajeId)
        {
            var filtro = new List<Usuario>();

            using (var conn = new SqliteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT Id, Nombre, Saldo 
                                FROM usuarios 
                                WHERE PersonajeId = @idPersonaje;";

                var rs = conn.ExecuteReader(query, ("@idPersonaje", personajeId));
                while (rs.Read())
                {
                    filtro.Add(new Usuario(rs.GetString("Nombre"),
                                           rs.GetInt("Id"),
                                           "",
                                           Convert.ToDecimal(rs.GetDouble("Saldo"))));
                }
            }

            return filtro;
        }
        public string FormatearNombreClase(string nombreDb)
        {
            // Si el texto viene vacío o nulo, lo regresamos tal cual para evitar errores
            if (string.IsNullOrWhiteSpace(nombreDb))
            {
                return string.Empty;
            }

            // 1. Separamos el texto en palabras usando los espacios como divisores
            string[] palabras = nombreDb.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < palabras.Length; i++)
            {
                // 2. Convertimos toda la palabra a minúsculas por seguridad (ej. "CABALLOS" -> "caballos")
                string palabra = palabras[i].ToLower();

                // 3. Volvemos mayúscula solo la primera letra y le pegamos el resto de la palabra
                palabras[i] = char.ToUpper(palabra[0]) + palabra.Substring(1);
            }

            // 4. Unimos todas las palabras del arreglo sin ningún espacio entre ellas
            return string.Join("", palabras);
        }
        public List<Usuario> GetUsuariosPorJuego(string juego)
        {
            var filtro = new List<Usuario>();

            using (var conn = new SqliteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT DISTINCT 
                                u.Id AS UsuarioId, 
                                u.Nombre AS Jugador, 
                                u.Saldo
                                FROM usuarios u
                                INNER JOIN historial_juegos h ON u.Id = h.UsuarioId
                                INNER JOIN juegos j ON h.JuegoId = j.Id
                                WHERE j.Nombre = @nombreJuego;";

                var rs = conn.ExecuteReader(query, ("@nombrejuego", juego));
                while (rs.Read())
                {
                    filtro.Add(new Usuario(rs.GetString("Nombre"),
                                           rs.GetInt("Id"),
                                           "",
                                           Convert.ToDecimal(rs.GetDouble("Saldo"))));
                }
            }

            return filtro;
        }
        public List<Usuario> GetUsuariosPorJuego(int juegoId)
        {
            var filtro = new List<Usuario>();

            using (var conn = new SqliteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT DISTINCT u.Id, u.Nombre, u.Saldo 
                                 FROM usuarios u
                                 INNER JOIN historial_juegos h ON u.Id = h.UsuarioId
                                 WHERE h.JuegoId = @idJuego;";

                var rs = conn.ExecuteReader(query, ("@nombrejuego", juegoId));
                while (rs.Read())
                {
                    filtro.Add(new Usuario(rs.GetString("Nombre"),
                                           rs.GetInt("Id"),
                                           "",
                                           Convert.ToDecimal(rs.GetDouble("Saldo"))));
                }
            }

            return filtro;
        }

    }
}
