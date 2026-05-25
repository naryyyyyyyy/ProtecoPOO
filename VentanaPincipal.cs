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
            

             VentanaUsuario frm = new VentanaUsuario();
            frm.ShowDialog();
        }
    }
}
