using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class RegistroPartida
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int JuegoId { get; set; }
        public int PersonajeId { get; set; }
        public decimal SaldoInicial {  get; set; }
        public int NumReapuestas {  get; set; }
        public decimal GananciaPerdida { get; set; }
        public string NombreJuego { get; set; }
        public RegistroPartida() { }
        public RegistroPartida(int id, int usuarioId, int juegoId,int personajeId, decimal saldoInicial, int numReapuestas, decimal ganancia)
        {
            Id = id;
            UsuarioId = usuarioId;
            JuegoId = juegoId;
            PersonajeId = personajeId;
            SaldoInicial = saldoInicial;
            NumReapuestas = numReapuestas;
            GananciaPerdida = ganancia;
        }
    }
}
