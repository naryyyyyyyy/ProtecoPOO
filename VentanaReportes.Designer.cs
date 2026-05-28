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
            this.reporteAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesFiltradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPersonajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especificoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGlobal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteAdminBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReporteGlobal
            // 
            this.dgvReporteGlobal.AutoGenerateColumns = false;
            this.dgvReporteGlobal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.globalToolStripMenuItem,
            this.especificoToolStripMenuItem});
            this.reportesFiltradosToolStripMenuItem.Name = "reportesFiltradosToolStripMenuItem";
            this.reportesFiltradosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesFiltradosToolStripMenuItem.Text = "Reportes";
            // 
            // porUsuarioToolStripMenuItem
            // 
            this.porUsuarioToolStripMenuItem.Name = "porUsuarioToolStripMenuItem";
            this.porUsuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.porUsuarioToolStripMenuItem.Text = "Por usuario";
            this.porUsuarioToolStripMenuItem.Click += new System.EventHandler(this.porUsuarioToolStripMenuItem_Click);
            // 
            // porJuegoToolStripMenuItem
            // 
            this.porJuegoToolStripMenuItem.Name = "porJuegoToolStripMenuItem";
            this.porJuegoToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.porJuegoToolStripMenuItem.Text = "Por juego";
            this.porJuegoToolStripMenuItem.Click += new System.EventHandler(this.porJuegoToolStripMenuItem_Click);
            // 
            // porPersonajeToolStripMenuItem
            // 
            this.porPersonajeToolStripMenuItem.Name = "porPersonajeToolStripMenuItem";
            this.porPersonajeToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.porPersonajeToolStripMenuItem.Text = "Por personaje";
            this.porPersonajeToolStripMenuItem.Click += new System.EventHandler(this.porPersonajeToolStripMenuItem_Click);
            // 
            // globalToolStripMenuItem
            // 
            this.globalToolStripMenuItem.Name = "globalToolStripMenuItem";
            this.globalToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.globalToolStripMenuItem.Text = "Global";
            this.globalToolStripMenuItem.Click += new System.EventHandler(this.globalToolStripMenuItem_Click);
            // 
            // especificoToolStripMenuItem
            // 
            this.especificoToolStripMenuItem.Name = "especificoToolStripMenuItem";
            this.especificoToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.especificoToolStripMenuItem.Text = "Especifico";
            this.especificoToolStripMenuItem.Click += new System.EventHandler(this.especificoToolStripMenuItem_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(515, 63);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(183, 24);
            this.cmbFiltro.TabIndex = 3;
            // 
            // VentanaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReporteGlobal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaReportes";
            this.Text = "VentanaReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGlobal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteAdminBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem especificoToolStripMenuItem;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.ComboBox cmbFiltro;
    }
}