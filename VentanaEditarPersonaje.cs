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


    public partial class VentanaEditarPersonaje : Form
    {

        usuariosDB usuarios = new usuariosDB ();
        public VentanaEditarPersonaje()
        {

            InitializeComponent();
            cmbELeccionPersonaje.DataSource = usuarios.ObtenerPersonajesDelUsuario(SesionGlobal.UsuarioId);
            cmbELeccionPersonaje.DisplayMember = "InfoVisual";
            cmbELeccionPersonaje.ValueMember = "Id";

            if(cmbELeccionPersonaje.Items.Count > 0)
            {
                cmbELeccionPersonaje_SelectedIndexChanged(null, null);
            }

        }

        private void cmbELeccionPersonaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbELeccionPersonaje.SelectedItem is PersonajeGuardado personaje)
            {
                switch (personaje.PersonajeId)
                {
                    case 1:
                        picPersonaje.Image = Properties.Resources.barbaro;
                        break;

                    case 2:
                        picPersonaje.Image = Properties.Resources.picaro;
                        break;

                    case 3:
                        picPersonaje.Image = Properties.Resources.hechicero;
                        break;

                    case 4:
                        picPersonaje.Image = Properties.Resources.bardo;
                        break;

                    case 5:
                        picPersonaje.Image = Properties.Resources.hada;
                        break;

                    case 6:
                        picPersonaje.Image = Properties.Resources.sirena;
                        break;

                    case 7:
                        picPersonaje.Image = Properties.Resources.bruja;
                        break;

                    case 8:
                        picPersonaje.Image = Properties.Resources.cazador;
                        break;

                    case 9:
                        picPersonaje.Image = Properties.Resources.caballero;
                        break;
                }

                picPersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            PersonajeGuardado personajeSeleccionado = (PersonajeGuardado)cmbELeccionPersonaje.SelectedItem;

            SesionGlobal.PersonajeGuardadoId = personajeSeleccionado.Id;
                SesionGlobal.PersonajeCatalogoId = personajeSeleccionado.PersonajeId;
                SesionGlobal.SaldoActual = personajeSeleccionado.Saldo;
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PersonajeGuardado personaje = (PersonajeGuardado)cmbELeccionPersonaje.SelectedItem;

            if(personaje == null)
            {
                MessageBox.Show("Seleccione uun personaje.");
                return;
            }

            var personajesUsuario = usuarios.ObtenerPersonajesDelUsuario(SesionGlobal.UsuarioId);
            if (personajesUsuario.Count <= 1)
            {
                MessageBox.Show("No puedes eliminar tu último personaje", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(personaje.Id == SesionGlobal.PersonajeGuardadoId)
            {
                var nuevoPersonaje = usuarios.ObtenerPersonajesDelUsuario(SesionGlobal.UsuarioId).FirstOrDefault();
                if (nuevoPersonaje != null)
                {
                    SesionGlobal.PersonajeGuardadoId = nuevoPersonaje.Id;
                    SesionGlobal.PersonajeCatalogoId = nuevoPersonaje.PersonajeId;
                    SesionGlobal.SaldoActual = nuevoPersonaje.Saldo;
                }
            }
            DialogResult respuesta = MessageBox.Show(
                $"¿Deseas eliminar a {personaje.Nombre}?\n Se borrará también de tu historial",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(respuesta == DialogResult.Yes)
            {
                usuarios.BorrarPersonajeCompletamente(personaje.Id);
                MessageBox.Show("Personaje eliminado correctamente");
                cmbELeccionPersonaje.DataSource = null;
                cmbELeccionPersonaje.DataSource = usuarios.ObtenerPersonajesDelUsuario(SesionGlobal.UsuarioId);
                cmbELeccionPersonaje.DisplayMember = "InfoVisual";
                cmbELeccionPersonaje.ValueMember = "Id";
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprarPersonaje_Click(object sender, EventArgs e)
        {
            AgregarRecursos frm = new AgregarRecursos();
            frm.ShowDialog();

            CargarPersonajes();
        }

        private void CargarPersonajes()
        {
            cmbELeccionPersonaje.DataSource = null;
            cmbELeccionPersonaje.DataSource = usuarios.ObtenerPersonajesDelUsuario(SesionGlobal.UsuarioId);

            cmbELeccionPersonaje.DisplayMember = "InfoVisual";
            cmbELeccionPersonaje.ValueMember = "Id";
        }
    }
}
