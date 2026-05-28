using System;
using System.Data.SQLite;
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
    public partial class VentanaEditarPersonaje : Form
    {
        ReportesDB reportes;
        public VentanaEditarPersonaje(ReportesDB repos)
        {
            reportes = repos;

            InitializeComponent();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarRecursos frm=new AgregarRecursos();
            frm.ShowDialog();
        }
    }
}
