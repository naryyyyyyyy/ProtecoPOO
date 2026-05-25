using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public abstract class Juego
    {
        /*
        public string Nombre { get; }
        public int JuegoId { get; }
        public abstract decimal Jugar(decimal montoApuesta);
        protected Juego(string nombre, int juegoId)
        {
            Nombre = nombre;
            JuegoId = juegoId;
        }*/
        public string Nombre { get; }
        public int JuegoId { get; }

        // El saldo actual en memoria mientras el jugador está dentro de esta ventana
        public decimal SaldoJugador { get; protected set; }

        // La cantidad que se está arriesgando en la mano actual
        public decimal ApuestaActual { get; protected set; }

        protected Juego(string nombre, int juegoId)
        {
            Nombre = nombre;
            JuegoId = juegoId;
        }

        // Método para cargar el saldo inicial traído de la base de datos al abrir la ventana
        public void CargarSaldoInicial(decimal saldoInicial)
        {
            SaldoJugador = saldoInicial;
        }

        // VALIDACIÓN DEL PUNTO 2: Verifica si el jugador tiene fondos suficientes
        public bool ValidarYColocarApuesta(decimal montoApuesta)
        {
            // Si intenta apostar más de lo que tiene o cantidades negativas, no lo deja
            if (montoApuesta <= 0 || montoApuesta > SaldoJugador)
            {
                return false;
            }

            ApuestaActual = montoApuesta;
            SaldoJugador -= montoApuesta; // Se retiene la apuesta del saldo temporal
            return true;
        }

        // Método abstracto que cada juego implementará a su manera para calcular premios
        public abstract decimal Jugar(decimal montoApuesta);

        // Actualiza el saldo sumando las ganancias obtenidas al terminar la mano
        public void RegistrarResultado(decimal ganancias)
        {
            SaldoJugador += ganancias;
        }
    }
}
