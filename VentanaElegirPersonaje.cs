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
    public partial class VentanaElegirPersonaje : Form
    {
        public VentanaElegirPersonaje()
        {
            InitializeComponent();
        }

        public void AbrirFormEnPanel(object formHijo)
        {
            this.panelContenedor.Controls.Clear();

            
            Form fh = formHijo as Form;

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None; 
            fh.Dock = DockStyle.Fill; 

            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnMago_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new VentanaCrearCuenta(3));
        }

        private void btnCaballero_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new VentanaCrearCuenta(1));
        }

        private void btnPicaro_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new VentanaCrearCuenta(2));
        }
    }
}
