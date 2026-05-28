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
        usuariosDB usuarios = new usuariosDB();
        public VentanaReportes()
        {
            InitializeComponent();
            dgvReporteGlobal.DataSource = reportes.GetReporteGlobalHistorial();
        }

        private void porUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbFiltro.Enabled = true;

            // 1. Limpieza y configuración del ComboBox
            cmbFiltro.DataSource = null;
            cmbFiltro.ValueMember = "Id";
            cmbFiltro.DisplayMember = "Nombre";

            // 2. Carga de datos de usuarios
            cmbFiltro.DataSource = usuarios.GetAllUsuarios();
            cmbFiltro.Refresh();

            // 3. Filtrado inicial seguro en el DataGridView
            if (cmbFiltro.SelectedItem is Usuario usuarioSeleccionado)
            {
                dgvReporteGlobal.DataSource = null;
                dgvReporteGlobal.AutoGenerateColumns = true;
                dgvReporteGlobal.DataSource = reportes.GetReportePorUsuario(usuarioSeleccionado.Nombre);
            }
        }

        private void porJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbFiltro.Enabled = true;

            // 1. Limpieza y configuración del ComboBox
            cmbFiltro.DataSource = null;
            cmbFiltro.ValueMember = "Id";
            cmbFiltro.DisplayMember = "Nombre";

            // 2. Carga de datos de juegos
            cmbFiltro.DataSource = usuarios.GetAllJuegos();
            cmbFiltro.Refresh();

            // 3. Filtrado inicial seguro en el DataGridView
            if (cmbFiltro.SelectedItem is ElementoCombo juegoSeleccionado)
            {
                dgvReporteGlobal.DataSource = null;
                dgvReporteGlobal.AutoGenerateColumns = true;
                dgvReporteGlobal.DataSource = reportes.GetReportePorJuego(juegoSeleccionado.Nombre);
            }
        }
        

        private void porPersonajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbFiltro.Enabled = true;

            // 1. Limpieza y configuración del ComboBox
            cmbFiltro.DataSource = null;
            cmbFiltro.ValueMember = "Id";
            cmbFiltro.DisplayMember = "Nombre";

            // 2. Carga de datos de personajes
            cmbFiltro.DataSource = usuarios.GetAllPersonajes();
            cmbFiltro.Refresh();

            // 3. Filtrado inicial seguro en el DataGridView
            if (cmbFiltro.SelectedItem is ElementoCombo personajeSeleccionado)
            {
                dgvReporteGlobal.DataSource = null;
                dgvReporteGlobal.AutoGenerateColumns = true;
                dgvReporteGlobal.DataSource = reportes.GetReportePorPersonaje(personajeSeleccionado.Nombre);
            }
        }

        private void globalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbFiltro.Enabled = false;
            dgvReporteGlobal.DataSource = reportes.GetReporteGlobalHistorial();
        }

        private void especificoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaAdminReportePersonalizado rp = new VentanaAdminReportePersonalizado();
            rp.ShowDialog();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedItem == null) return;

            dgvReporteGlobal.DataSource = null;
            dgvReporteGlobal.AutoGenerateColumns = true;

            if (cmbFiltro.SelectedItem is Usuario usuarioSeleccionado)
            {
                dgvReporteGlobal.DataSource = reportes.GetReportePorUsuario(usuarioSeleccionado.Nombre);
            }
            else if (cmbFiltro.SelectedItem is ElementoCombo juegoSeleccionado)
            {
                dgvReporteGlobal.DataSource = reportes.GetReportePorJuego(juegoSeleccionado.Nombre);
            }
            else if (cmbFiltro.SelectedItem is Personaje personajeSeleccionado)
            {
                dgvReporteGlobal.DataSource = reportes.GetReportePorPersonaje(personajeSeleccionado.Nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
