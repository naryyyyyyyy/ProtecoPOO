using CarreraCaballos;
using ProtecoPOO.CasinoSQL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProtecoPOO
{
    public partial class CarreraCaballos : Form
    {
        private Carrera carrera;
        private List<PictureBox> picCarriles;
        private Caballo caballoApuesta = null;
        private int puestoAp = 0;

        private usuariosDB usuariodb = new usuariosDB();

        private string nombreUsuarioActual = SesionGlobal.NombreUsuario;
        private int contador = 0; 
        private int cId = 3; 
        private string cName = "Carrera de Caballos";

        public CarreraCaballos()
        {
            InitializeComponent();
            usuariodb = new usuariosDB();

            this.FormClosing += CarreraCaballos_FormClosing;

            double distanciaMeta = (panel1.Width - 100) - picCarril1.Width;

            carrera = new Carrera(cName, cId, distanciaMeta);

            picCarriles = new List<PictureBox> {
                picCarril1, picCarril2, picCarril3, picCarril4, picCarril5, picCarril6
            };

            decimal saldoInicial = (decimal)SesionGlobal.SaldoActual;
            carrera.CargarSaldoInicial(saldoInicial);

            ActualizarInterfazSaldos();

            btnIniciarCarrera.Enabled = false;
            btnApostar.Enabled = false;
            cmbApuestaPuesto.Enabled = false;
            btnNuevaCarrera.Enabled = true;
        }

        private void ActualizarInterfazSaldos()
        {
            lblsaldo.Text = "Tu Saldo Actual: $" + carrera.SaldoJugador;
            lblApuestaEnJuego.Text = "Apuesta en juego: $" + carrera.ApuestaActual;
        }

        private void NuevaCarrera()
        {
            carrera.Podio.Clear();
            carrera.SelecRooster();
            lstCompetidores.Items.Clear();
            lblApuestaEnJuego.Text = "Apuesta en juego: ";

            for (int i = 0; i < carrera.Competidores.Count; i++)
            {
                Caballo actual = carrera.Competidores[i];
                actual.PositionX = 0;
                picCarriles[i].Left = 0;
                picCarriles[i].Image = actual.Icon;
                picCarriles[i].SizeMode = PictureBoxSizeMode.Zoom;

                lstCompetidores.Items.Add($"Carril: {i + 1} - #{actual.Id}º - {actual.Name}");
            }

            cmbApuestaPuesto.Enabled = true;
            btnApostar.Enabled = true;
            btnIniciarCarrera.Enabled = false;
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            if (lstCompetidores.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un caballo de la lista de competidores.");
                return;
            }

            if (cmbApuestaPuesto.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona el puesto del podio (1, 2 o 3).");
                return;
            }

            if (!decimal.TryParse(txtApuesta.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingresa un monto de apuesta válido.", "Atención");
                return;
            }

            if (!carrera.ValidarYColocarApuesta(monto))
            {
                MessageBox.Show("No cuentas con saldo suficiente para realizar esta apuesta o el monto es inválido.", "Fondos Insuficientes");
                return;
            }

            contador++;

            int comp = lstCompetidores.SelectedIndex;
            caballoApuesta = carrera.Competidores[comp];
            puestoAp = Convert.ToInt32(cmbApuestaPuesto.SelectedItem);
            lblCaballo.Text = $"Caballo: {caballoApuesta.Name} (Puesto: {puestoAp}º)";

            ActualizarInterfazSaldos();

            btnApostar.Enabled = false;
            cmbApuestaPuesto.Enabled = false;
            txtApuesta.Enabled = false;
            btnNuevaCarrera.Enabled = false;
            btnSalir.Enabled = false;

            btnIniciarCarrera.Enabled = true;
        }

        private void btnIniciarCarrera_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            timer1.Start();
            btnIniciarCarrera.Enabled = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            double distanciaMeta = (panel1.Width - 100) - picCarril1.Width;
            carrera.Simular(distanciaMeta);

            for (int i = 0; i < carrera.Competidores.Count; i++)
            {
                picCarriles[i].Left = (int)carrera.Competidores[i].PositionX;
                var caballo = carrera.Competidores[i];
                if (caballo.PositionX >= distanciaMeta && !carrera.Podio.Contains(caballo))
                {
                    carrera.Podio.Add(caballo);
                    int puesto = carrera.Podio.Count;
                    listBox1.Items.Add($"{puesto}º - #{caballo.Id}: {caballo.Name}");
                }
            }

            if (carrera.Podio.Count == carrera.Competidores.Count)
            {
                timer1.Stop();
                FinalizarCarreraMesa();
            }
        }

        private void FinalizarCarreraMesa()
        {
            string dictamen = carrera.EvaluarResultadoApuesta(caballoApuesta, puestoAp);
            int lugarReal = carrera.Podio.IndexOf(caballoApuesta) + 1;

            decimal ganancias = carrera.CalcularPagoEstandar(dictamen);
            carrera.RegistrarResultado(ganancias);

            if (dictamen == "GANASTE")
            {
                MessageBox.Show($"¡Ganaste la apuesta! {caballoApuesta.Name} llegó en {lugarReal}º lugar. Se te pagaron: ${ganancias}");
            }
            else
            {
                MessageBox.Show($"Perdiste la apuesta. {caballoApuesta.Name} llegó en {lugarReal}º lugar\n(Apostaste por el {puestoAp}º).");
            }

            ActualizarInterfazSaldos();
            btnNuevaCarrera.Enabled = true;
            btnSalir.Enabled = true; // Habilitar salida tras resolver el flujo de dinero
        }

        private void btnNuevaCarrera_Click(object sender, EventArgs e)
        {
            if (carrera.SaldoJugador <= 0)
            {
                MessageBox.Show("Te has quedado sin dinero en tu cuenta de casino. Serás redirigido al menú.", "Fin del Juego");
                this.Close();
                return;
            }

            DialogResult res = MessageBox.Show("¿Desea simular otra carrera?", "Nueva Carrera", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                txtApuesta.Clear();
                txtApuesta.Enabled = true;
                lblCaballo.Text = "Caballo: Ninguno Registrado";
                caballoApuesta = null;
                puestoAp = 0;
                listBox1.Items.Clear();
                NuevaCarrera();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void CarreraCaballos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (contador > 0)
            {
                TerminarJuego();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen penCarril = new Pen(Color.Gray, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            Pen penMeta = new Pen(Color.Gold, 5);
            int altCarril = picCarril1.Height;
            int xMeta = panel1.Width - 100;

            for (int i = 0; i <= 6; i++)
            {
                int y = i * altCarril;
                g.DrawLine(penCarril, 0, y, panel1.Width, y);
            }
            g.DrawLine(penMeta, xMeta, 0, xMeta, panel1.Height);
            Font fMeta = new Font("Impact", 16);
            g.DrawString("META", fMeta, Brushes.Gold, xMeta + 10, panel1.Height - 30);
        }
        private void TerminarJuego()
        {
            try
            {
                double saldoFinal = (double)carrera.SaldoJugador;
                // Calcul
                decimal gananciaNeta = (decimal)carrera.SaldoJugador - (decimal)SesionGlobal.SaldoActual;

                RegistroPartida reg = new RegistroPartida(1,

                    SesionGlobal.UsuarioId,
                    cId,
                    SesionGlobal.PersonajeGuardadoId,
                    (decimal)SesionGlobal.SaldoActual,
                    contador,
                    gananciaNeta
                );

                usuariodb.AgregarRegistroPartida(reg);
                usuariodb.ActualizarSaldoPersonaje(SesionGlobal.PersonajeGuardadoId, saldoFinal);

                SesionGlobal.SaldoActual = saldoFinal;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al sincronizar con la Base de Datos: " + ex.Message, "Fallo Runtine", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}