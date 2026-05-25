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
        usuariosDB usuariodb = new usuariosDB();
        ReportesDB reportedb = new ReportesDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            if(string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Llene los campos", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (usuariodb.UsuarioExistente(usuario, contraseña))
            {
                VentanaUsuario frm = new VentanaUsuario();
                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Usuario no encontrado", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
