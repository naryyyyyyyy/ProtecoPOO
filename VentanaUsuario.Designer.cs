namespace ProtecoPOO
{
    partial class VentanaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaUsuario));
            this.btnblackjack = new System.Windows.Forms.Button();
            this.btnCarreraCaballos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIrAbonar = new System.Windows.Forms.Button();
            this.btnRuleta = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbPersonaje = new System.Windows.Forms.PictureBox();
            this.btnCambiarPersonaje = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPersonaje)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnblackjack
            // 
            this.btnblackjack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnblackjack.BackColor = System.Drawing.Color.SeaShell;
            this.btnblackjack.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold);
            this.btnblackjack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnblackjack.Location = new System.Drawing.Point(371, 72);
            this.btnblackjack.Name = "btnblackjack";
            this.btnblackjack.Size = new System.Drawing.Size(81, 27);
            this.btnblackjack.TabIndex = 0;
            this.btnblackjack.Text = "blackjack";
            this.btnblackjack.UseVisualStyleBackColor = false;
            this.btnblackjack.Click += new System.EventHandler(this.btnblackjack_Click);
            // 
            // btnCarreraCaballos
            // 
            this.btnCarreraCaballos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarreraCaballos.BackColor = System.Drawing.Color.SeaShell;
            this.btnCarreraCaballos.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold);
            this.btnCarreraCaballos.Location = new System.Drawing.Point(277, 65);
            this.btnCarreraCaballos.Name = "btnCarreraCaballos";
            this.btnCarreraCaballos.Size = new System.Drawing.Size(88, 34);
            this.btnCarreraCaballos.TabIndex = 0;
            this.btnCarreraCaballos.Text = "Carrera de caballos";
            this.btnCarreraCaballos.UseVisualStyleBackColor = false;
            this.btnCarreraCaballos.Click += new System.EventHandler(this.btnCarreraCaballos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(190, 104);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mi perfil";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(336, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jugar";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(33, 79);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(75, 22);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mis partidas:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(33, 271);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(56, 22);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "--------------------------------";
            // 
            // btnIrAbonar
            // 
            this.btnIrAbonar.BackColor = System.Drawing.Color.SeaShell;
            this.btnIrAbonar.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrAbonar.Location = new System.Drawing.Point(179, 274);
            this.btnIrAbonar.Name = "btnIrAbonar";
            this.btnIrAbonar.Size = new System.Drawing.Size(57, 23);
            this.btnIrAbonar.TabIndex = 5;
            this.btnIrAbonar.Text = "Abonar";
            this.btnIrAbonar.UseVisualStyleBackColor = false;
            this.btnIrAbonar.Click += new System.EventHandler(this.btnIrAbonar_Click);
            // 
            // btnRuleta
            // 
            this.btnRuleta.BackColor = System.Drawing.Color.SeaShell;
            this.btnRuleta.Font = new System.Drawing.Font("Sylfaen", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuleta.Location = new System.Drawing.Point(329, 109);
            this.btnRuleta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRuleta.Name = "btnRuleta";
            this.btnRuleta.Size = new System.Drawing.Size(71, 25);
            this.btnRuleta.TabIndex = 6;
            this.btnRuleta.Text = "Ruleta";
            this.btnRuleta.UseVisualStyleBackColor = false;
            this.btnRuleta.Click += new System.EventHandler(this.btnRuleta_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(95, 109);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 22);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "usuario";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mi personaje:";
            // 
            // pcbPersonaje
            // 
            this.pcbPersonaje.BackColor = System.Drawing.Color.Transparent;
            this.pcbPersonaje.Location = new System.Drawing.Point(67, 183);
            this.pcbPersonaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbPersonaje.Name = "pcbPersonaje";
            this.pcbPersonaje.Size = new System.Drawing.Size(121, 86);
            this.pcbPersonaje.TabIndex = 9;
            this.pcbPersonaje.TabStop = false;
            // 
            // btnCambiarPersonaje
            // 
            this.btnCambiarPersonaje.BackColor = System.Drawing.Color.SeaShell;
            this.btnCambiarPersonaje.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarPersonaje.Location = new System.Drawing.Point(37, 305);
            this.btnCambiarPersonaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCambiarPersonaje.Name = "btnCambiarPersonaje";
            this.btnCambiarPersonaje.Size = new System.Drawing.Size(121, 21);
            this.btnCambiarPersonaje.TabIndex = 10;
            this.btnCambiarPersonaje.Text = "Cambiar Personaje";
            this.btnCambiarPersonaje.UseVisualStyleBackColor = false;
            this.btnCambiarPersonaje.Click += new System.EventHandler(this.btnCambiarPersonaje_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.SeaShell;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(301, 305);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(120, 21);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 353);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnCambiarPersonaje);
            this.Controls.Add(this.pcbPersonaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnRuleta);
            this.Controls.Add(this.btnIrAbonar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCarreraCaballos);
            this.Controls.Add(this.btnblackjack);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaUsuario";
            this.Text = "VentanaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPersonaje)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnblackjack;
        private System.Windows.Forms.Button btnCarreraCaballos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIrAbonar;
        private System.Windows.Forms.Button btnRuleta;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbPersonaje;
        private System.Windows.Forms.Button btnCambiarPersonaje;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}