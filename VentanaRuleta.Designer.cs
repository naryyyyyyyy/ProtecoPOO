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
            this.lstFondoRes = new System.Windows.Forms.ListBox();
            this.picRuleta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRuleta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ruleta:";
            // 
            // cmbTipoAp
            // 
            this.cmbTipoAp.FormattingEnabled = true;
            this.cmbTipoAp.Items.AddRange(new object[] {
            "Número",
            "Color"});
            this.cmbTipoAp.Location = new System.Drawing.Point(64, 390);
            this.cmbTipoAp.Name = "cmbTipoAp";
            this.cmbTipoAp.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoAp.TabIndex = 22;
            // 
            // txtNumAp
            // 
            this.txtNumAp.Location = new System.Drawing.Point(215, 362);
            this.txtNumAp.Name = "txtNumAp";
            this.txtNumAp.Size = new System.Drawing.Size(121, 22);
            this.txtNumAp.TabIndex = 21;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(97, 285);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(99, 16);
            this.lblSaldo.TabIndex = 20;
            this.lblSaldo.Text = "Saldo(del user)";
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(351, 371);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(75, 39);
            this.btnApostar.TabIndex = 19;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(608, 204);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(110, 16);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "Resultado (#giro)";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.ForeColor = System.Drawing.Color.Cyan;
            this.lblColor.Location = new System.Drawing.Point(646, 179);
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
            this.cmbTipo.Location = new System.Drawing.Point(215, 390);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipo.TabIndex = 16;
            // 
            // lblApuesta
            // 
            this.lblApuesta.AutoSize = true;
            this.lblApuesta.Location = new System.Drawing.Point(83, 340);
            this.lblApuesta.Name = "lblApuesta";
            this.lblApuesta.Size = new System.Drawing.Size(169, 16);
            this.lblApuesta.TabIndex = 15;
            this.lblApuesta.Text = "Apostar:(apuesta en juego)";
            // 
            // txtApuesta
            // 
            this.txtApuesta.Location = new System.Drawing.Point(74, 362);
            this.txtApuesta.Name = "txtApuesta";
            this.txtApuesta.Size = new System.Drawing.Size(100, 22);
            this.txtApuesta.TabIndex = 14;
            // 
            // btnGirar
            // 
            this.btnGirar.Location = new System.Drawing.Point(472, 364);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(75, 53);
            this.btnGirar.TabIndex = 13;
            this.btnGirar.Text = "Girar";
            this.btnGirar.UseVisualStyleBackColor = true;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // lstFondoRes
            // 
            this.lstFondoRes.FormattingEnabled = true;
            this.lstFondoRes.ItemHeight = 16;
            this.lstFondoRes.Location = new System.Drawing.Point(593, 146);
            this.lstFondoRes.Name = "lstFondoRes";
            this.lstFondoRes.Size = new System.Drawing.Size(144, 84);
            this.lstFondoRes.TabIndex = 23;
            // 
            // picRuleta
            // 
            this.picRuleta.BackColor = System.Drawing.Color.Transparent;
            this.picRuleta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRuleta.BackgroundImage")));
            this.picRuleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRuleta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picRuleta.Location = new System.Drawing.Point(215, 33);
            this.picRuleta.Name = "picRuleta";
            this.picRuleta.Size = new System.Drawing.Size(342, 272);
            this.picRuleta.TabIndex = 25;
            this.picRuleta.TabStop = false;
            // 
            // VentanaRuleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoAp);
            this.Controls.Add(this.txtNumAp);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblApuesta);
            this.Controls.Add(this.txtApuesta);
            this.Controls.Add(this.btnGirar);
            this.Controls.Add(this.lstFondoRes);
            this.Controls.Add(this.picRuleta);
            this.Name = "VentanaRuleta";
            this.Text = "VentanaRuleta";
            ((System.ComponentModel.ISupportInitialize)(this.picRuleta)).EndInit();
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
        private System.Windows.Forms.ListBox lstFondoRes;
        private System.Windows.Forms.PictureBox picRuleta;
    }
}