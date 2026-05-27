using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public static class SesionGlobal
    {
        // Datos de la cuenta (inmutables durante la sesión)
        public static int UsuarioId { get; set; }
        public static string NombreUsuario { get; set; }

        // Datos del avatar actual (cambian si el usuario elige otro personaje)
        public static int PersonajeGuardadoId { get; set; }
        public static int PersonajeCatalogoId { get; set; } // Para saber si es el dibujo del Mago o Caballero
        public static double SaldoActual { get; set; }
    }
}
