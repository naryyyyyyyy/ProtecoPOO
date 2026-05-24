
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class BlackJack : Juego
    {
        public BlackJack(string nombre, int id) : base(nombre,id)
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
