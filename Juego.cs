using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public abstract class Juego
    {
       
        public string Nombre { get; }
        public int JuegoId { get; }

       
        public decimal SaldoJugador { get; protected set; }

        
        public decimal ApuestaActual { get; protected set; }

        protected Juego(string nombre, int juegoId)
        {
            Nombre = nombre;
            JuegoId = juegoId;
        }

        public void CargarSaldoInicial(decimal saldoInicial)
        {
            SaldoJugador = saldoInicial;
        }

        public bool ValidarYColocarApuesta(decimal montoApuesta)
        {
            if (montoApuesta <= 0 || montoApuesta > SaldoJugador)
            {
                return false;
            }

            ApuestaActual = montoApuesta;
            SaldoJugador -= montoApuesta;
            return true;
        }

        public void RegistrarResultado(decimal ganancias)
        {
            SaldoJugador += ganancias;
        }
        public virtual decimal CalcularPagoEstandar(string dictamen)
        {
            if (dictamen == "GANASTE")
            {
                return ApuestaActual * 2;
            }
            if (dictamen == "EMPATE")
            {
                return ApuestaActual;
            }
            return 0;
        }
    }
}
