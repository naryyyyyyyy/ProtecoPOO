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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePersonalizado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportePersonalizado
            // 
            this.dgvReportePersonalizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePersonalizado.Location = new System.Drawing.Point(66, 78);
            this.dgvReportePersonalizado.Name = "dgvReportePersonalizado";
            this.dgvReportePersonalizado.RowHeadersWidth = 51;
            this.dgvReportePersonalizado.RowTemplate.Height = 24;
            this.dgvReportePersonalizado.Size = new System.Drawing.Size(464, 306);
            this.dgvReportePersonalizado.TabIndex = 0;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(587, 110);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(159, 24);
            this.cmbUsuario.TabIndex = 1;
            // 
            // cmbJuego
            // 
            this.cmbJuego.FormattingEnabled = true;
            this.cmbJuego.Location = new System.Drawing.Point(587, 183);
            this.cmbJuego.Name = "cmbJuego";
            this.cmbJuego.Size = new System.Drawing.Size(159, 24);
            this.cmbJuego.TabIndex = 1;
            // 
            // cmbPersonaje
            // 
            this.cmbPersonaje.FormattingEnabled = true;
            this.cmbPersonaje.Location = new System.Drawing.Point(587, 257);
            this.cmbPersonaje.Name = "cmbPersonaje";
            this.cmbPersonaje.Size = new System.Drawing.Size(159, 24);
            this.cmbPersonaje.TabIndex = 1;
            // 
            // chkAscendente
            // 
            this.chkAscendente.AutoSize = true;
            this.chkAscendente.Location = new System.Drawing.Point(613, 302);
            this.chkAscendente.Name = "chkAscendente";
            this.chkAscendente.Size = new System.Drawing.Size(101, 20);
            this.chkAscendente.TabIndex = 2;
            this.chkAscendente.Text = "Ascendente";
            this.chkAscendente.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(599, 355);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(121, 29);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Generar reporte";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // VentanaAdminReportePersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.chkAscendente);
            this.Controls.Add(this.cmbPersonaje);
            this.Controls.Add(this.cmbJuego);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.dgvReportePersonalizado);
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
    }
}