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

            // 1. Validamos si existe
            if (usuariodb.UsuarioExistente(usuario, contraseña))
            {
                // 2. Obtenemos su ID real de la base de datos
                int idUsuario = usuariodb.ObtenerIdUsuario(usuario, contraseña);

                // 3. Llenamos la primera parte de la SesionGlobal (Datos de la cuenta)
                SesionGlobal.UsuarioId = idUsuario;
                SesionGlobal.NombreUsuario = usuario;

                // 4. Cargamos su inventario y elegimos el primero como "Default"
                var inventarioPersonajes = usuariodb.ObtenerPersonajesDelUsuario(idUsuario);
                var personajePrincipal = inventarioPersonajes.FirstOrDefault();

                if (personajePrincipal != null)
                {
                    // 5. Llenamos la segunda parte de la SesionGlobal (Datos de la partida)
                    SesionGlobal.PersonajeGuardadoId = personajePrincipal.Id; // Ranura
                    SesionGlobal.PersonajeCatalogoId = personajePrincipal.PersonajeId; // Mago, Bárbaro, etc.
                    SesionGlobal.SaldoActual = personajePrincipal.Saldo;
                }

                // 6. Finalmente, abrimos la ventana del libro
                VentanaUsuario frm = new VentanaUsuario();
                frm.Show();

                // Limpiamos los campos por seguridad antes de ocultar
                txtContrasena.Clear();
                txtUsuario.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado o contraseña incorrecta.", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

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
    }
}
