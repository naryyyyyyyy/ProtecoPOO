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
    public partial class VentanaCrearCuenta : Form
    {
        usuariosDB usuarios = new usuariosDB();
        public VentanaCrearCuenta()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            //CODIGO DE PRUEBA <----------------------------------

            /*string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if(string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Llene los campos", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if(!usuarios.UsuarioExistente(usuario, contraseña))
            {
            // HACE FALTA LA SELECCION DE PERSONAJE <---------------------------
                usuarios.AgregarUsuario(usuario, contraseña, 2);
            }
            else
            {
                MessageBox.Show("Ese usuario ya existe", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }*/
        }
    }
}
