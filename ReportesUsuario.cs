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
    public partial class ReportesUsuario : Form
    {
        usuariosDB usuario = new usuariosDB();
        public ReportesUsuario()
        {
            InitializeComponent();
            CargarEstadisticas();

        }

        private void CargarEstadisticas()
        {
            lblMasJugado.Text = usuario.ObtenerPersonajeMasJugado(SesionGlobal.UsuarioId);
            lblMasRico.Text = usuario.ObtenerPersonajeMasRico(SesionGlobal.UsuarioId);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgvRepostesUsusario.DataSource = null;
            string opcion = cmbFiltro.SelectedItem.ToString();
            if(opcion == "Por saldo")
            {
                dgvRepostesUsusario.DataSource = usuario.ReportePersonajesPorSaldo(SesionGlobal.UsuarioId);
                dgvRepostesUsusario.AutoGenerateColumns = true;
            }
            else if(opcion == "Por partidas")
            {
                dgvRepostesUsusario.DataSource = usuario.ReportePersonajesPorReapuestas(SesionGlobal.UsuarioId);
                dgvRepostesUsusario.AutoGenerateColumns = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
