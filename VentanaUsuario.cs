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
    public partial class VentanaUsuario : Form
    {
        public VentanaUsuario()
        {
            InitializeComponent();
        }

        private void btnblackjack_Click(object sender, EventArgs e)
        {
            //validacion de que si tenga almas para jugar
            VentanaBlackJack frm=new VentanaBlackJack();
            frm.ShowDialog();
        }
    }
}
