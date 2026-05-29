
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class BlackJack : Juego
    {
        
        public List<string> baraja { get; private set; } = new List<string>();

        
        public List<string> cartasJugador { get; private set; } = new List<string>();
        public List<string> cartasCasa { get; private set; } = new List<string>();

       
        private Random random = new Random();

        
        public BlackJack(string nombre, int id) : base(nombre, id)
        {
        }

        
        public void IniciarNuevaMano()
        {
            cartasJugador.Clear();
            cartasCasa.Clear();
            CrearBaraja();
        }

        private void CrearBaraja()
        {
            baraja.Clear();
            string[] palos = { "c", "d", "t", "p" };

            foreach (string p in palos)
            {
                for (int i = 1; i <= 13; i++)
                {
                    baraja.Add(p + i);
                }
            }
        }

        public string ExtraerCartaAlAzar()
        {
            if (baraja.Count == 0) return null;

            int indice = random.Next(baraja.Count);
            string nombreCarta = baraja[indice];
            baraja.RemoveAt(indice); 

            return nombreCarta;
        }

        public int CalcularPuntos(List<string> mano)
        {
            int total = 0;
            int ases = 0;

            foreach (string carta in mano)
            {
                int valor = int.Parse(carta.Substring(1));

                if (valor == 1) 
                {
                    ases++;
                    total += 11;
                }
                else if (valor >= 10)
                {
                    total += 10;
                }
                else
                {
                    total += valor;
                }
            }

           
            while (total > 21 && ases > 0)
            {
                total -= 10;
                ases--;
            }

            return total;
        }

        public decimal CalcularPagoPorResultado(string resultado)
        {
            if (resultado == "GANASTE")
            {
                return ApuestaActual * 2; 
            }
            if (resultado == "EMPATE")
            {
                return ApuestaActual;
            }
            return 0; 
        }
    }
}

