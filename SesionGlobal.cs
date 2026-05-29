using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public static class SesionGlobal
    {
        public static int UsuarioId { get; set; }
        public static string NombreUsuario { get; set; }

        public static int PersonajeGuardadoId { get; set; }
        public static int PersonajeCatalogoId { get; set; } 
        public static double SaldoActual { get; set; }
    }
}
