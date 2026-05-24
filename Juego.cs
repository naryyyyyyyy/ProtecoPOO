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
        public abstract decimal Jugar(decimal montoApuesta);
        protected Juego(string nombre, int juegoId)
        {
            Nombre = nombre;
            JuegoId = juegoId;
        }
    }
}
