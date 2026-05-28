
using ProtecoPOO.CasinoSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtecoPOO
{
    public partial class AgregarRecursos : Form
    {
        private string cadenaConexion;//conn
        new ReportesDB reporte;
        int idPlayer = SesionGlobal.UsuarioId;
        int  idPlayerPers=SesionGlobal.PersonajeGuardadoId;
        double saldoNu = SesionGlobal.SaldoActual;
        string name = SesionGlobal.NombreUsuario;

        /// <summary>
        /// se tiene que pasar el objeto usuario a esta ventana para qu ese pueda guardar con el id
        /// </summary>
        public AgregarRecursos()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAbono.Text, out double monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingresa un monto de abono válido.", "Atención");
                return;
            }
            else
            {
                if (saldoNu == 0)
                {
                    saldoNu=1000;
                    //usuariosDB.Modificarsaldo(saldoNu, SesionGlobal.UsuarioId, SesionGlobal.PersonajeGuardadoId);

                    MessageBox.Show($"Fondos Agregados a {name} con personaje {idPlayerPers}. Ahora tu saldo es de: {saldoNu}.", "Atención");
                }
                MessageBox.Show($"Fondos No agregados a {name}. Se detecto credito aun vigente", "Atención");
                return;
            }

            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
