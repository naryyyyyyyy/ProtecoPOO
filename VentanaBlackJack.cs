using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using ProtecoPOO.CasinoSQL;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtecoPOO
{
    public partial class VentanaBlackJack : Form
    {
        usuariosDB reporte = new usuariosDB();
        /*
        // La baraja será una lista de textos. Ej: "c1", "p12", "t5"
        private List<string> baraja = new List<string>();

        // Las manos del jugador y la banca/casa
        private List<string> cartasJugador = new List<string>();
        private List<string> cartasCasa = new List<string>();

        // El generador de azar para revolver las cartas
        private Random random = new Random();
        public VentanaBlackJack()
        {
            InitializeComponent();
           // IniciarPartida();
        }
        private void CrearBaraja()
        {
            baraja.Clear();
            // Los 4 palos: c = corazones, d = diamantes, t = tréboles, p = picas
            string[] palos = { "c", "d", "t", "p" };

            foreach (string p in palos)
            {
                for (int i = 1; i <= 13; i++)
                {
                    // Esto agrega "c1", "c2"... "p13" a la lista
                    baraja.Add(p + i);
                }
            }
        }
        private void RepartirCarta(List<string> mano, FlowLayoutPanel panel)
        {
            if (baraja.Count == 0) return;

            // 1. Elegir carta al azar
            int indice = random.Next(baraja.Count);
            string nombreCarta = baraja[indice];
            baraja.RemoveAt(indice); // La quitamos para que no se repita

            // 2. Agregarla a la lista de la mano (Jugador o Casa)
            mano.Add(nombreCarta);

            // 3. Crear el control de imagen visualmente
            PictureBox pic = new PictureBox();
            pic.Size = new System.Drawing.Size(90, 130); // Tamaño de la carta
            pic.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar imagen al tamaño

            // 4. Buscar la imagen en tus recursos por su nombre (c1, d5, etc.)
            pic.Image = (System.Drawing.Image)ProtecoPOO.Properties.Resources.ResourceManager.GetObject(nombreCarta);

            // 5. Agregar la imagen al panel (flowJugador o flowCasa)
            panel.Controls.Add(pic);
        }
        private int CalcularPuntos(List<string> mano)
        {
            int total = 0;
            int ases = 0;

            foreach (string carta in mano)
            {
                // Quitamos la letra (c, d, p, t) y nos quedamos con el número
                int valor = int.Parse(carta.Substring(1));

                if (valor == 1) // Es un As
                {
                    ases++;
                    total += 11;
                }
                else if (valor >= 10) // J, Q, K valen 10
                {
                    total += 10;
                }
                else
                {
                    total += valor;
                }
            }

            // Si nos pasamos de 21 y tenemos Ases, el As pasa a valer 1 (restamos 10)
            while (total > 21 && ases > 0)
            {
                total -= 10;
                ases--;
            }

            return total;
        }
        private void IniciarPartida()
        {
            // Limpiamos todo lo anterior
            CrearBaraja();
            cartasJugador.Clear();
            cartasCasa.Clear();
            flowJugador.Controls.Clear();
            flowCasa.Controls.Clear();
            lblResultado.Text = "Tu turno. ¿Pides o te plantas?";
            btnPedir.Enabled = true;
            btnPlantarse.Enabled = true;

            // Repartimos las cartas iniciales (Regla estándar: 2 al jugador, 1 a la casa)
            RepartirCarta(cartasJugador, flowJugador);
            RepartirCarta(cartasJugador, flowJugador);
            RepartirCarta(cartasCasa, flowCasa);

            // Actualizamos los puntajes iniciales
            lblPuntosJugador.Text = "Puntos Jugador: " + CalcularPuntos(cartasJugador);
            // De la casa no mostramos puntos aún porque solo tiene una carta
            lblPuntosCasa.Text = "Puntos Casa: ?";
        }

        private void btnPlantarse_Click(object sender, EventArgs e)
        {

            // 1. Desactivamos los botones para que el jugador ya no pueda hacer nada
            btnPedir.Enabled = false;
            btnPlantarse.Enabled = false;

            // 2. La IA de la casa pide cartas automáticamente si tiene menos de 17 puntos
            while (CalcularPuntos(cartasCasa) < 17)
            {
                RepartirCarta(cartasCasa, flowCasa);
            }

            // 3. Calculamos los puntajes finales de ambos
            int puntosJugador = CalcularPuntos(cartasJugador);
            int puntosCasa = CalcularPuntos(cartasCasa);

            // 4. Mostramos el puntaje final de la casa en su Label
            lblPuntosCasa.Text = "Puntos Casa: " + puntosCasa;

            // 5. Definimos quién ganó según las reglas del Blackjack
            if (puntosCasa > 21)
            {
                lblResultado.Text = "¡La casa se pasó de 21! ¡TÚ GANAS! 🎉";
            }
            else if (puntosJugador > puntosCasa)
            {
                lblResultado.Text = "¡Ganaste! Tienes mejor puntuación. 🏆";
            }
            else if (puntosJugador < puntosCasa)
            {
                lblResultado.Text = "La casa gana. Más suerte la próxima. 🏠";
            }
            else
            {
                lblResultado.Text = "Empate. Se devuelven las apuestas. 🤝";
            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            // 1. Le damos una carta más al jugador
            RepartirCarta(cartasJugador, flowJugador);

            // 2. Calculamos sus nuevos puntos
            int puntosJugador = CalcularPuntos(cartasJugador);

            // 3. Actualizamos el texto en pantalla (lblPuntosJugador es el nombre de tu Label)
            lblPuntosJugador.Text = "Puntos Jugador: " + puntosJugador;

            // 4. Verificamos si perdió
            if (puntosJugador > 21)
            {
                lblResultado.Text = "¡TE PASASTE! La casa gana.";
                // Desactivamos los botones porque el juego terminó
                btnPedir.Enabled = false;
                btnPlantarse.Enabled = false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            IniciarPartida();
        }*/
        // Instancia global del juego de Blackjack (ID 1 por ejemplo)
        private BlackJack juegoBJ = new BlackJack("Blackjack 21", 1);

        // Nombre del jugador en sesión (Esto vendrá del formulario de Login)
        private string nombreUsuarioActual = "Juan Pérez";

        public VentanaBlackJack()
        {
            InitializeComponent();

            // SIMULACIÓN PUNTO 2: Simulamos la extracción de la base de datos como entero/decimal
            // En el Login harías la consulta SQL y le pasarías el resultado aquí:
            decimal saldoDeBaseDatos = 1000;

            juegoBJ.CargarSaldoInicial(saldoDeBaseDatos);

            // Reflejamos el saldo inicial en la interfaz visual
            lbsaldo.Text = "Tu Saldo: $" + juegoBJ.SaldoJugador;
            lblApuestaEnJuego.Text = "Apuesta en juego: $0";
            

            // Apagamos los botones de juego hasta que el jugador realice una apuesta válida
            btnPedir.Enabled = false;
            btnPlantarse.Enabled = false;
        }

        // BOTÓN: Aceptar Apuesta e Iniciar Mano
        private void btnAceptarApuesta_Click(object sender, EventArgs e)
        {
            // Validamos que el texto ingresado sea un número decimal correcto
            if (!decimal.TryParse(txtApuesta.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingresa un monto de apuesta válido.", "Atención");
                return;
            }

            // PUNTO 2: Validación de saldo usando la clase padre Juego
            if (!juegoBJ.ValidarYColocarApuesta(monto))
            {
                // Si la función regresa false, es porque la apuesta supera su saldo disponible
                MessageBox.Show("No cuentas con saldo suficiente para realizar esta apuesta.", "Fondos Insuficientes");
                return;
            }

            // Actualizamos los labels en tiempo real para mostrar la retención del dinero
            lbsaldo.Text = "Tu Saldo: $" + juegoBJ.SaldoJugador;
            lblApuestaEnJuego.Text = "Apuesta en juego: $" + juegoBJ.ApuestaActual;

            // Bloqueamos el botón de apostar para que no pueda cambiar la apuesta a mitad de la mano
            btnAceptarApuesta.Enabled = false;
            txtApuesta.Enabled = false;

            // Activamos los botones de acción del juego
            btnPedir.Enabled = true;
            btnPlantarse.Enabled = true;

            // Iniciamos la ronda lógica y limpiamos paneles visuales
            juegoBJ.IniciarNuevaMano();
            flowJugador.Controls.Clear();
            flowCasa.Controls.Clear();
            lblResultado.Text = "Tu turno. ¿Pides o te plantas?";

            // Repartimos las cartas iniciales (2 al jugador, 1 a la casa)
            RepartirCartaVisual(juegoBJ.cartasJugador, flowJugador);
            RepartirCartaVisual(juegoBJ.cartasJugador, flowJugador);
            RepartirCartaVisual(juegoBJ.cartasCasa, flowCasa);

            // Actualizamos los puntajes iniciales en pantalla
            lblPuntosJugador.Text = "Puntos Jugador: " + juegoBJ.CalcularPuntos(juegoBJ.cartasJugador);
            lblPuntosCasa.Text = "Puntos Casa: ?";
        }

        // Conecta la extracción lógica de la carta con la creación del control de imagen en el formulario
        private void RepartirCartaVisual(List<string> mano, FlowLayoutPanel panel)
        {
            string nombreCarta = juegoBJ.ExtraerCartaAlAzar();
            if (nombreCarta == null) return;

            // Agregarla a la lista lógica de la mano correspondiente
            mano.Add(nombreCarta);

            // Crear el control de imagen visualmente
            PictureBox pic = new PictureBox();
            pic.Size = new System.Drawing.Size(90, 130); // Tamaño de la carta
            pic.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar imagen al tamaño

            // Buscar la imagen en tus recursos por su nombre (c1, d5, etc.) usando el espacio de nombres del equipo
            pic.Image = (System.Drawing.Image)ProtecoPOO.Properties.Resources.ResourceManager.GetObject(nombreCarta);

            // Agregar la imagen al panel visual (flowJugador o flowCasa)
            panel.Controls.Add(pic);
        }

        // BOTÓN: Pedir Carta
        private void btnPedir_Click(object sender, EventArgs e)
        {
            // Le damos una carta más al jugador y la dibujamos
            RepartirCartaVisual(juegoBJ.cartasJugador, flowJugador);

            // Calculamos sus nuevos puntos
            int puntosJugador = juegoBJ.CalcularPuntos(juegoBJ.cartasJugador);
            lblPuntosJugador.Text = "Puntos Jugador: " + puntosJugador;

            // Verificamos si perdió al exceder los 21 puntos
            if (puntosJugador > 21)
            {
                lblResultado.Text = "¡TE PASASTE! La casa gana.";
                FinalizarManoMesa("PERDIO");
            }
        }

        // BOTÓN: Plantarse (Turno de la IA de la Casa)
        private void btnPlantarse_Click(object sender, EventArgs e)
        {
            btnPedir.Enabled = false;
            btnPlantarse.Enabled = false;

            // La IA de la casa pide cartas automáticamente si tiene menos de 17 puntos
            while (juegoBJ.CalcularPuntos(juegoBJ.cartasCasa) < 17)
            {
                RepartirCartaVisual(juegoBJ.cartasCasa, flowCasa);
            }

            // Calculamos los puntajes finales de ambos desde la clase de lógica
            int puntosJugador = juegoBJ.CalcularPuntos(juegoBJ.cartasJugador);
            int puntosCasa = juegoBJ.CalcularPuntos(juegoBJ.cartasCasa);

            // Mostramos el puntaje final de la casa en su Label
            lblPuntosCasa.Text = "Puntos Casa: " + puntosCasa;

            // Definimos quién ganó según las reglas del Blackjack y actualizamos el estado
            if (puntosCasa > 21)
            {
                lblResultado.Text = "¡La casa se pasó de 21! ¡TÚ GANAS! 🎉";
                FinalizarManoMesa("GANASTE");
            }
            else if (puntosJugador > puntosCasa)
            {
                lblResultado.Text = "¡Ganaste! Tienes mejor puntuación. 🏆";
                FinalizarManoMesa("GANASTE");
            }
            else if (puntosJugador < puntosCasa)
            {
                lblResultado.Text = "La casa gana. Más suerte la próxima. 🏠";
                FinalizarManoMesa("PERDIO");
            }
            else
            {
                lblResultado.Text = "Empate. Se devuelven las apuestas. 🤝";
                FinalizarManoMesa("EMPATE");
            }
        }

        // Centraliza el cobro/pago y la actualización de los textos al terminar la jugada
        private void FinalizarManoMesa(string dictamen)
        {
            // Apagamos controles de acción
            btnPedir.Enabled = false;
            btnPlantarse.Enabled = false;

            // Calculamos la ganancia correspondiente usando las reglas de negocio
            decimal dineroDevuelto = juegoBJ.CalcularPagoPorResultado(dictamen);

            // Impactamos el saldo en memoria de la clase Juego
            juegoBJ.RegistrarResultado(dineroDevuelto);

            // PUNTO 2: Actualizamos los componentes gráficos con los saldos nuevos
            lbsaldo.Text = "Tu Saldo: $" + juegoBJ.SaldoJugador;
            lblApuestaEnJuego.Text = "Apuesta en juego: $0";

            // Habilitamos el botón de reiniciar para otra ronda
            btnReiniciar.Enabled = true;
        }

        // BOTÓN: Volver a Jugar (Nueva Ronda)
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // PUNTO 2: Si se quedó sin saldo, salta el aviso y lo saca de inmediato
            if (juegoBJ.SaldoJugador <= 0)
            {
                MessageBox.Show("Te has quedado sin dinero en tu cuenta de casino. Serás redirigido al menú.", "Fin del Juego");
                this.Close(); // Cierra de manera inmediata la ventana actual
                return;
            }

            // Si tiene saldo, limpiamos cajas listas para recibir la nueva cantidad a apostar
            txtApuesta.Clear();
            txtApuesta.Enabled = true;
            btnAceptarApuesta.Enabled = true;

            flowJugador.Controls.Clear();
            flowCasa.Controls.Clear();
            lblPuntosJugador.Text = "Puntos Jugador: 0";
            lblPuntosCasa.Text = "Puntos Casa: 0";
            lblResultado.Text = "Ingresa una nueva apuesta para comenzar.";
        }

        // BOTÓN: Salir (Envío final de reportes y persistencia a Base de Datos)
        private void btnSalir_Click(object sender, EventArgs e)
        {//esto me lo imagino como un metodo en el que doy en id del usuario id de juego monto y talves un estatus tipo 1 si la casa perdio y 0 se la casa gano
            //y aparte otro en donde yo le doy id y saldo para modificar el saldo del jugador
            // =========================================================================
            // COMENTARIOS DE SQL REQUERIDOS (CÓMO DEBERÍA LUCIR LA CONEXIÓN)
            // =========================================================================
            /*
               try
               {
                   // 1. Abrir la conexión con el string configurado de SQL Server
                   using (SqlConnection conexion = new SqlConnection("Server=TU_SERVIDOR; Database=CasinoPOO; Integrated Security=True;"))
                   {
                       conexion.Open();

                       // SQL DE ACTUALIZACIÓN DE SALDO (Punto 2): Actualiza la cartera del usuario con su saldo final de la ventana
                       string querySaldo = "UPDATE Usuarios SET Saldo = @saldoFinal WHERE NombreUsuario = @usuario";
                       using (SqlCommand cmdSaldo = new SqlCommand(querySaldo, conexion))
                       {
                           cmdSaldo.Parameters.AddWithValue("@saldoFinal", juegoBJ.SaldoJugador);
                           cmdSaldo.Parameters.AddWithValue("@usuario", nombreUsuarioActual);
                           cmdSaldo.ExecuteNonQuery();
                       }

                       // SQL DE REPORTE (Punto 2): Registra la bitácora "El jugador x jugó en el juego x y se retiró con x"
                       string queryHistorial = "INSERT INTO HistorialJugadas (Usuario, JuegoID, SaldoFinalRetiro, Fecha) VALUES (@usuario, @juegoId, @saldoFinal, GETDATE())";
                       using (SqlCommand cmdHist = new SqlCommand(queryHistorial, conexion))
                       {
                           cmdHist.Parameters.AddWithValue("@usuario", nombreUsuarioActual);
                           cmdHist.Parameters.AddWithValue("@juegoId", juegoBJ.JuegoId);
                           cmdHist.Parameters.AddWithValue("@saldoFinal", juegoBJ.SaldoJugador);
                           cmdHist.ExecuteNonQuery();
                       }
                   }
               }
               catch(Exception ex)
               {
                   MessageBox.Show("Error al sincronizar con la Base de Datos: " + ex.Message);
               }
            */

            // Cerramos la ventana de manera normal regresando al menú principal
            this.Close();
        }

        private void VentanaBlackJack_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
    
     }
}
