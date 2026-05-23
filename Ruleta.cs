
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class Ruleta : Juego
    {
        public Ruleta()
        {
            Nombre = "Ruleta";
            JuegoId = 2;
        }

        public override decimal Jugar(decimal montoApuesta)
        {
            decimal ganancia = 0;

            // Toda la lógica de los caballos, randoms, etc...

            return ganancia;
        }
    }
}
