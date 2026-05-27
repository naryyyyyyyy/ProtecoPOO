namespace ProtecoPOO
{
    partial class ReportesUsuario
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
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvRepostesUsusario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepostesUsusario)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(123, 67);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 0;
            // 
            // dgvRepostesUsusario
            // 
            this.dgvRepostesUsusario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepostesUsusario.Location = new System.Drawing.Point(123, 121);
            this.dgvRepostesUsusario.Name = "dgvRepostesUsusario";
            this.dgvRepostesUsusario.Size = new System.Drawing.Size(407, 215);
            this.dgvRepostesUsusario.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "btnSalir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReportesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRepostesUsusario);
            this.Controls.Add(this.cmbFiltro);
            this.Name = "ReportesUsuario";
            this.Text = "ReportesUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepostesUsusario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.DataGridView dgvRepostesUsusario;
        private System.Windows.Forms.Button button1;
    }
}