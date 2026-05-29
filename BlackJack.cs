
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class BlackJack : Juego
    {
        
        //  lista de textos. Ej: "c1", "p12", "t5"
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
            //  c = corazones, d = diamantes, t = tréboles, p = picas
            string[] palos = { "c", "d", "t", "p" };

            foreach (string p in palos)
            {
                for (int i = 1; i <= 13; i++)
                {
                    // Esto agrega "c1", "c2"..
                    baraja.Add(p + i);
                }
            }
        }

        // Extrae una carta de la baraja lógica y la regresa como texto
        public string ExtraerCartaAlAzar()
        {
            if (baraja.Count == 0) return null;

            // Elegir carta al azar
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
                // Quitamos la letra (c, d, p, t) y nos quedamos con el número
                int valor = int.Parse(carta.Substring(1));

                if (valor == 1) // Es un As
                {
                    ases++;
                    total += 11;
                }
                else if (valor >= 10) // J, Q, K valen 10
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

        //
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

