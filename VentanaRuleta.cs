using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProtecoPOO.Ruleta; 

namespace ProtecoPOO.Ruleta
{
    public partial class VentanaRuleta : Form
    {
        private Ruleta ruleta = new Ruleta("Ruleta", 1);
        private int resultado;

        public VentanaRuleta()
        {
            InitializeComponent();
            decimal saldoDeBaseDatos = 1000;
            ruleta.CargarSaldoInicial(saldoDeBaseDatos);
            ActualizarInterfazSaldos();
            btnGirar.Enabled = false;
            

        }
        private void ActualizarInterfazSaldos()
        {
            lblSaldo.Text = "Tu Saldo Actual: $" + ruleta.SaldoJugador;
            lblApuesta.Text = "Apuesta en juego: $" + ruleta.ApuestaActual;
        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            
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

            //iniciar apuesta y obt de q tipo
            string tipo = cmbTipoAp.SelectedItem.ToString();
            bool apuestaValida = false;

            // logica segun los casos (color, num)
            if (tipo == "Color")
            {
                txtNumAp.Clear();
                txtNumAp.Enabled = false;
                cmbTipo.Enabled= true;
                string cElegido = cmbTipo.Text;
                if (cElegido == "" || cmbTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor especifique un color");
                }
                else
                {
                    ruleta.ApuestaRul = new Apuesta(-1, cElegido, monto);
                    apuestaValida = ruleta.ValidarYColocarApuesta(monto);
                }
            }
            else if (tipo == "Número")
            {
                txtNumAp.Enabled = true;
                cmbTipo.Enabled= false;
                if (int.TryParse(txtNumAp.Text, out int n)&& n > -1 && n< 37)
                {
                    
                    ruleta.ApuestaRul = new Apuesta(n, "", monto);
                    apuestaValida = ruleta.ValidarYColocarApuesta(monto);
                }
            }

            //final
            if (apuestaValida)
            {
                btnGirar.Enabled = true;
                btnApostar.Enabled = false;
                ActualizarInterfazSaldos();
            }
            else
            {
                MessageBox.Show("Apuesta inválida o saldo insuficiente.");
            }
        }


        // if (cmbTipo.SelectedItem)

    }
}
