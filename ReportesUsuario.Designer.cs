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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesUsuario));
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvRepostesUsusario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMasJugado = new System.Windows.Forms.Label();
            this.lblMasRico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepostesUsusario)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFiltro.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Por saldo",
            "Por partidas"});
            this.cmbFiltro.Location = new System.Drawing.Point(505, 94);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(290, 44);
            this.cmbFiltro.TabIndex = 0;
            // 
            // dgvRepostesUsusario
            // 
            this.dgvRepostesUsusario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvRepostesUsusario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepostesUsusario.Location = new System.Drawing.Point(160, 148);
            this.dgvRepostesUsusario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRepostesUsusario.Name = "dgvRepostesUsusario";
            this.dgvRepostesUsusario.RowHeadersWidth = 51;
            this.dgvRepostesUsusario.Size = new System.Drawing.Size(635, 331);
            this.dgvRepostesUsusario.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(845, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Sylfaen", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1005, 568);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mis Reportes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(61, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Personaje más jugado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personaje más rico:";
            // 
            // lblMasJugado
            // 
            this.lblMasJugado.AutoSize = true;
            this.lblMasJugado.BackColor = System.Drawing.Color.Transparent;
            this.lblMasJugado.Font = new System.Drawing.Font("Sylfaen", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasJugado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMasJugado.Location = new System.Drawing.Point(359, 507);
            this.lblMasJugado.Name = "lblMasJugado";
            this.lblMasJugado.Size = new System.Drawing.Size(137, 36);
            this.lblMasJugado.TabIndex = 6;
            this.lblMasJugado.Text = "Personaje";
            // 
            // lblMasRico
            // 
            this.lblMasRico.AutoSize = true;
            this.lblMasRico.BackColor = System.Drawing.Color.Transparent;
            this.lblMasRico.Font = new System.Drawing.Font("Sylfaen", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasRico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMasRico.Location = new System.Drawing.Point(325, 556);
            this.lblMasRico.Name = "lblMasRico";
            this.lblMasRico.Size = new System.Drawing.Size(137, 36);
            this.lblMasRico.TabIndex = 7;
            this.lblMasRico.Text = "Personaje";
            // 
            // ReportesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblMasRico);
            this.Controls.Add(this.lblMasJugado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRepostesUsusario);
            this.Controls.Add(this.cmbFiltro);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportesUsuario";
            this.Text = "ReportesUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepostesUsusario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.DataGridView dgvRepostesUsusario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMasJugado;
        private System.Windows.Forms.Label lblMasRico;
    }
}