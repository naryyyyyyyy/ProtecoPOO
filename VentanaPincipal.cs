using ProtecoPOO.CasinoSQL;
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
    public partial class Form1 : Form
    {
        private usuariosDB usuariodb = new usuariosDB();
        private ReportesDB reportedb = new ReportesDB();
        private Usuario usuarioActual;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Llene los campos", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (usuariodb.UsuarioExistente(usuario, contraseña))
            {
                int idUsuario = usuariodb.ObtenerIdUsuario(usuario, contraseña);

                SesionGlobal.UsuarioId = idUsuario;
                SesionGlobal.NombreUsuario = usuario;
                var inventarioPersonajes = usuariodb.ObtenerPersonajesDelUsuario(idUsuario);
                var personajePrincipal = inventarioPersonajes.FirstOrDefault();

                if (personajePrincipal != null)
                {
                    SesionGlobal.PersonajeGuardadoId = personajePrincipal.Id;
                    SesionGlobal.PersonajeCatalogoId = personajePrincipal.PersonajeId;
                    SesionGlobal.SaldoActual = personajePrincipal.Saldo;
                }

                VentanaUsuario frm = new VentanaUsuario();
                frm.Show();
                txtContrasena.Clear();
                txtUsuario.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado o contraseña incorrecta.", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtContrasena.Clear();
                return;
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            VentanaElegirPersonaje pers = new VentanaElegirPersonaje();
            pers.ShowDialog();
        }

        private void linkLblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaAdministrador ventanaAdministrador = new VentanaAdministrador();
            ventanaAdministrador.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContrasena.Focus();
            }
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

    }
}
