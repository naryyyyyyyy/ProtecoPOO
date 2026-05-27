using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO.CasinoSQL
{
    public class ReportesDB
    {
        private string cadenaConexion;
        public ReportesDB()
        {
            string rutaEjecutable = AppDomain.CurrentDomain.BaseDirectory;

            string rutaProyecto = System.IO.Path.GetFullPath(System.IO.Path.Combine(rutaEjecutable, @"..\..\..\CasinoSQL\CasinoDB.db"));

            cadenaConexion = $"Data Source={rutaProyecto};";
        }

        // 1. FILTRO POR JUEGO
        public List<ReporteAdmin> GetReportePorJuego(string nombreJuego)
        {
            var reporte = new List<ReporteAdmin>();
            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT u.Nombre AS Jugador, p.Nombre AS Personaje, j.Nombre AS Juego, 
                                        h.SaldoInicial, h.NumReapuestas, h.GananciaPerdida
                                 FROM historial_juegos h
                                 INNER JOIN usuarios u ON h.UsuarioId = u.Id
                                 INNER JOIN juegos j ON h.JuegoId = j.Id
                                 INNER JOIN personajes_guardados pg ON h.PersonajeId = pg.Id
                                 INNER JOIN personajes p ON pg.PersonajeId = p.Id
                                 WHERE j.Nombre LIKE @filtro
                                 ORDER BY h.Id DESC;";

                // Le agregamos los '%' para que busque coincidencias parciales
                var rs = conn.ExecuteReader(query, ("@filtro", "%" + nombreJuego + "%"));

                while (rs.Read())
                {
                    reporte.Add(new ReporteAdmin
                    {
                        Jugador = rs.GetString("Jugador"),
                        Personaje = rs.GetString("Personaje"),
                        Juego = rs.GetString("Juego"),
                        SaldoInicial = rs.GetDouble("SaldoInicial"),
                        Reapuestas = rs.GetInt("NumReapuestas"),
                        GananciaPerdida = rs.GetDouble("GananciaPerdida")
                    });
                }
            }
            return reporte;
        }

        // 2. FILTRO POR PERSONAJE
        public List<ReporteAdmin> GetReportePorPersonaje(string nombrePersonaje)
        {
            var reporte = new List<ReporteAdmin>();
            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT u.Nombre AS Jugador, p.Nombre AS Personaje, j.Nombre AS Juego, 
                                        h.SaldoInicial, h.NumReapuestas, h.GananciaPerdida
                                 FROM historial_juegos h
                                 INNER JOIN usuarios u ON h.UsuarioId = u.Id
                                 INNER JOIN juegos j ON h.JuegoId = j.Id
                                 INNER JOIN personajes_guardados pg ON h.PersonajeId = pg.Id
                                 INNER JOIN personajes p ON pg.PersonajeId = p.Id
                                 WHERE p.Nombre LIKE @filtro
                                 ORDER BY h.Id DESC;";

                var rs = conn.ExecuteReader(query, ("@filtro", "%" + nombrePersonaje + "%"));

                while (rs.Read())
                {
                    reporte.Add(new ReporteAdmin
                    {
                        Jugador = rs.GetString("Jugador"),
                        Personaje = rs.GetString("Personaje"),
                        Juego = rs.GetString("Juego"),
                        SaldoInicial = rs.GetDouble("SaldoInicial"),
                        Reapuestas = rs.GetInt("NumReapuestas"),
                        GananciaPerdida = rs.GetDouble("GananciaPerdida")
                    });
                }
            }
            return reporte;
        }

        // 3. FILTRO POR USUARIO
        public List<ReporteAdmin> GetReportePorUsuario(string nombreUsuario)
        {
            var reporte = new List<ReporteAdmin>();
            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();
                string query = @"SELECT u.Nombre AS Jugador, p.Nombre AS Personaje, j.Nombre AS Juego, 
                                        h.SaldoInicial, h.NumReapuestas, h.GananciaPerdida
                                 FROM historial_juegos h
                                 INNER JOIN usuarios u ON h.UsuarioId = u.Id
                                 INNER JOIN juegos j ON h.JuegoId = j.Id
                                 INNER JOIN personajes_guardados pg ON h.PersonajeId = pg.Id
                                 INNER JOIN personajes p ON pg.PersonajeId = p.Id
                                 WHERE u.Nombre LIKE @filtro
                                 ORDER BY h.Id DESC;";

                var rs = conn.ExecuteReader(query, ("@filtro", "%" + nombreUsuario + "%"));

                while (rs.Read())
                {
                    reporte.Add(new ReporteAdmin
                    {
                        Jugador = rs.GetString("Jugador"),
                        Personaje = rs.GetString("Personaje"),
                        Juego = rs.GetString("Juego"),
                        SaldoInicial = rs.GetDouble("SaldoInicial"),
                        Reapuestas = rs.GetInt("NumReapuestas"),
                        GananciaPerdida = rs.GetDouble("GananciaPerdida")
                    });
                }
            }
            return reporte;
        }

        public List<ReporteAdmin> GetReporteGlobalHistorial()
        {
            var reporte = new List<ReporteAdmin>();

            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                // El Query maestro: Une el historial con los nombres de juegos, usuarios y personajes
                string query = @"SELECT 
                            u.Nombre AS Jugador, 
                            p.Nombre AS Personaje, 
                            j.Nombre AS Juego, 
                            h.SaldoInicial, 
                            h.NumReapuestas, 
                            h.GananciaPerdida
                         FROM historial_juegos h
                         INNER JOIN usuarios u ON h.UsuarioId = u.Id
                         INNER JOIN juegos j ON h.JuegoId = j.Id
                         INNER JOIN personajes_guardados pg ON h.PersonajeId = pg.Id
                         INNER JOIN personajes p ON pg.PersonajeId = p.Id
                         ORDER BY h.Id DESC;"; // ORDER BY h.Id DESC muestra las partidas más recientes primero

                // Como no hay parámetros, usamos la extensión simple
                var rs = conn.ExecuteReader(query);

                while (rs.Read())
                {
                    // Construimos el objeto del reporte usando tus métodos de extensión mágicos
                    ReporteAdmin fila = new ReporteAdmin
                    {
                        Jugador = rs.GetString("Jugador"),
                        Personaje = rs.GetString("Personaje"),
                        Juego = rs.GetString("Juego"),
                        SaldoInicial = rs.GetDouble("SaldoInicial"),
                        Reapuestas = rs.GetInt("NumReapuestas"),
                        GananciaPerdida = rs.GetDouble("GananciaPerdida")
                    };

                    reporte.Add(fila);
                }
            }

            return reporte;
        }

        public List<Administrador> GetAllAdministradores()
        {
            List<Administrador> listaAdmins = new List<Administrador>();

            using (var conn = new SQLiteConnection(cadenaConexion))
            {
                conn.Open();

                string query = @"SELECT Id, Nombre, Contrasena 
                                FROM administradores 
                                ORDER BY Nombre ASC;";

                using (var rs = conn.ExecuteReader(query))
                {
                    while (rs.Read())
                    {
                        int id = rs.GetInt("Id");
                        string nombre = rs.GetString("Nombre");
                        string contrasena = rs.GetString("Contrasena");

                        Administrador adminEncontrado = new Administrador(id, nombre, contrasena);

                        listaAdmins.Add(adminEncontrado);
                    }
                }
            }

            return listaAdmins;
        }

    }
}
