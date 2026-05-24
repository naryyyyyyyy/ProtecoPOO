namespace ProtecoPOO
{
    partial class VentanaBlackJack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowJugador = new System.Windows.Forms.FlowLayoutPanel();
            this.flowCasa = new System.Windows.Forms.FlowLayoutPanel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPuntosJugador = new System.Windows.Forms.Label();
            this.lblPuntosCasa = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnPlantarse = new System.Windows.Forms.Button();
            this.btnPedir = new System.Windows.Forms.Button();
            this.txtApuesta = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnAcetarApuesta = new System.Windows.Forms.Button();
            this.lbsaldo = new System.Windows.Forms.Label();
            this.lblApuestaEnJuego = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowJugador
            // 
            this.flowJugador.Location = new System.Drawing.Point(27, 222);
            this.flowJugador.Name = "flowJugador";
            this.flowJugador.Size = new System.Drawing.Size(632, 111);
            this.flowJugador.TabIndex = 11;
            // 
            // flowCasa
            // 
            this.flowCasa.Location = new System.Drawing.Point(34, 80);
            this.flowCasa.Name = "flowCasa";
            this.flowCasa.Size = new System.Drawing.Size(625, 123);
            this.flowCasa.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(500, 336);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "...";
            // 
            // lblPuntosJugador
            // 
            this.lblPuntosJugador.AutoSize = true;
            this.lblPuntosJugador.Location = new System.Drawing.Point(321, 336);
            this.lblPuntosJugador.Name = "lblPuntosJugador";
            this.lblPuntosJugador.Size = new System.Drawing.Size(16, 13);
            this.lblPuntosJugador.TabIndex = 8;
            this.lblPuntosJugador.Text = "...";
            // 
            // lblPuntosCasa
            // 
            this.lblPuntosCasa.AutoSize = true;
            this.lblPuntosCasa.BackColor = System.Drawing.SystemColors.Window;
            this.lblPuntosCasa.Location = new System.Drawing.Point(321, 52);
            this.lblPuntosCasa.Name = "lblPuntosCasa";
            this.lblPuntosCasa.Size = new System.Drawing.Size(16, 13);
            this.lblPuntosCasa.TabIndex = 9;
            this.lblPuntosCasa.Text = "...";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(694, 222);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnPlantarse
            // 
            this.btnPlantarse.Location = new System.Drawing.Point(348, 352);
            this.btnPlantarse.Name = "btnPlantarse";
            this.btnPlantarse.Size = new System.Drawing.Size(75, 23);
            this.btnPlantarse.TabIndex = 5;
            this.btnPlantarse.Text = "plantarse";
            this.btnPlantarse.UseVisualStyleBackColor = true;
            this.btnPlantarse.Click += new System.EventHandler(this.btnPlantarse_Click);
            // 
            // btnPedir
            // 
            this.btnPedir.Location = new System.Drawing.Point(234, 352);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(75, 23);
            this.btnPedir.TabIndex = 6;
            this.btnPedir.Text = "pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // txtApuesta
            // 
            this.txtApuesta.Location = new System.Drawing.Point(679, 138);
            this.txtApuesta.Name = "txtApuesta";
            this.txtApuesta.Size = new System.Drawing.Size(100, 20);
            this.txtApuesta.TabIndex = 12;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(490, 362);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(35, 13);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "label1";
            // 
            // btnAcetarApuesta
            // 
            this.btnAcetarApuesta.Location = new System.Drawing.Point(694, 180);
            this.btnAcetarApuesta.Name = "btnAcetarApuesta";
            this.btnAcetarApuesta.Size = new System.Drawing.Size(75, 23);
            this.btnAcetarApuesta.TabIndex = 14;
            this.btnAcetarApuesta.Text = "Aceptar Apuesta";
            this.btnAcetarApuesta.UseVisualStyleBackColor = true;
            this.btnAcetarApuesta.Click += new System.EventHandler(this.btnAceptarApuesta_Click);
            // 
            // lbsaldo
            // 
            this.lbsaldo.AutoSize = true;
            this.lbsaldo.Location = new System.Drawing.Point(679, 80);
            this.lbsaldo.Name = "lbsaldo";
            this.lbsaldo.Size = new System.Drawing.Size(19, 13);
            this.lbsaldo.TabIndex = 15;
            this.lbsaldo.Text = "....";
            // 
            // lblApuestaEnJuego
            // 
            this.lblApuestaEnJuego.AutoSize = true;
            this.lblApuestaEnJuego.Location = new System.Drawing.Point(679, 105);
            this.lblApuestaEnJuego.Name = "lblApuestaEnJuego";
            this.lblApuestaEnJuego.Size = new System.Drawing.Size(19, 13);
            this.lblApuestaEnJuego.TabIndex = 15;
            this.lblApuestaEnJuego.Text = "....";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(704, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // VentanaBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblApuestaEnJuego);
            this.Controls.Add(this.lbsaldo);
            this.Controls.Add(this.btnAcetarApuesta);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtApuesta);
            this.Controls.Add(this.flowJugador);
            this.Controls.Add(this.flowCasa);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPuntosJugador);
            this.Controls.Add(this.lblPuntosCasa);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnPlantarse);
            this.Controls.Add(this.btnPedir);
            this.Name = "VentanaBlackJack";
            this.Text = "VentanaBlackJack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowJugador;
        private System.Windows.Forms.FlowLayoutPanel flowCasa;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPuntosJugador;
        private System.Windows.Forms.Label lblPuntosCasa;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnPlantarse;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.TextBox txtApuesta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnAcetarApuesta;
        private System.Windows.Forms.Label lbsaldo;
        private System.Windows.Forms.Label lblApuestaEnJuego;
        private System.Windows.Forms.Button btnSalir;
    }
}