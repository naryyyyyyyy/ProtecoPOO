using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class Personaje
    {
        string Nombre { get; set; }
        int Id { get; set; }
        public Personaje(string nombre, int id)
        {
            Nombre = nombre;
            Id = id;
        }
    }
}
