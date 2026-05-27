namespace ProtecoPOO.Ruleta
{
    partial class VentanaRuleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaRuleta));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoAp = new System.Windows.Forms.ComboBox();
            this.txtNumAp = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblApuesta = new System.Windows.Forms.Label();
            this.txtApuesta = new System.Windows.Forms.TextBox();
            this.btnGirar = new System.Windows.Forms.Button();
            this.picRuleta = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picRuleta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ruleta:";
            // 
            // cmbTipoAp
            // 
            this.cmbTipoAp.FormattingEnabled = true;
            this.cmbTipoAp.Items.AddRange(new object[] {
            "Número",
            "Color"});
            this.cmbTipoAp.Location = new System.Drawing.Point(32, 430);
            this.cmbTipoAp.Name = "cmbTipoAp";
            this.cmbTipoAp.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoAp.TabIndex = 22;
            // 
            // txtNumAp
            // 
            this.txtNumAp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumAp.Location = new System.Drawing.Point(188, 402);
            this.txtNumAp.Name = "txtNumAp";
            this.txtNumAp.Size = new System.Drawing.Size(121, 22);
            this.txtNumAp.TabIndex = 21;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(15, 348);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(138, 20);
            this.lblSaldo.TabIndex = 20;
            this.lblSaldo.Text = "Saldo(del user)";
            // 
            // btnApostar
            // 
            this.btnApostar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApostar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostar.Location = new System.Drawing.Point(392, 399);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(96, 55);
            this.btnApostar.TabIndex = 19;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(70, 132);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(112, 18);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "Resultado (#giro)";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.ForeColor = System.Drawing.Color.Cyan;
            this.lblColor.Location = new System.Drawing.Point(104, 97);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(39, 16);
            this.lblColor.TabIndex = 17;
            this.lblColor.Text = "Color";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Verde",
            "Rojo",
            "Negro"});
            this.cmbTipo.Location = new System.Drawing.Point(188, 430);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipo.TabIndex = 16;
            // 
            // lblApuesta
            // 
            this.lblApuesta.AutoSize = true;
            this.lblApuesta.BackColor = System.Drawing.Color.Transparent;
            this.lblApuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApuesta.Location = new System.Drawing.Point(12, 380);
            this.lblApuesta.Name = "lblApuesta";
            this.lblApuesta.Size = new System.Drawing.Size(237, 20);
            this.lblApuesta.TabIndex = 15;
            this.lblApuesta.Text = "Apostar:(apuesta en juego)";
            // 
            // txtApuesta
            // 
            this.txtApuesta.Location = new System.Drawing.Point(32, 403);
            this.txtApuesta.Name = "txtApuesta";
            this.txtApuesta.Size = new System.Drawing.Size(121, 22);
            this.txtApuesta.TabIndex = 14;
            // 
            // btnGirar
            // 
            this.btnGirar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGirar.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirar.Location = new System.Drawing.Point(552, 159);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(75, 56);
            this.btnGirar.TabIndex = 13;
            this.btnGirar.Text = "Girar";
            this.btnGirar.UseVisualStyleBackColor = true;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // picRuleta
            // 
            this.picRuleta.BackColor = System.Drawing.Color.Transparent;
            this.picRuleta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRuleta.BackgroundImage")));
            this.picRuleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRuleta.Location = new System.Drawing.Point(148, 27);
            this.picRuleta.Name = "picRuleta";
            this.picRuleta.Size = new System.Drawing.Size(373, 329);
            this.picRuleta.TabIndex = 25;
            this.picRuleta.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Location = new System.Drawing.Point(595, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 219);
            this.panel1.TabIndex = 26;
            // 
            // VentanaRuleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(882, 532);
            this.Controls.Add(this.btnGirar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTipoAp);
            this.Controls.Add(this.txtNumAp);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblApuesta);
            this.Controls.Add(this.txtApuesta);
            this.Controls.Add(this.picRuleta);
            this.DoubleBuffered = true;
            this.Name = "VentanaRuleta";
            this.Text = "VentanaRuleta";
            ((System.ComponentModel.ISupportInitialize)(this.picRuleta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoAp;
        private System.Windows.Forms.TextBox txtNumAp;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblApuesta;
        private System.Windows.Forms.TextBox txtApuesta;
        private System.Windows.Forms.Button btnGirar;
        private System.Windows.Forms.PictureBox picRuleta;
        private System.Windows.Forms.Panel panel1;
    }
}