namespace ProtecoPOO
{
    partial class VentanaReportes
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
            this.components = new System.ComponentModel.Container();
            this.dgvReporteGlobal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesFiltradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPersonajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reapuestasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciaPerdidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporteAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.globalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGlobal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporteAdminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteGlobal
            // 
            this.dgvReporteGlobal.AutoGenerateColumns = false;
            this.dgvReporteGlobal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteGlobal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jugadorDataGridViewTextBoxColumn,
            this.personajeDataGridViewTextBoxColumn,
            this.juegoDataGridViewTextBoxColumn,
            this.saldoInicialDataGridViewTextBoxColumn,
            this.reapuestasDataGridViewTextBoxColumn,
            this.gananciaPerdidaDataGridViewTextBoxColumn});
            this.dgvReporteGlobal.DataSource = this.reporteAdminBindingSource;
            this.dgvReporteGlobal.Location = new System.Drawing.Point(53, 107);
            this.dgvReporteGlobal.Name = "dgvReporteGlobal";
            this.dgvReporteGlobal.RowHeadersWidth = 51;
            this.dgvReporteGlobal.RowTemplate.Height = 24;
            this.dgvReporteGlobal.Size = new System.Drawing.Size(688, 249);
            this.dgvReporteGlobal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORTES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesFiltradosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesFiltradosToolStripMenuItem
            // 
            this.reportesFiltradosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porUsuarioToolStripMenuItem,
            this.porJuegoToolStripMenuItem,
            this.porPersonajeToolStripMenuItem,
            this.globalToolStripMenuItem});
            this.reportesFiltradosToolStripMenuItem.Name = "reportesFiltradosToolStripMenuItem";
            this.reportesFiltradosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesFiltradosToolStripMenuItem.Text = "Reportes";
            // 
            // porUsuarioToolStripMenuItem
            // 
            this.porUsuarioToolStripMenuItem.Name = "porUsuarioToolStripMenuItem";
            this.porUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porUsuarioToolStripMenuItem.Text = "Por usuario";
            this.porUsuarioToolStripMenuItem.Click += new System.EventHandler(this.porUsuarioToolStripMenuItem_Click);
            // 
            // porJuegoToolStripMenuItem
            // 
            this.porJuegoToolStripMenuItem.Name = "porJuegoToolStripMenuItem";
            this.porJuegoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porJuegoToolStripMenuItem.Text = "Por juego";
            // 
            // porPersonajeToolStripMenuItem
            // 
            this.porPersonajeToolStripMenuItem.Name = "porPersonajeToolStripMenuItem";
            this.porPersonajeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porPersonajeToolStripMenuItem.Text = "Por personaje";
            // 
            // jugadorDataGridViewTextBoxColumn
            // 
            this.jugadorDataGridViewTextBoxColumn.DataPropertyName = "Jugador";
            this.jugadorDataGridViewTextBoxColumn.HeaderText = "Jugador";
            this.jugadorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jugadorDataGridViewTextBoxColumn.Name = "jugadorDataGridViewTextBoxColumn";
            this.jugadorDataGridViewTextBoxColumn.Width = 125;
            // 
            // personajeDataGridViewTextBoxColumn
            // 
            this.personajeDataGridViewTextBoxColumn.DataPropertyName = "Personaje";
            this.personajeDataGridViewTextBoxColumn.HeaderText = "Personaje";
            this.personajeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personajeDataGridViewTextBoxColumn.Name = "personajeDataGridViewTextBoxColumn";
            this.personajeDataGridViewTextBoxColumn.Width = 125;
            // 
            // juegoDataGridViewTextBoxColumn
            // 
            this.juegoDataGridViewTextBoxColumn.DataPropertyName = "Juego";
            this.juegoDataGridViewTextBoxColumn.HeaderText = "Juego";
            this.juegoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juegoDataGridViewTextBoxColumn.Name = "juegoDataGridViewTextBoxColumn";
            this.juegoDataGridViewTextBoxColumn.Width = 125;
            // 
            // saldoInicialDataGridViewTextBoxColumn
            // 
            this.saldoInicialDataGridViewTextBoxColumn.DataPropertyName = "SaldoInicial";
            this.saldoInicialDataGridViewTextBoxColumn.HeaderText = "SaldoInicial";
            this.saldoInicialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saldoInicialDataGridViewTextBoxColumn.Name = "saldoInicialDataGridViewTextBoxColumn";
            this.saldoInicialDataGridViewTextBoxColumn.Width = 125;
            // 
            // reapuestasDataGridViewTextBoxColumn
            // 
            this.reapuestasDataGridViewTextBoxColumn.DataPropertyName = "Reapuestas";
            this.reapuestasDataGridViewTextBoxColumn.HeaderText = "Reapuestas";
            this.reapuestasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reapuestasDataGridViewTextBoxColumn.Name = "reapuestasDataGridViewTextBoxColumn";
            this.reapuestasDataGridViewTextBoxColumn.Width = 125;
            // 
            // gananciaPerdidaDataGridViewTextBoxColumn
            // 
            this.gananciaPerdidaDataGridViewTextBoxColumn.DataPropertyName = "GananciaPerdida";
            this.gananciaPerdidaDataGridViewTextBoxColumn.HeaderText = "GananciaPerdida";
            this.gananciaPerdidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gananciaPerdidaDataGridViewTextBoxColumn.Name = "gananciaPerdidaDataGridViewTextBoxColumn";
            this.gananciaPerdidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // reporteAdminBindingSource
            // 
            this.reporteAdminBindingSource.DataSource = typeof(ProtecoPOO.ReporteAdmin);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(522, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // globalToolStripMenuItem
            // 
            this.globalToolStripMenuItem.Name = "globalToolStripMenuItem";
            this.globalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.globalToolStripMenuItem.Text = "Global";
            // 
            // VentanaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReporteGlobal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaReportes";
            this.Text = "VentanaReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGlobal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporteAdminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporteGlobal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesFiltradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPersonajeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn jugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juegoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reapuestasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaPerdidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reporteAdminBindingSource;
        private System.Windows.Forms.ToolStripMenuItem globalToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}