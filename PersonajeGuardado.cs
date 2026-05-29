using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class PersonajeGuardado
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PersonajeId { get; set; }
        public double Saldo { get; set; }
        public bool EstaVivo { get; set; }
        public string Nombre { get; set; }

        public string InfoVisual => $"{Nombre} - Saldo: ${Saldo}";
    }
}
