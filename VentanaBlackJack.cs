using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using ProtecoPOO.CasinoSQL;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtecoPOO
{
    public partial class VentanaBlackJack : Form
    {
        usuariosDB reporte = new usuariosDB();
        // La baraja será una lista de textos. Ej: "c1", "p12", "t5"
        private List<string> baraja = new List<string>();

        // Las manos del jugador y la banca/casa
        private List<string> cartasJugador = new List<string>();
        private List<string> cartasCasa = new List<string>();

        // El generador de azar para revolver las cartas
        private Random random = new Random();
        public VentanaBlackJack()
        {
            InitializeComponent();
           // IniciarPartida();
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
        private void RepartirCarta(List<string> mano, FlowLayoutPanel panel)
        {
            if (baraja.Count == 0) return;

            // 1. Elegir carta al azar
            int indice = random.Next(baraja.Count);
            string nombreCarta = baraja[indice];
            baraja.RemoveAt(indice); // La quitamos para que no se repita

            // 2. Agregarla a la lista de la mano (Jugador o Casa)
            mano.Add(nombreCarta);

            // 3. Crear el control de imagen visualmente
            PictureBox pic = new PictureBox();
            pic.Size = new System.Drawing.Size(90, 130); // Tamaño de la carta
            pic.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar imagen al tamaño

            // 4. Buscar la imagen en tus recursos por su nombre (c1, d5, etc.)
            pic.Image = (System.Drawing.Image)ProtecoPOO.Properties.Resources.ResourceManager.GetObject(nombreCarta);

            // 5. Agregar la imagen al panel (flowJugador o flowCasa)
            panel.Controls.Add(pic);
        }
        private int CalcularPuntos(List<string> mano)
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
        private void IniciarPartida()
        {
            // Limpiamos todo lo anterior
            CrearBaraja();
            cartasJugador.Clear();
            cartasCasa.Clear();
            flowJugador.Controls.Clear();
            flowCasa.Controls.Clear();
            lblResultado.Text = "Tu turno. ¿Pides o te plantas?";
            btnPedir.Enabled = true;
            btnPlantarse.Enabled = true;

            // Repartimos las cartas iniciales (Regla estándar: 2 al jugador, 1 a la casa)
            RepartirCarta(cartasJugador, flowJugador);
            RepartirCarta(cartasJugador, flowJugador);
            RepartirCarta(cartasCasa, flowCasa);

            // Actualizamos los puntajes iniciales
            lblPuntosJugador.Text = "Puntos Jugador: " + CalcularPuntos(cartasJugador);
            // De la casa no mostramos puntos aún porque solo tiene una carta
            lblPuntosCasa.Text = "Puntos Casa: ?";
        }

        private void btnPlantarse_Click(object sender, EventArgs e)
        {

            // 1. Desactivamos los botones para que el jugador ya no pueda hacer nada
            btnPedir.Enabled = false;
            btnPlantarse.Enabled = false;

            // 2. La IA de la casa pide cartas automáticamente si tiene menos de 17 puntos
            while (CalcularPuntos(cartasCasa) < 17)
            {
                RepartirCarta(cartasCasa, flowCasa);
            }

            // 3. Calculamos los puntajes finales de ambos
            int puntosJugador = CalcularPuntos(cartasJugador);
            int puntosCasa = CalcularPuntos(cartasCasa);

            // 4. Mostramos el puntaje final de la casa en su Label
            lblPuntosCasa.Text = "Puntos Casa: " + puntosCasa;

            // 5. Definimos quién ganó según las reglas del Blackjack
            if (puntosCasa > 21)
            {
                lblResultado.Text = "¡La casa se pasó de 21! ¡TÚ GANAS! 🎉";
            }
            else if (puntosJugador > puntosCasa)
            {
                lblResultado.Text = "¡Ganaste! Tienes mejor puntuación. 🏆";
            }
            else if (puntosJugador < puntosCasa)
            {
                lblResultado.Text = "La casa gana. Más suerte la próxima. 🏠";
            }
            else
            {
                lblResultado.Text = "Empate. Se devuelven las apuestas. 🤝";
            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            // 1. Le damos una carta más al jugador
            RepartirCarta(cartasJugador, flowJugador);

            // 2. Calculamos sus nuevos puntos
            int puntosJugador = CalcularPuntos(cartasJugador);

            // 3. Actualizamos el texto en pantalla (lblPuntosJugador es el nombre de tu Label)
            lblPuntosJugador.Text = "Puntos Jugador: " + puntosJugador;

            // 4. Verificamos si perdió
            if (puntosJugador > 21)
            {
                lblResultado.Text = "¡TE PASASTE! La casa gana.";
                // Desactivamos los botones porque el juego terminó
                btnPedir.Enabled = false;
                btnPlantarse.Enabled = false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            IniciarPartida();
        }

        private void VentanaBlackJack_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
