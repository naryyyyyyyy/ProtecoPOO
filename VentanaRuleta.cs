using ProtecoPOO.CasinoSQL;
using ProtecoPOO.Ruleta;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProtecoPOO.Ruleta
{
    public partial class VentanaRuleta : Form
    {
        private Ruleta ruleta = new Ruleta("Ruleta", 1); // ID del juego = 1
        private int resultado;

        
        private usuariosDB usuariodb = new usuariosDB();
        private bool guardadoProcesado = false;
        private int contador = 0; //

        public VentanaRuleta()
        {
            InitializeComponent();

            this.FormClosing += VentanaRuleta_FormClosing;

            decimal saldoInicial = (decimal)SesionGlobal.SaldoActual;
            ruleta.CargarSaldoInicial(saldoInicial);

            ActualizarInterfazSaldos();
            btnGirar.Enabled = false;
        }
        private void ActualizarInterfazSaldos()
        {

            lblSaldo.Text = "Tu Saldo Actual: $" + ruleta.SaldoJugador;
            lblApuesta.Text = $"Apuesta en juego:" + ruleta.ApuestaActual;

        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            contador++; // reapuestas
            resultado = ruleta.Girar();
            string cGanador = ruleta.Color(resultado);

            lblResultado.Text = $"Número: {resultado}";
            lblColor.Text = $"Color: {cGanador}";


            if (cGanador == "Rojo")
            {
                lblColor.BackColor = Color.Red;
            }
            else if (cGanador == "Negro")
            {
                lblColor.BackColor = Color.Black;
            }
            else
            {
                lblColor.BackColor = Color.Green;
            }
            string dictamen = ruleta.EvaluarResultado(resultado);
            decimal ganancias = ruleta.CalcularPagoEstandar(dictamen);
            ruleta.RegistrarResultado(ganancias);

            if (dictamen == "GANASTE")
            {
                MessageBox.Show($"¡Ganaste la apuesta!. Se te pagaron: ${ganancias}");
            }
            else
            {
                MessageBox.Show($"Perdiste la apuesta.");
            }

            ActualizarInterfazSaldos();
            btnGirar.Enabled = false;
            cmbTipoAp.Enabled = true;
            cmbTipo.Enabled = true;
            txtNumAp.Enabled = true;
            btnApostar.Enabled = true;
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            // validar monto cmbox
            if (!decimal.TryParse(txtApuesta.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Monto inválido.");
                return;
            }
            if (cmbTipoAp.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de apuesta.");
                return;
            }

            //iniciar apuesta y obt de q tipo
            string tipo = cmbTipoAp.SelectedItem.ToString();
            bool apuestaValida = false;

            // logica segun los casos (color, num)
            if (tipo == "Color")
            {
                txtNumAp.Clear();
                cmbTipo.Enabled = true;
                txtNumAp.Enabled = false;

                string cElegido = cmbTipo.Text;
                if (cElegido == "" || cmbTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor especifique un color");
                }
                else
                {
                    ruleta.ApuestaRul = new Apuesta(-1, cElegido, monto);
                    apuestaValida = ruleta.ValidarYColocarApuesta(monto);
                    cmbTipo.Enabled = false;
                }
            }
            else if (tipo == "Número")
            {
                txtNumAp.Enabled = true;
                cmbTipo.Enabled = false;
                cmbTipo.SelectedIndex = -1;

                if (int.TryParse(txtNumAp.Text, out int n) && n > -1 && n < 37)
                {

                    ruleta.ApuestaRul = new Apuesta(n, "", monto);
                    apuestaValida = ruleta.ValidarYColocarApuesta(monto);
                    cmbTipo.Enabled = false;
                }
                else { MessageBox.Show("Por favor especifique numero"); }

            }


            //final
            if (apuestaValida)
            {
                btnGirar.Enabled = true;
                btnApostar.Enabled = false;
                ActualizarInterfazSaldos();
            }

        }
        private void VentanaRuleta_FormClosing(object sender, FormClosingEventArgs e)
        {
            TerminarJuego();
        }

        private void TerminarJuego()
        {

            if (guardadoProcesado) return;
            guardadoProcesado = true;
            if (contador > 0)
            {
                try
                {
                    double saldoFinal = (double)ruleta.SaldoJugador;
                    decimal gananciaNeta = (decimal)ruleta.SaldoJugador - (decimal)SesionGlobal.SaldoActual;

                    // pegar tabla
                    RegistroPartida reg = new RegistroPartida(
                        1,
                        SesionGlobal.UsuarioId,
                        ruleta.JuegoId, // Retorna id
                        SesionGlobal.PersonajeGuardadoId,
                        (decimal)SesionGlobal.SaldoActual,
                        contador,
                        gananciaNeta
                    );

                    // sincroni base de datos
                    usuariodb.AgregarRegistroPartida(reg);
                    usuariodb.ActualizarSaldoPersonaje(SesionGlobal.PersonajeGuardadoId, saldoFinal);

                    
                    SesionGlobal.SaldoActual = saldoFinal;
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error al sincronizar Ruleta con la Base de Datos: " + ex.Message,
                                    "Fallo Runtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    guardadoProcesado = false; 
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}