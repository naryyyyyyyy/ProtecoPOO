using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bj
{
    public class RegistroPartida
    {
        public int UsuarioId { get; set; }
        public int JuegoId { get; set; }
        public decimal SaldoInicial {  get; set; }
        public int NumReapuestas {  get; set; }
        public decimal Ganancia { get; set; }
        public RegistroPartida(int usuarioId, int juegoId, decimal saldoInicial, int numReapuestas, decimal ganancia)
        {
            UsuarioId = usuarioId;
            JuegoId = juegoId;
            SaldoInicial = saldoInicial;
            NumReapuestas = numReapuestas;
            Ganancia = ganancia;
        }
    }
}
