namespace ProtecoPOO
{
    partial class VentanaAdmin
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
            this.dgvReportesAdmin = new System.Windows.Forms.DataGridView();
            this.cmbReportesAdmin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportesAdmin
            // 
            this.dgvReportesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportesAdmin.Location = new System.Drawing.Point(323, 46);
            this.dgvReportesAdmin.Name = "dgvReportesAdmin";
            this.dgvReportesAdmin.Size = new System.Drawing.Size(240, 327);
            this.dgvReportesAdmin.TabIndex = 0;
            // 
            // cmbReportesAdmin
            // 
            this.cmbReportesAdmin.FormattingEnabled = true;
            this.cmbReportesAdmin.Location = new System.Drawing.Point(143, 111);
            this.cmbReportesAdmin.Name = "cmbReportesAdmin";
            this.cmbReportesAdmin.Size = new System.Drawing.Size(121, 21);
            this.cmbReportesAdmin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elija el reportes de interes";
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbReportesAdmin);
            this.Controls.Add(this.dgvReportesAdmin);
            this.Name = "VentanaAdmin";
            this.Text = "VentanaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportesAdmin;
        private System.Windows.Forms.ComboBox cmbReportesAdmin;
        private System.Windows.Forms.Label label1;
    }
}