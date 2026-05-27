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
    public partial class VentanaUsuario : Form
    {
        public VentanaUsuario()
        {

            InitializeComponent();
            ValidacionDeRecursos();

            

            //metodo apr los datos del usuario 
            //lblNombre=.....
            //lblSaldo=....
        }

        private void btnblackjack_Click(object sender, EventArgs e)
        {
            //validacion de que si tenga almas para jugar
            VentanaBlackJack frm=new VentanaBlackJack();
            frm.ShowDialog();
            CargarHistorial();
            ValidacionDeRecursos();
        }

        private void btnCarreraCaballos_Click(object sender, EventArgs e)
        {
            CarreraCaballos carreracaballo = new CarreraCaballos();
            carreracaballo.ShowDialog();
            CargarHistorial();
            ValidacionDeRecursos();
        }

        private void btnIrAbonar_Click(object sender, EventArgs e)
        {
            AgregarRecursos frm=new AgregarRecursos();
            frm.ShowDialog();
            //Metodo apra extaer el saldo del usuario
            //pordia ser el get ususario().Saldo;
            //lblSaldo.Text=Getusuario.saldo();
           
            
        }
        private void CargarHistorial()
        {
            // Aquí va tu lógica original de carga, por ejemplo:
            // var historial = bdususario........
            // dataGridView1.DataSource = historial;
        }
        private void ValidacionDeRecursos()
        {
            //este metodo deve de comprovar que en la base de datos
            //el personaje del ususario tenga recursos
            /*if(usuario.monto=<0){
             btnBlackjack.Enueble=false;
            btnCarreraCaballos.Eneble=false;
              }
            */
        }
    }
}
