using ProtecoPOO.CasinoSQL;
using ProtecoPOO.Ruleta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtecoPOO
{
    public partial class VentanaUsuario : Form
    {
        private usuariosDB usuarios = new usuariosDB();
        public VentanaUsuario()
        {

            InitializeComponent();
            
            CargarHistorialEnPantalla();
            lblUsuario.Text = SesionGlobal.NombreUsuario;
            lblSaldoP.Text = "$" + SesionGlobal.SaldoActual.ToString();
            CargarAvatar();
        }
        private void CargarHistorialEnPantalla()
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.AutoGenerateColumns = true;

            dgvHistorial.DataSource = usuarios.ObtenerHistorialPersonajeActual(SesionGlobal.UsuarioId, SesionGlobal.PersonajeGuardadoId);

            if (dgvHistorial.Columns.Contains("Id")) dgvHistorial.Columns["Id"].Visible = false;
            if (dgvHistorial.Columns.Contains("UsuarioId")) dgvHistorial.Columns["UsuarioId"].Visible = false;
            if (dgvHistorial.Columns.Contains("JuegoId")) dgvHistorial.Columns["JuegoId"].Visible = false;
            if (dgvHistorial.Columns.Contains("PersonajeId")) dgvHistorial.Columns["PersonajeId"].Visible = false;
        }

        private void btnblackjack_Click(object sender, EventArgs e)
        {
            VentanaBlackJack frm=new VentanaBlackJack();
            frm.ShowDialog();
            CargarHistorialEnPantalla();
            lblSaldoP.Text = SesionGlobal.SaldoActual.ToString();
        }

        private void btnCarreraCaballos_Click(object sender, EventArgs e)
        {
            CarreraCaballos carreracaballo = new CarreraCaballos();
            carreracaballo.ShowDialog();
            CargarHistorialEnPantalla();
            lblSaldoP.Text = SesionGlobal.SaldoActual.ToString();
        }

        private void btnIrAbonar_Click(object sender, EventArgs e)
        {
            AgregarRecursos frm=new AgregarRecursos();
            frm.ShowDialog();

            lblSaldoP.Text = SesionGlobal.SaldoActual.ToString();

            CargarHistorialEnPantalla();
        }
       
        

        private void btnRuleta_Click(object sender, EventArgs e)
        {
            VentanaRuleta ruleta = new VentanaRuleta();
            ruleta.ShowDialog();
            lblSaldoP.Text = SesionGlobal.SaldoActual.ToString();
            CargarHistorialEnPantalla();
        }

        private void VentanaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginOriginal = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (loginOriginal != null)
            {
                loginOriginal.Show();
            }
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var loginOriginal = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (loginOriginal != null)
            {
                loginOriginal.Show();
            }

            this.FormClosed -= VentanaUsuario_FormClosed;
            this.Close();
        }
        private void lblUsuario_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = SesionGlobal.NombreUsuario;
        }

        private void CargarAvatar()
        {
            switch (SesionGlobal.PersonajeCatalogoId)
            {
                 
                case 1:
                    pcbPersonaje.Image = Properties.Resources.barbaro;
                    break;

                case 2:
                    pcbPersonaje.Image = Properties.Resources.picaro;
                    break;

                case 3:
                    pcbPersonaje.Image = Properties.Resources.hechicero;
                    break;

                case 4:
                    pcbPersonaje.Image = Properties.Resources.bardo;
                    break;

                case 5:
                    pcbPersonaje.Image = Properties.Resources.hada;
                    break;

                case 6:
                    pcbPersonaje.Image = Properties.Resources.sirena;
                    break;

                case 7:
                    pcbPersonaje.Image = Properties.Resources.bruja;
                    break;

                case 8:
                    pcbPersonaje.Image = Properties.Resources.cazador;
                    break;

                case 9:
                    pcbPersonaje.Image = Properties.Resources.caballero;
                    break;
            }

            pcbPersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCambiarPersonaje_Click(object sender, EventArgs e)
        {
            VentanaEditarPersonaje frm = new VentanaEditarPersonaje();
            frm.ShowDialog();

            lblSaldoP.Text = "$" + SesionGlobal.SaldoActual;
            CargarAvatar();
            CargarHistorialEnPantalla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportesUsuario frm= new ReportesUsuario();
            frm.ShowDialog();
        }
    }
}
