using System;
using System.Collections.Generic;
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
        private usuariosDB usuariodb = new usuariosDB();

        private BlackJack juegoBJ = new BlackJack("Blackjack 21", 2);


        private string nombreUsuarioActual = SesionGlobal.NombreUsuario;
        int contador = 0;

        public VentanaBlackJack()
        {
            InitializeComponent();


            decimal saldoDeBaseDatos = (decimal)SesionGlobal.SaldoActual;
            juegoBJ.CargarSaldoInicial(saldoDeBaseDatos);


            lbsaldo.Text = "Tu Saldo: $" + juegoBJ.SaldoJugador;
            lblApuestaEnJuego.Text = "Apuesta en juego: $0";



            btnPedir.Enabled = false;
            btnPlantarse.Enabled = false;
        }


        private void btnAceptarApuesta_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txtApuesta.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingresa un monto de apuesta válido.", "Atención");
                return;
            }


            if (!juegoBJ.ValidarYColocarApuesta(monto))
            {

                MessageBox.Show("No cuentas con saldo suficiente para realizar esta apuesta.", "Fondos Insuficientes");
                return;
            }

            
            lbsaldo.Text = "Tu Saldo: $" + juegoBJ.SaldoJugador;
            lblApuestaEnJuego.Text = "Apuesta en juego: $" + juegoBJ.ApuestaActual;
            btnAceptarApuesta.Enabled = false;
            txtApuesta.Enabled = false;

            btnPedir.Enabled = true;
            btnPlantarse.Enabled = true;

            juegoBJ.IniciarNuevaMano();
            flowJugador.Controls.Clear();
            flowCasa.Controls.Clear();
            lblResultado.Text = "Tu turno. ¿Pides o te plantas?";

            RepartirCartaVisual(juegoBJ.cartasJugador, flowJugador);
            RepartirCartaVisual(juegoBJ.cartasJugador, flowJugador);
            RepartirCartaVisual(juegoBJ.cartasCasa, flowCasa);

            lblPuntosJugador.Text = "Puntos Jugador: " + juegoBJ.CalcularPuntos(juegoBJ.cartasJugador);
            lblPuntosCasa.Text = "Puntos Casa: ?";

            contador++;
        }


        private void RepartirCartaVisual(List<string> mano, FlowLayoutPanel panel)
        {
            string nombreCarta = juegoBJ.ExtraerCartaAlAzar();
            if (nombreCarta == null) return;


            mano.Add(nombreCarta);

            PictureBox pic = new PictureBox();
            pic.Size = new System.Drawing.Size(90, 130);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            pic.Image = (System.Drawing.Image)ProtecoPOO.Properties.Resources.ResourceManager.GetObject(nombreCarta);

            panel.Controls.Add(pic);
        }


        private void btnPedir_Click(object sender, EventArgs e)
        {

            RepartirCartaVisual(juegoBJ.cartasJugador, flowJugador);


            int puntosJugador = juegoBJ.CalcularPuntos(juegoBJ.cartasJugador);
            lblPuntosJugador.Text = "Puntos Jugador: " + puntosJugador;


            if (puntosJugador > 21)
            {
                lblResultado.Text = "¡TE PASASTE! La casa gana.";
                FinalizarManoMesa("PERDIO");
            }
        }

        private void btnPlantarse_Click(object sender, EventArgs e)
        {
            btnPedir.Enabled = false;
            btnPlantarse.Enabled = false;


            while (juegoBJ.CalcularPuntos(juegoBJ.cartasCasa) < 17)
            {
                RepartirCartaVisual(juegoBJ.cartasCasa, flowCasa);
            }


            int puntosJugador = juegoBJ.CalcularPuntos(juegoBJ.cartasJugador);
            int puntosCasa = juegoBJ.CalcularPuntos(juegoBJ.cartasCasa);


            lblPuntosCasa.Text = "Puntos Casa: " + puntosCasa;

            if (puntosCasa > 21)
            {
                lblResultado.Text = "¡La casa se pasó de 21! ¡TÚ GANAS! 🎉";
                FinalizarManoMesa("GANASTE");
            }
            else if (puntosJugador > puntosCasa)
            {
                lblResultado.Text = "¡Ganaste! Tienes mejor puntuación. 🏆";
                FinalizarManoMesa("GANASTE");
            }
            else if (puntosJugador < puntosCasa)
            {
                lblResultado.Text = "La casa gana. Más suerte la próxima. 🏠";
                FinalizarManoMesa("PERDIO");
            }
            else
            {
                lblResultado.Text = "Empate. Se devuelven las apuestas. 🤝";
                FinalizarManoMesa("EMPATE");
            }
        }


        private void FinalizarManoMesa(string dictamen)
        {
            btnPedir.Enabled = false;
            btnPlantarse.Enabled = false;


            decimal dineroDevuelto = juegoBJ.CalcularPagoPorResultado(dictamen);


            juegoBJ.RegistrarResultado(dineroDevuelto);


            lbsaldo.Text = "Tu Saldo: $" + juegoBJ.SaldoJugador;
            lblApuestaEnJuego.Text = "Apuesta en juego: $0";


            btnReiniciar.Enabled = true;
        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {

            if (juegoBJ.SaldoJugador <= 0)
            {
                MessageBox.Show("Te has quedado sin dinero en tu cuenta de casino. Serás redirigido al menú.", "Fin del Juego");
                this.Close();
                return;
            }


            txtApuesta.Clear();
            txtApuesta.Enabled = true;
            btnAceptarApuesta.Enabled = true;

            flowJugador.Controls.Clear();
            flowCasa.Controls.Clear();
            lblPuntosJugador.Text = "Puntos Jugador: 0";
            lblPuntosCasa.Text = "Puntos Casa: 0";
            lblResultado.Text = "Ingresa una nueva apuesta para comenzar.";
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaBlackJack_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (contador > 0)
            {
                TerminarJuego();
            }
        }
        private void TerminarJuego()
        {
            try
            {
                double saldoFinal = (double)juegoBJ.SaldoJugador;
                decimal gananciaNeta = (decimal)juegoBJ.SaldoJugador - (decimal)SesionGlobal.SaldoActual;

                RegistroPartida reg = new RegistroPartida(
                    1,
                    SesionGlobal.UsuarioId,
                    juegoBJ.JuegoId,
                    SesionGlobal.PersonajeGuardadoId,
                    (decimal)SesionGlobal.SaldoActual,
                    contador,
                    gananciaNeta
                );

                usuariodb.AgregarRegistroPartida(reg);
                usuariodb.ActualizarSaldoPersonaje(SesionGlobal.PersonajeCatalogoId, saldoFinal);

                SesionGlobal.SaldoActual = saldoFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al sincronizar con la Base de Datos: " + ex.Message,
                                "Fallo Runtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
  }

