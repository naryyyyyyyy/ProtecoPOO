using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class PersonajeGuardado
    {
        public int Id { get; set; }          // El ID de la ranura en la tabla
        public int UsuarioId { get; set; }
        public int PersonajeId { get; set; } // 1=Mago, 2=Caballero, 3=Picaro
        public double Saldo { get; set; }
        public bool EstaVivo { get; set; }
        public string Nombre { get; set; }

        // Esta es la propiedad que leerá el DisplayMember de tu ComboBox
        public string InfoVisual => $"{Nombre} - Saldo: ${Saldo}";
    }
}
