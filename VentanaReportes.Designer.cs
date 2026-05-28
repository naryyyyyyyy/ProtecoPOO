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
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dgvReporteGlobal.Location = new System.Drawing.Point(60, 134);
            this.dgvReporteGlobal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReporteGlobal.Name = "dgvReporteGlobal";
            this.dgvReporteGlobal.RowHeadersWidth = 51;
            this.dgvReporteGlobal.RowTemplate.Height = 24;
            this.dgvReporteGlobal.Size = new System.Drawing.Size(774, 311);
            this.dgvReporteGlobal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORTES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesFiltradosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 33);
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
            this.reportesFiltradosToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.reportesFiltradosToolStripMenuItem.Text = "Reportes";
            // 
            // porUsuarioToolStripMenuItem
            // 
            this.porUsuarioToolStripMenuItem.Name = "porUsuarioToolStripMenuItem";
            this.porUsuarioToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.porUsuarioToolStripMenuItem.Text = "Por usuario";
            this.porUsuarioToolStripMenuItem.Click += new System.EventHandler(this.porUsuarioToolStripMenuItem_Click);
            // 
            // porJuegoToolStripMenuItem
            // 
            this.porJuegoToolStripMenuItem.Name = "porJuegoToolStripMenuItem";
            this.porJuegoToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.porJuegoToolStripMenuItem.Text = "Por juego";
            this.porJuegoToolStripMenuItem.Click += new System.EventHandler(this.porJuegoToolStripMenuItem_Click);
            // 
            // porPersonajeToolStripMenuItem
            // 
            this.porPersonajeToolStripMenuItem.Name = "porPersonajeToolStripMenuItem";
            this.porPersonajeToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.porPersonajeToolStripMenuItem.Text = "Por personaje";
            this.porPersonajeToolStripMenuItem.Click += new System.EventHandler(this.porPersonajeToolStripMenuItem_Click);
            // 
            // globalToolStripMenuItem
            // 
            this.globalToolStripMenuItem.Name = "globalToolStripMenuItem";
            this.globalToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.globalToolStripMenuItem.Text = "Global";
            this.globalToolStripMenuItem.Click += new System.EventHandler(this.globalToolStripMenuItem_Click);
            // 
            // especificoToolStripMenuItem
            // 
            this.especificoToolStripMenuItem.Name = "especificoToolStripMenuItem";
            this.especificoToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.especificoToolStripMenuItem.Text = "Especifico";
            this.especificoToolStripMenuItem.Click += new System.EventHandler(this.especificoToolStripMenuItem_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(587, 72);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(136, 28);
            this.cmbFiltro.TabIndex = 4;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReporteGlobal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.ToolStripMenuItem especificoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}