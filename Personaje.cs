using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class Personaje
    {
        public string Nombre { get; }
        public int Id { get; }
        public Personaje(string nombre, int id)
        {
            Nombre = nombre;
            Id = id;
        }
    }
}
