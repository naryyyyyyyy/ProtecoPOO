using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class CarreraDeCaballos : Juego
    {
        public CarreraDeCaballos(string nombre, int juegoId) : base(nombre, juegoId)
        {
        }
        public override decimal Jugar(decimal montoApuesta)
        {
            decimal ganancia = 0;

            // Toda la lógica de los caballos, randoms, etc...

            return ganancia;
        }
    }
}
