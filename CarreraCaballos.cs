using CarreraCaballos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtecoPOO
{
    public partial class CarreraCaballos : Form
    {
        private Carrera carrera;
        private List<PictureBox> picCarriles;
        private Caballo caballoApuesta = null;
        private int puestoAp = 0;
        public CarreraCaballos()
        {
            InitializeComponent();

            double distanciaMeta = (panel1.Width - 100) - picCarril1.Width;
            carrera = new Carrera(distanciaMeta);
            picCarriles = new List<PictureBox> {
            picCarril1, picCarril2, picCarril3, picCarril4, picCarril5, picCarril6
            };
            if (lstCompetidores.Items.Count == 0)
            {
                btnIniciarCarrera.Enabled = false;
                btnApostar.Enabled = false;
                cmbApuestaPuesto.Enabled = false;
            }
        }

        private void NuevaCarrera()
        {
            carrera.Podio.Clear();
            carrera.SelecRooster();
            for (int i = 0; i < carrera.Competidores.Count; i++)
            {
                Caballo actual = carrera.Competidores[i];
                actual.PositionX = 0;
                picCarriles[i].Left = 0;
                picCarriles[i].Image = actual.Icon;
                picCarriles[i].SizeMode = PictureBoxSizeMode.Zoom;
            }
            //ver competidores de la carrera
            for (int i = 0; i < carrera.Competidores.Count; i++)
            {
                var actual = carrera.Competidores[i];
                lstCompetidores.Items.Add($"Carril: {i + 1} - #{actual.Id}º - {actual.Name}");
            }
            btnIniciarCarrera.Enabled = true;
            btnApostar.Enabled = true;

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
            g.DrawString("META", fMeta, Brushes.Gold, xMeta + 10, panel1.Height);
        }

        private void btnNuevaCarrera_Click(object sender, EventArgs e)
        {

            DialogResult res =
                MessageBox.Show($"¿Desea apostar otro día? Nuevo dia, otros competidores", "Nueva Carrera",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (DialogResult.Yes == res)
            {
                lstCompetidores.Items.Clear();
                NuevaCarrera();
                btnApostar.Enabled = true;
                cmbApuestaPuesto.Enabled = true;
                lblCaballo.Text = "Caballo: Ninguno Registrado";

            }
            else { return; }
            listBox1.Items.Clear();


        }

        private void btnIniciarCarrera_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            timer1.Start();
            btnNuevaCarrera.Enabled = false;
            btnIniciarCarrera.Enabled = false;
            cmbApuestaPuesto.Enabled = false;
            btnApostar.Enabled = false;

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
            panel1.Invalidate();
            if (carrera.Podio.Count == carrera.Competidores.Count)
            {
                timer1.Stop();
                if (caballoApuesta != null && puestoAp != 0)
                {
                    int lugar = carrera.Podio.IndexOf(caballoApuesta) + 1;
                    if (lugar == puestoAp)
                    {
                        MessageBox.Show($"¡Ganaste la apuesta! {caballoApuesta.Name} llegó en {lugar}º lugar.");
                        btnNuevaCarrera.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show($"Perdiste la apuesta. {caballoApuesta.Name} llegó en {lugar}º lugar \n(Apostaste por el {puestoAp}º).");
                        btnNuevaCarrera.Enabled = true;

                    }
                }
                else
                {
                    MessageBox.Show("La carrera terminó, pero no se registró ninguna apuesta previa.");
                    btnNuevaCarrera.Enabled = true;

                }
            }

        }



        private void btnApostar_Click(object sender, EventArgs e)
        {

            if (lstCompetidores.SelectedIndex == -1)
            {
                lblCaballo.Text = $"Caballo: Ninguno Registrado";
                MessageBox.Show("Por favor, selecciona un caballo de la lista de competidores actuales.");
                return;
            }


            if (cmbApuestaPuesto.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona el puesto del podio (1, 2 o 3).");
                return;
            }

            int comp = lstCompetidores.SelectedIndex;
            caballoApuesta = carrera.Competidores[comp];
            lblCaballo.Text = $"Caballo: {caballoApuesta.Name}";
            puestoAp = Convert.ToInt32(cmbApuestaPuesto.SelectedItem);
            MessageBox.Show($"Apuesta registrada: {caballoApuesta.Name} en el puesto {puestoAp}º.");
            cmbApuestaPuesto.Enabled = false;
            btnApostar.Enabled = false;
            btnNuevaCarrera.Enabled = false;
            btnIniciarCarrera.Enabled = true;


        }
    }
}
