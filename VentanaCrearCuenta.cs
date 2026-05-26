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
        int personajeId;
        public VentanaCrearCuenta(int personajeElegido)
        {
            InitializeComponent();
            personajeId = personajeElegido;
        }
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
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
                usuarios.AgregarUsuario(usuario, contraseña, personajeId);
                MessageBox.Show("Usuario creado exitosamente!", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                VentanaElegirPersonaje ventanaPadre = (VentanaElegirPersonaje)this.ParentForm;
                ventanaPadre.AbrirFormEnPanel(new Form1());
            }
            else
            {
                MessageBox.Show("Ese usuario ya existe", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
