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
    public partial class AgregarRecursos : Form
    {
        usuariosDB usuarios = new usuariosDB();
        public AgregarRecursos()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAbono.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingresa un monto de apuesta válido.", "Atención");
                return;
            }
            decimal creditos = monto/2;// cada creido vale 2 pesos 
            //usuariodb=>modificar mnonto
            //metodo para modificar el monto con el ususario y el id 
            PersonajeGuardado personaje = (PersonajeGuardado)cmbPersonajesUsuario.SelectedItem;
            double nuevoSaldo = personaje.Saldo + (double)creditos;
            usuarios.ActualizarSaldoPersonaje(personaje.Id, nuevoSaldo);

            if(personaje.Id == SesionGlobal.PersonajeGuardadoId)
            {
                SesionGlobal.SaldoActual = nuevoSaldo;
            }
            MessageBox.Show($"Se abonaron {creditos} créditos correctamente", "Éxito");
            txtAbono.Clear();
            CargarCombos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarCombos()
        {
            cmbPersonajesUsuario.DataSource = usuarios.ObtenerPersonajesDelUsuario(SesionGlobal.UsuarioId);
            cmbPersonajesUsuario.DisplayMember = "InfoVisual";
            cmbPersonajesComprar.DataSource = usuarios.ObtenerPersonajesDisponibles(SesionGlobal.UsuarioId);
            cmbPersonajesComprar.DisplayMember = "Nombre";
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Personaje personaje = (Personaje)cmbPersonajesComprar.SelectedItem;

            double precio = 500;

            if (SesionGlobal.SaldoActual < precio)
            {
                MessageBox.Show("No tienes suficiente dinero");
                return;
            }

            double saldoRestante = SesionGlobal.SaldoActual - precio;

            usuarios.ComprarPersonaje(SesionGlobal.UsuarioId, personaje.Id, saldoRestante);

            SesionGlobal.SaldoActual = saldoRestante;

            MessageBox.Show("Personaje comprado");

            CargarCombos();
        }
    }
}
