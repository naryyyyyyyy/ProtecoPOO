using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class UsuariosForReporte
    {
        public UsuariosForReporte(int id, string nomnbre, int personajeId)
        {
            Id = id;
            Nomnbre = nomnbre;
            PersonajeId = personajeId;
        }

        public int Id { get; }

        public string Nomnbre { get; }

        public int PersonajeId { get; }
    }
}
