using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO.Ruleta
{
    public class Apuesta
    {
        public Apuesta(int numero, string color, decimal monto)
        {
            Numero = numero;
            Color = color;
            Monto = monto;
        }

        public int Numero { get; set; }
        public string Color { get; set; }
        public decimal Monto { get; set; }
    }
}
