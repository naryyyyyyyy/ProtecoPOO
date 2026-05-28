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
            this.cmbFiltro.Items.AddRange(new object[] {
            "Por saldo",
            "Por partidas"});
            this.cmbFiltro.Location = new System.Drawing.Point(164, 82);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(160, 24);
            this.cmbFiltro.TabIndex = 0;
            // 
            // dgvRepostesUsusario
            // 
            this.dgvRepostesUsusario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepostesUsusario.Location = new System.Drawing.Point(164, 149);
            this.dgvRepostesUsusario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRepostesUsusario.Name = "dgvRepostesUsusario";
            this.dgvRepostesUsusario.RowHeadersWidth = 51;
            this.dgvRepostesUsusario.Size = new System.Drawing.Size(543, 265);
            this.dgvRepostesUsusario.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRepostesUsusario);
            this.Controls.Add(this.cmbFiltro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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