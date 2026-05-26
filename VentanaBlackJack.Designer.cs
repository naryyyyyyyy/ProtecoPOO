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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaBlackJack));
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
            this.btnAceptarApuesta = new System.Windows.Forms.Button();
            this.lbsaldo = new System.Windows.Forms.Label();
            this.lblApuestaEnJuego = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowJugador
            // 
            this.flowJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowJugador.BackColor = System.Drawing.Color.Transparent;
            this.flowJugador.Location = new System.Drawing.Point(34, 220);
            this.flowJugador.Name = "flowJugador";
            this.flowJugador.Size = new System.Drawing.Size(459, 111);
            this.flowJugador.TabIndex = 11;
            // 
            // flowCasa
            // 
            this.flowCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowCasa.BackColor = System.Drawing.Color.Transparent;
            this.flowCasa.Location = new System.Drawing.Point(34, 79);
            this.flowCasa.Name = "flowCasa";
            this.flowCasa.Size = new System.Drawing.Size(459, 123);
            this.flowCasa.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Transparent;
            this.lblResultado.Location = new System.Drawing.Point(605, 304);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(22, 22);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "...";
            // 
            // lblPuntosJugador
            // 
            this.lblPuntosJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuntosJugador.AutoSize = true;
            this.lblPuntosJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntosJugador.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosJugador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuntosJugador.Location = new System.Drawing.Point(639, 274);
            this.lblPuntosJugador.Name = "lblPuntosJugador";
            this.lblPuntosJugador.Size = new System.Drawing.Size(22, 22);
            this.lblPuntosJugador.TabIndex = 8;
            this.lblPuntosJugador.Text = "...";
            // 
            // lblPuntosCasa
            // 
            this.lblPuntosCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuntosCasa.AutoSize = true;
            this.lblPuntosCasa.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntosCasa.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosCasa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuntosCasa.Location = new System.Drawing.Point(448, 56);
            this.lblPuntosCasa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntosCasa.Name = "lblPuntosCasa";
            this.lblPuntosCasa.Size = new System.Drawing.Size(26, 22);
            this.lblPuntosCasa.TabIndex = 9;
            this.lblPuntosCasa.Text = "....";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReiniciar.Font = new System.Drawing.Font("Sylfaen", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(103, 169);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(62, 23);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnPlantarse
            // 
            this.btnPlantarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlantarse.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantarse.Location = new System.Drawing.Point(325, 346);
            this.btnPlantarse.Name = "btnPlantarse";
            this.btnPlantarse.Size = new System.Drawing.Size(75, 23);
            this.btnPlantarse.TabIndex = 5;
            this.btnPlantarse.Text = "Plantarse";
            this.btnPlantarse.UseVisualStyleBackColor = true;
            this.btnPlantarse.Click += new System.EventHandler(this.btnPlantarse_Click);
            // 
            // btnPedir
            // 
            this.btnPedir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPedir.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Italic);
            this.btnPedir.Location = new System.Drawing.Point(419, 346);
            this.btnPedir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(75, 23);
            this.btnPedir.TabIndex = 6;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // txtApuesta
            // 
            this.txtApuesta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApuesta.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApuesta.Location = new System.Drawing.Point(37, 140);
            this.txtApuesta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApuesta.Name = "txtApuesta";
            this.txtApuesta.Size = new System.Drawing.Size(116, 25);
            this.txtApuesta.TabIndex = 12;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaldo.Location = new System.Drawing.Point(99, 346);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(30, 22);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = ".....";
            // 
            // btnAceptarApuesta
            // 
            this.btnAceptarApuesta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptarApuesta.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarApuesta.Location = new System.Drawing.Point(26, 170);
            this.btnAceptarApuesta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAceptarApuesta.Name = "btnAceptarApuesta";
            this.btnAceptarApuesta.Size = new System.Drawing.Size(59, 23);
            this.btnAceptarApuesta.TabIndex = 14;
            this.btnAceptarApuesta.Text = "Aceptar Apuesta";
            this.btnAceptarApuesta.UseVisualStyleBackColor = true;
            this.btnAceptarApuesta.Click += new System.EventHandler(this.btnAceptarApuesta_Click);
            // 
            // lbsaldo
            // 
            this.lbsaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsaldo.AutoSize = true;
            this.lbsaldo.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsaldo.Location = new System.Drawing.Point(85, 62);
            this.lbsaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsaldo.Name = "lbsaldo";
            this.lbsaldo.Size = new System.Drawing.Size(30, 22);
            this.lbsaldo.TabIndex = 15;
            this.lbsaldo.Text = ".....";
            // 
            // lblApuestaEnJuego
            // 
            this.lblApuestaEnJuego.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApuestaEnJuego.AutoSize = true;
            this.lblApuestaEnJuego.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApuestaEnJuego.Location = new System.Drawing.Point(99, 89);
            this.lblApuestaEnJuego.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApuestaEnJuego.Name = "lblApuestaEnJuego";
            this.lblApuestaEnJuego.Size = new System.Drawing.Size(30, 22);
            this.lblApuestaEnJuego.TabIndex = 15;
            this.lblApuestaEnJuego.Text = ".....";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(595, 374);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 27);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblApuestaEnJuego);
            this.panel1.Controls.Add(this.lbsaldo);
            this.panel1.Controls.Add(this.btnAceptarApuesta);
            this.panel1.Controls.Add(this.txtApuesta);
            this.panel1.Controls.Add(this.btnReiniciar);
            this.panel1.Location = new System.Drawing.Point(506, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 213);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ingresar apuesta:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apuesta:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Saldo:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "BlackJack";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(341, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Puntos Casa:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(41, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Saldo:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(510, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Puntos Jugador:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(510, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Resultado:";
            // 
            // VentanaBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 424);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.flowJugador);
            this.Controls.Add(this.flowCasa);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPuntosJugador);
            this.Controls.Add(this.lblPuntosCasa);
            this.Controls.Add(this.btnPlantarse);
            this.Controls.Add(this.btnPedir);
            this.Name = "VentanaBlackJack";
            this.Text = "VentanaBlackJack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaBlackJack_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnAceptarApuesta;
        private System.Windows.Forms.Label lbsaldo;
        private System.Windows.Forms.Label lblApuestaEnJuego;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}