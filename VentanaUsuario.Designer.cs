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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
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
            this.lblSaldoP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPersonaje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnblackjack
            // 
            this.btnblackjack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnblackjack.BackColor = System.Drawing.Color.SeaShell;
            this.btnblackjack.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold);
            this.btnblackjack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnblackjack.Location = new System.Drawing.Point(556, 110);
            this.btnblackjack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnblackjack.Name = "btnblackjack";
            this.btnblackjack.Size = new System.Drawing.Size(122, 41);
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
            this.btnCarreraCaballos.Location = new System.Drawing.Point(416, 122);
            this.btnCarreraCaballos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarreraCaballos.Name = "btnCarreraCaballos";
            this.btnCarreraCaballos.Size = new System.Drawing.Size(133, 73);
            this.btnCarreraCaballos.TabIndex = 0;
            this.btnCarreraCaballos.Text = "Carrera de caballos";
            this.btnCarreraCaballos.UseVisualStyleBackColor = false;
            this.btnCarreraCaballos.Click += new System.EventHandler(this.btnCarreraCaballos_Click);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(414, 292);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 62;
            this.dgvHistorial.RowTemplate.Height = 28;
            this.dgvHistorial.Size = new System.Drawing.Size(285, 160);
            this.dgvHistorial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mi perfil";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(504, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jugar";
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(50, 122);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(109, 31);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mis partidas:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(50, 418);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(80, 31);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "--------------------------------";
            // 
            // btnIrAbonar
            // 
            this.btnIrAbonar.BackColor = System.Drawing.Color.SeaShell;
            this.btnIrAbonar.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrAbonar.Location = new System.Drawing.Point(269, 422);
            this.btnIrAbonar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIrAbonar.Name = "btnIrAbonar";
            this.btnIrAbonar.Size = new System.Drawing.Size(86, 35);
            this.btnIrAbonar.TabIndex = 5;
            this.btnIrAbonar.Text = "Abonar";
            this.btnIrAbonar.UseVisualStyleBackColor = false;
            this.btnIrAbonar.Click += new System.EventHandler(this.btnIrAbonar_Click);
            // 
            // btnRuleta
            // 
            this.btnRuleta.BackColor = System.Drawing.Color.SeaShell;
            this.btnRuleta.Font = new System.Drawing.Font("Sylfaen", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuleta.Location = new System.Drawing.Point(572, 158);
            this.btnRuleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRuleta.Name = "btnRuleta";
            this.btnRuleta.Size = new System.Drawing.Size(106, 38);
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
            this.lblUsuario.Location = new System.Drawing.Point(187, 122);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(94, 31);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mi personaje:";
            // 
            // pcbPersonaje
            // 
            this.pcbPersonaje.BackColor = System.Drawing.Color.Transparent;
            this.pcbPersonaje.Location = new System.Drawing.Point(110, 222);
            this.pcbPersonaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbPersonaje.Name = "pcbPersonaje";
            this.pcbPersonaje.Size = new System.Drawing.Size(181, 168);
            this.pcbPersonaje.TabIndex = 9;
            this.pcbPersonaje.TabStop = false;
            // 
            // btnCambiarPersonaje
            // 
            this.btnCambiarPersonaje.BackColor = System.Drawing.Color.SeaShell;
            this.btnCambiarPersonaje.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarPersonaje.Location = new System.Drawing.Point(100, 469);
            this.btnCambiarPersonaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiarPersonaje.Name = "btnCambiarPersonaje";
            this.btnCambiarPersonaje.Size = new System.Drawing.Size(181, 32);
            this.btnCambiarPersonaje.TabIndex = 10;
            this.btnCambiarPersonaje.Text = "Cambiar Personaje";
            this.btnCambiarPersonaje.UseVisualStyleBackColor = false;
            this.btnCambiarPersonaje.Click += new System.EventHandler(this.btnCambiarPersonaje_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.SeaShell;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(416, 469);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(146, 32);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblSaldoP
            // 
            this.lblSaldoP.AutoSize = true;
            this.lblSaldoP.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoP.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoP.Location = new System.Drawing.Point(151, 418);
            this.lblSaldoP.Name = "lblSaldoP";
            this.lblSaldoP.Size = new System.Drawing.Size(70, 31);
            this.lblSaldoP.TabIndex = 12;
            this.lblSaldoP.Text = "saldo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(578, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Estadisticas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSaldoP);
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
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.btnCarreraCaballos);
            this.Controls.Add(this.btnblackjack);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaUsuario";
            this.Text = "VentanaUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaUsuario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPersonaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnblackjack;
        private System.Windows.Forms.Button btnCarreraCaballos;
        private System.Windows.Forms.DataGridView dgvHistorial;
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
        private System.Windows.Forms.Label lblSaldoP;
        private System.Windows.Forms.Button button1;
    }
}