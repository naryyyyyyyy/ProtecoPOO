using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class ElementoCombo
    {
        // El número oculto que usaremos para buscar en la base de datos (ValueMember)
        public int Id { get; set; }

        // El texto que el usuario verá en la pantalla (DisplayMember)
        public string Nombre { get; set; }
    }
}
