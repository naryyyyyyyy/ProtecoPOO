using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bj;
using Microsoft.Data.Sqlite;

namespace ProtecoPOO.CasinoSQL
{
    public class ReportesDB
    {
        private string cadenaConexion = "Data Source=CasinoDB.db;";
        public List<Usuario> GetUsuariosPorPersonaje(string personaje)
        {
            var filtro = new List<Usuario>();

            using (var conn = new SqliteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT u.Id, u.Nombre, u.Saldo, p.Nombre AS Personaje 
                         FROM usuarios u
                         INNER JOIN personajes p ON u.PersonajeId = p.Id
                         WHERE p.Nombre = @personajeBuscado;";

                var rs = conn.ExecuteReader(query, ("@personaje", personaje));
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

                    // Obtenemos el nombre tal como viene de SQL (ej. "Carrera de caballos")
                    string nombreJuegoDb = rs.GetString("Nombre");

                    // PASO 1: Formateamos el texto (queda como "CarreraDeCaballos")
                    string nombreClase = FormatearNombreClase(nombreJuegoDb);

                    // PASO 2: Le decimos a la Reflexión que busque esa clase en tu proyecto.
                    // IMPORTANTE: Cambia "ProtecoPOO" por el nombre del espacio de nombres (namespace) 
                    // donde tengas guardadas tus clases de juegos (como vi en tu captura que usabas "bj").
                    Type tipoClase = Type.GetType($"ProtecoPOO.{nombreClase}");

                    // PASO 3: Si encontró la clase, la construye y la agrega a la lista
                    if (tipoClase != null)
                    {
                        Juego juegoInstancia = (Juego)Activator.CreateInstance(tipoClase);
                        juegos.Add(juegoInstancia);
                    }
                }
            }

            return juegos;
        }
    }
}
