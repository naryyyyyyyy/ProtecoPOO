using System;
using ProtecoPOO.CasinoSQL;
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
    public partial class VentanaAdministrador : Form
    {
        usuariosDB usuarios = new usuariosDB();
        ReportesDB reportes = new ReportesDB();
        public VentanaAdministrador()
        {
            InitializeComponent();
            cmbNombreAdmin.DataSource = reportes.GetAllAdministradores();
            cmbNombreAdmin.DisplayMember = "Nombre";
            cmbNombreAdmin.ValueMember = "Id";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int adminId = (int)cmbNombreAdmin.SelectedValue;
            string contraseña = txtContraseña.Text;
            if (string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Llene los campos", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (usuarios.ValidarContrasena(adminId, contraseña))
            {
                MessageBox.Show("Contraseña invalida", "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.Hide();
                this.Close();
                VentanaAdmin adminVentana = new VentanaAdmin();
                adminVentana.ShowDialog();
            }
        }
    }
}
