using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class ReporteAdmin
    {

        public string Jugador { get; set; }
        public string Personaje { get; set; }
        public string Juego { get; set; }
        public double SaldoInicial { get; set; }
        public int Reapuestas { get; set; }
        public double GananciaPerdida { get; set; }
        public ReporteAdmin(string jugador, string personaje, string juego, double saldoInicial, int reapuestas, double gananciaPerdida)
        {
            Jugador = jugador;
            Personaje = personaje;
            Juego = juego;
            SaldoInicial = saldoInicial;
            Reapuestas = reapuestas;
            GananciaPerdida = gananciaPerdida;
        }
        public ReporteAdmin() { }
    }
}
