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
    public partial class VentanaAdminReportePersonalizado : Form
    {
        usuariosDB usuarios = new usuariosDB();
        ReportesDB reportes = new ReportesDB();
        public VentanaAdminReportePersonalizado()
        {
            InitializeComponent();
        }

        private void VentanaAdminReportePersonalizado_Load(object sender, EventArgs e)
        {
            var listaUsuarios = usuarios.GetAllUsuarios();
            listaUsuarios.Insert(0, new Usuario { Id = 0, Nombre = "Todos" });
            cmbUsuario.DataSource = listaUsuarios;
            cmbUsuario.DisplayMember = "Nombre";
            cmbUsuario.ValueMember = "Id";

            // 2. Cargar Juegos
            var listaJuegos = usuarios.GetAllJuegos();
            listaJuegos.Insert(0, new ElementoCombo { Id = 0, Nombre = "Todos" });
            cmbJuego.DataSource = listaJuegos;
            cmbJuego.DisplayMember = "Nombre";
            cmbJuego.ValueMember = "Id";

            // 3. Cargar Personajes
            var listaPersonajes = usuarios.GetAllPersonajes();
            listaPersonajes.Insert(0, new Personaje("Todos", 0)); // Respetando tu constructor

            // ¡ESTA LÍNEA ES LA QUE FALTABA PARA QUE SE LLENARA!
            cmbPersonaje.DataSource = listaPersonajes;

            cmbPersonaje.DisplayMember = "Nombre";
            cmbPersonaje.ValueMember = "Id";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int idUser = cmbUsuario.SelectedValue != null ? (int)cmbUsuario.SelectedValue : 0;
            int idGame = cmbJuego.SelectedValue != null ? (int)cmbJuego.SelectedValue : 0;
            int idChar = cmbPersonaje.SelectedValue != null ? (int)cmbPersonaje.SelectedValue : 0;

            bool esAscendente = !chkAscendente.Checked;

            dgvReportePersonalizado.DataSource = null;
            dgvReportePersonalizado.AutoGenerateColumns = true;

            // Asignamos la lista
            dgvReportePersonalizado.DataSource = reportes.GetReportePersonalizado(idUser, idGame, idChar, esAscendente);

            // =========================================================
            // TRUCO DE REDUNDANCIA: Ocultar columnas dinámicamente
            // Si el ID es mayor a 0 (eligió algo específico), ocultamos la columna (Visible = false).
            // Si el ID es 0 (eligió "Todos"), mostramos la columna (Visible = true).
            // =========================================================

            if (dgvReportePersonalizado.Columns.Contains("Jugador"))
                dgvReportePersonalizado.Columns["Jugador"].Visible = (idUser == 0);

            if (dgvReportePersonalizado.Columns.Contains("Juego"))
                dgvReportePersonalizado.Columns["Juego"].Visible = (idGame == 0);

            if (dgvReportePersonalizado.Columns.Contains("Personaje"))
                dgvReportePersonalizado.Columns["Personaje"].Visible = (idChar == 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
