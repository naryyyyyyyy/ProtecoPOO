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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowJugador
            // 
            this.flowJugador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowJugador.BackColor = System.Drawing.Color.Transparent;
            this.flowJugador.Location = new System.Drawing.Point(51, 338);
            this.flowJugador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowJugador.Name = "flowJugador";
            this.flowJugador.Size = new System.Drawing.Size(688, 171);
            this.flowJugador.TabIndex = 11;
            // 
            // flowCasa
            // 
            this.flowCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowCasa.BackColor = System.Drawing.Color.Transparent;
            this.flowCasa.Location = new System.Drawing.Point(51, 122);
            this.flowCasa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowCasa.Name = "flowCasa";
            this.flowCasa.Size = new System.Drawing.Size(688, 189);
            this.flowCasa.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Transparent;
            this.lblResultado.Location = new System.Drawing.Point(782, 478);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(32, 31);
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
            this.lblPuntosJugador.Location = new System.Drawing.Point(782, 428);
            this.lblPuntosJugador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosJugador.Name = "lblPuntosJugador";
            this.lblPuntosJugador.Size = new System.Drawing.Size(32, 31);
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
            this.lblPuntosCasa.Location = new System.Drawing.Point(575, 86);
            this.lblPuntosCasa.Name = "lblPuntosCasa";
            this.lblPuntosCasa.Size = new System.Drawing.Size(38, 31);
            this.lblPuntosCasa.TabIndex = 9;
            this.lblPuntosCasa.Text = "....";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReiniciar.Font = new System.Drawing.Font("Sylfaen", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(154, 260);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(93, 35);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnPlantarse
            // 
            this.btnPlantarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlantarse.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantarse.Location = new System.Drawing.Point(488, 532);
            this.btnPlantarse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlantarse.Name = "btnPlantarse";
            this.btnPlantarse.Size = new System.Drawing.Size(112, 35);
            this.btnPlantarse.TabIndex = 5;
            this.btnPlantarse.Text = "Plantarse";
            this.btnPlantarse.UseVisualStyleBackColor = true;
            this.btnPlantarse.Click += new System.EventHandler(this.btnPlantarse_Click);
            // 
            // btnPedir
            // 
            this.btnPedir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPedir.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Italic);
            this.btnPedir.Location = new System.Drawing.Point(628, 532);
            this.btnPedir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(112, 35);
            this.btnPedir.TabIndex = 6;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // txtApuesta
            // 
            this.txtApuesta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApuesta.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApuesta.Location = new System.Drawing.Point(56, 215);
            this.txtApuesta.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtApuesta.Name = "txtApuesta";
            this.txtApuesta.Size = new System.Drawing.Size(172, 34);
            this.txtApuesta.TabIndex = 12;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaldo.Location = new System.Drawing.Point(70, 532);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 31);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = ".....";
            // 
            // btnAceptarApuesta
            // 
            this.btnAceptarApuesta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptarApuesta.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarApuesta.Location = new System.Drawing.Point(39, 262);
            this.btnAceptarApuesta.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAceptarApuesta.Name = "btnAceptarApuesta";
            this.btnAceptarApuesta.Size = new System.Drawing.Size(88, 35);
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
            this.lbsaldo.Location = new System.Drawing.Point(60, 97);
            this.lbsaldo.Name = "lbsaldo";
            this.lbsaldo.Size = new System.Drawing.Size(44, 31);
            this.lbsaldo.TabIndex = 15;
            this.lbsaldo.Text = ".....";
            // 
            // lblApuestaEnJuego
            // 
            this.lblApuestaEnJuego.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApuestaEnJuego.AutoSize = true;
            this.lblApuestaEnJuego.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApuestaEnJuego.Location = new System.Drawing.Point(60, 143);
            this.lblApuestaEnJuego.Name = "lblApuestaEnJuego";
            this.lblApuestaEnJuego.Size = new System.Drawing.Size(44, 31);
            this.lblApuestaEnJuego.TabIndex = 15;
            this.lblApuestaEnJuego.Text = ".....";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(892, 575);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 42);
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblApuestaEnJuego);
            this.panel1.Controls.Add(this.lbsaldo);
            this.panel1.Controls.Add(this.btnAceptarApuesta);
            this.panel1.Controls.Add(this.txtApuesta);
            this.panel1.Controls.Add(this.btnReiniciar);
            this.panel1.Location = new System.Drawing.Point(759, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 328);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ingresar apuesta:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 51);
            this.label1.TabIndex = 16;
            this.label1.Text = "BlackJack";
            // 
            // VentanaBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 652);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label label4;
    }
}