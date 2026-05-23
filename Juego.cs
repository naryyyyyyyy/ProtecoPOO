using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public abstract class Juego
    {
        public string Nombre { get; protected set; }
        public int JuegoId { get; protected set; }
        public abstract decimal Jugar(decimal montoApuesta);
        
    }
}
