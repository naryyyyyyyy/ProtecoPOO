
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtecoPOO
{
    public class BlackJack : Juego
    {
        /*
        public BlackJack(string nombre, int id) : base(nombre,id)
        {
        }

        public override decimal Jugar(decimal montoApuesta)
        {
            decimal ganancia = 0;

            // Toda la lógica de los caballos, randoms, etc...

            return ganancia;
        }*/
        // La baraja será una lista de textos. Ej: "c1", "p12", "t5"
        public List<string> baraja { get; private set; } = new List<string>();

        // Las manos del jugador y la banca/casa
        public List<string> cartasJugador { get; private set; } = new List<string>();
        public List<string> cartasCasa { get; private set; } = new List<string>();

        // El generador de azar para revolver las cartas
        private Random random = new Random();

        // Constructor: Pasa el nombre y el ID a la clase padre Juego
        public BlackJack(string nombre, int id) : base(nombre, id)
        {
        }

        // Prepara las listas limpias para iniciar una nueva mano
        public void IniciarNuevaMano()
        {
            cartasJugador.Clear();
            cartasCasa.Clear();
            CrearBaraja();
        }

        private void CrearBaraja()
        {
            baraja.Clear();
            // Los 4 palos: c = corazones, d = diamantes, t = tréboles, p = picas
            string[] palos = { "c", "d", "t", "p" };

            foreach (string p in palos)
            {
                for (int i = 1; i <= 13; i++)
                {
                    // Esto agrega "c1", "c2"... "p13" a la lista
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
            baraja.RemoveAt(indice); // La quitamos para que no se repita

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

            // Si nos pasamos de 21 y tenemos Ases, el As pasa a valer 1 (restamos 10)
            while (total > 21 && ases > 0)
            {
                total -= 10;
                ases--;
            }

            return total;
        }

        // POLIMORFISMO: Implementación obligatoria de Jugar para determinar las ganancias del BJ
        // Recibe un código de resultado y calcula cuánto dinero regresa según las reglas del punto 2
        public override decimal Jugar(decimal montoApuesta)
        {
            // Este método lo exige la estructura, pero las ganancias las procesaremos
            // mediante el análisis del estado final de las cartas en el Form.
            return 0;
        }

        // Método auxiliar para calcular el pago exacto (Punto 2: paga el doble si gana)
        public decimal CalcularPagoPorResultado(string resultado)
        {
            if (resultado == "GANASTE")
            {
                return ApuestaActual * 2; // Recupera su apuesta y gana una cantidad igual (Total = Neto + Premio)
            }
            if (resultado == "EMPATE")
            {
                return ApuestaActual; // Se le devuelve su apuesta original intacta
            }
            return 0; // Si perdió, la casa se queda el dinero (ganancia 0)
        }
    }
}

