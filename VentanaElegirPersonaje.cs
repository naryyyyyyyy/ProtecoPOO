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

            // 2. Convertimos el objeto a Form
            Form fh = formHijo as Form;

            // 3. Le quitamos su comportamiento de "Ventana independiente"
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None; // Le quitamos los bordes y su propia "X"
            fh.Dock = DockStyle.Fill; // Hacemos que rellene todo el panel

            // 4. Lo metemos al panel y lo mostramos
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnMago_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new VentanaCrearCuenta(1));
        }

        private void btnCaballero_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new VentanaCrearCuenta(2));
        }

        private void btnPicaro_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new VentanaCrearCuenta(3));
        }
    }
}
