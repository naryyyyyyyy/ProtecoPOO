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
    public partial class AgregarRecursos : Form
    {
        /// <summary>
        /// se tiene que pasar el objeto usuario a esta ventana para qu ese pueda guardar con el id
        /// </summary>
        public AgregarRecursos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAbono.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingresa un monto de apuesta válido.", "Atención");
                return;
            }
            decimal NuevoMoto = monto/2;// cada creido vale 2 pesos 
            //usuariodb=>modificar mnonto
            //metodo para modificar el monto con el ususario y el id 
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
