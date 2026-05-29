namespace ProtecoPOO
{
    partial class VentanaAdminReportePersonalizado
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
            this.dgvReportePersonalizado = new System.Windows.Forms.DataGridView();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbJuego = new System.Windows.Forms.ComboBox();
            this.cmbPersonaje = new System.Windows.Forms.ComboBox();
            this.chkAscendente = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePersonalizado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportePersonalizado
            // 
            this.dgvReportePersonalizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePersonalizado.Location = new System.Drawing.Point(71, 66);
            this.dgvReportePersonalizado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReportePersonalizado.Name = "dgvReportePersonalizado";
            this.dgvReportePersonalizado.RowHeadersWidth = 51;
            this.dgvReportePersonalizado.RowTemplate.Height = 24;
            this.dgvReportePersonalizado.Size = new System.Drawing.Size(522, 382);
            this.dgvReportePersonalizado.TabIndex = 0;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(657, 106);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(178, 28);
            this.cmbUsuario.TabIndex = 1;
            // 
            // cmbJuego
            // 
            this.cmbJuego.FormattingEnabled = true;
            this.cmbJuego.Location = new System.Drawing.Point(657, 197);
            this.cmbJuego.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbJuego.Name = "cmbJuego";
            this.cmbJuego.Size = new System.Drawing.Size(178, 28);
            this.cmbJuego.TabIndex = 1;
            // 
            // cmbPersonaje
            // 
            this.cmbPersonaje.FormattingEnabled = true;
            this.cmbPersonaje.Location = new System.Drawing.Point(657, 289);
            this.cmbPersonaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPersonaje.Name = "cmbPersonaje";
            this.cmbPersonaje.Size = new System.Drawing.Size(178, 28);
            this.cmbPersonaje.TabIndex = 1;
            // 
            // chkAscendente
            // 
            this.chkAscendente.AutoSize = true;
            this.chkAscendente.Location = new System.Drawing.Point(687, 346);
            this.chkAscendente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAscendente.Name = "chkAscendente";
            this.chkAscendente.Size = new System.Drawing.Size(121, 24);
            this.chkAscendente.TabIndex = 2;
            this.chkAscendente.Text = "Ascendente";
            this.chkAscendente.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(672, 412);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(136, 36);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Generar reporte";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaAdminReportePersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.chkAscendente);
            this.Controls.Add(this.cmbPersonaje);
            this.Controls.Add(this.cmbJuego);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.dgvReportePersonalizado);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VentanaAdminReportePersonalizado";
            this.Text = "VentanaAdminReportePersonalizado";
            this.Load += new System.EventHandler(this.VentanaAdminReportePersonalizado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePersonalizado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportePersonalizado;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbJuego;
        private System.Windows.Forms.ComboBox cmbPersonaje;
        private System.Windows.Forms.CheckBox chkAscendente;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button button1;
    }
}