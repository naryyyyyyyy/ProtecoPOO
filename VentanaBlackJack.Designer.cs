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
            this.SuspendLayout();
            // 
            // flowJugador
            // 
            this.flowJugador.Location = new System.Drawing.Point(36, 273);
            this.flowJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowJugador.Name = "flowJugador";
            this.flowJugador.Size = new System.Drawing.Size(843, 137);
            this.flowJugador.TabIndex = 11;
            // 
            // flowCasa
            // 
            this.flowCasa.Location = new System.Drawing.Point(45, 98);
            this.flowCasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowCasa.Name = "flowCasa";
            this.flowCasa.Size = new System.Drawing.Size(833, 151);
            this.flowCasa.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(667, 414);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "...";
            // 
            // lblPuntosJugador
            // 
            this.lblPuntosJugador.AutoSize = true;
            this.lblPuntosJugador.Location = new System.Drawing.Point(428, 414);
            this.lblPuntosJugador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosJugador.Name = "lblPuntosJugador";
            this.lblPuntosJugador.Size = new System.Drawing.Size(16, 16);
            this.lblPuntosJugador.TabIndex = 8;
            this.lblPuntosJugador.Text = "...";
            // 
            // lblPuntosCasa
            // 
            this.lblPuntosCasa.AutoSize = true;
            this.lblPuntosCasa.BackColor = System.Drawing.SystemColors.Window;
            this.lblPuntosCasa.Location = new System.Drawing.Point(251, 22);
            this.lblPuntosCasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosCasa.Name = "lblPuntosCasa";
            this.lblPuntosCasa.Size = new System.Drawing.Size(16, 16);
            this.lblPuntosCasa.TabIndex = 9;
            this.lblPuntosCasa.Text = "...";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(651, 511);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(100, 28);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnPlantarse
            // 
            this.btnPlantarse.Location = new System.Drawing.Point(464, 433);
            this.btnPlantarse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlantarse.Name = "btnPlantarse";
            this.btnPlantarse.Size = new System.Drawing.Size(100, 28);
            this.btnPlantarse.TabIndex = 5;
            this.btnPlantarse.Text = "plantarse";
            this.btnPlantarse.UseVisualStyleBackColor = true;
            this.btnPlantarse.Click += new System.EventHandler(this.btnPlantarse_Click);
            // 
            // btnPedir
            // 
            this.btnPedir.Location = new System.Drawing.Point(327, 433);
            this.btnPedir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(100, 28);
            this.btnPedir.TabIndex = 6;
            this.btnPedir.Text = "pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // txtApuesta
            // 
            this.txtApuesta.Location = new System.Drawing.Point(617, 436);
            this.txtApuesta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApuesta.Name = "txtApuesta";
            this.txtApuesta.Size = new System.Drawing.Size(132, 22);
            this.txtApuesta.TabIndex = 12;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(805, 444);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 16);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "label1";
            // 
            // btnAcetarApuesta
            // 
            this.btnAcetarApuesta.Location = new System.Drawing.Point(809, 479);
            this.btnAcetarApuesta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAcetarApuesta.Name = "btnAcetarApuesta";
            this.btnAcetarApuesta.Size = new System.Drawing.Size(100, 28);
            this.btnAcetarApuesta.TabIndex = 14;
            this.btnAcetarApuesta.Text = "Aceptar Apuesta";
            this.btnAcetarApuesta.UseVisualStyleBackColor = true;
            // 
            // VentanaBlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaBlackJack";
            this.Text = "VentanaBlackJack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaBlackJack_FormClosing);
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
    }
}