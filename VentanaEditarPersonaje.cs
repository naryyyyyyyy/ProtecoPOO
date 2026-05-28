using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtecoPOO.CasinoSQL
{
    private ReportesDB repos;


    public partial class VentanaEditarPersonaje : Form
    {
        public VentanaEditarPersonaje(ReportesDB repos)
        {
            this.repos = repos;

            InitializeComponent();
            //cmbELeccionPersonaje.DataSource = repos.Get
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarRecursos frm=new AgregarRecursos();
            frm.ShowDialog();
        }
    }
}
