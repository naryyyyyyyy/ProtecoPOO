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
    public partial class VentanaReportes : Form
    {
        ReportesDB reportes = new ReportesDB();
        public VentanaReportes()
        {
            InitializeComponent();
            dgvReporteGlobal.DataSource = reportes.GetReporteGlobalHistorial();
        }

        private void porUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dgvReporteGlobal.DataSource = reportes.GetReportePorUsuario();
        }
    }
}
