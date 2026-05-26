namespace ProtecoPOO
{
    partial class CarreraCaballos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarreraCaballos));
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblCaballo = new System.Windows.Forms.Label();
            this.cmbApuestaPuesto = new System.Windows.Forms.ComboBox();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lstCompetidores = new System.Windows.Forms.ListBox();
            this.btnIniciarCarrera = new System.Windows.Forms.Button();
            this.btnNuevaCarrera = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picCarril6 = new System.Windows.Forms.PictureBox();
            this.picCarril5 = new System.Windows.Forms.PictureBox();
            this.picCarril1 = new System.Windows.Forms.PictureBox();
            this.picCarril2 = new System.Windows.Forms.PictureBox();
            this.picCarril4 = new System.Windows.Forms.PictureBox();
            this.picCarril3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.lblApuestaEnJuego = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtApuesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPuesto.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuesto.Location = new System.Drawing.Point(798, 488);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(87, 31);
            this.lblPuesto.TabIndex = 24;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblCaballo
            // 
            this.lblCaballo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaballo.AutoSize = true;
            this.lblCaballo.BackColor = System.Drawing.Color.Transparent;
            this.lblCaballo.Font = new System.Drawing.Font("Sylfaen", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaballo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCaballo.Location = new System.Drawing.Point(854, 456);
            this.lblCaballo.Name = "lblCaballo";
            this.lblCaballo.Size = new System.Drawing.Size(288, 26);
            this.lblCaballo.TabIndex = 23;
            this.lblCaballo.Text = "Caballo: Ninguno Registrado";
            // 
            // cmbApuestaPuesto
            // 
            this.cmbApuestaPuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbApuestaPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApuestaPuesto.FormattingEnabled = true;
            this.cmbApuestaPuesto.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbApuestaPuesto.Location = new System.Drawing.Point(859, 524);
            this.cmbApuestaPuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbApuestaPuesto.Name = "cmbApuestaPuesto";
            this.cmbApuestaPuesto.Size = new System.Drawing.Size(52, 28);
            this.cmbApuestaPuesto.TabIndex = 22;
            // 
            // btnApostar
            // 
            this.btnApostar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApostar.Font = new System.Drawing.Font("Sylfaen", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApostar.Location = new System.Drawing.Point(1106, 523);
            this.btnApostar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(84, 29);
            this.btnApostar.TabIndex = 21;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lstCompetidores
            // 
            this.lstCompetidores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstCompetidores.Font = new System.Drawing.Font("Sylfaen", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCompetidores.FormattingEnabled = true;
            this.lstCompetidores.ItemHeight = 26;
            this.lstCompetidores.Location = new System.Drawing.Point(858, 284);
            this.lstCompetidores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCompetidores.Name = "lstCompetidores";
            this.lstCompetidores.Size = new System.Drawing.Size(346, 160);
            this.lstCompetidores.TabIndex = 20;
            // 
            // btnIniciarCarrera
            // 
            this.btnIniciarCarrera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarCarrera.BackColor = System.Drawing.Color.SeaShell;
            this.btnIniciarCarrera.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold);
            this.btnIniciarCarrera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIniciarCarrera.Location = new System.Drawing.Point(228, 496);
            this.btnIniciarCarrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIniciarCarrera.Name = "btnIniciarCarrera";
            this.btnIniciarCarrera.Size = new System.Drawing.Size(112, 68);
            this.btnIniciarCarrera.TabIndex = 18;
            this.btnIniciarCarrera.Text = "Iniciar Carrera";
            this.btnIniciarCarrera.UseVisualStyleBackColor = false;
            this.btnIniciarCarrera.Click += new System.EventHandler(this.btnIniciarCarrera_Click);
            // 
            // btnNuevaCarrera
            // 
            this.btnNuevaCarrera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevaCarrera.BackColor = System.Drawing.Color.SeaShell;
            this.btnNuevaCarrera.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCarrera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevaCarrera.Location = new System.Drawing.Point(107, 496);
            this.btnNuevaCarrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevaCarrera.Name = "btnNuevaCarrera";
            this.btnNuevaCarrera.Size = new System.Drawing.Size(91, 68);
            this.btnNuevaCarrera.TabIndex = 17;
            this.btnNuevaCarrera.Text = "Nueva Carrera";
            this.btnNuevaCarrera.UseVisualStyleBackColor = false;
            this.btnNuevaCarrera.Click += new System.EventHandler(this.btnNuevaCarrera_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Gold;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(858, 71);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 165);
            this.listBox1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picCarril6);
            this.panel1.Controls.Add(this.picCarril5);
            this.panel1.Controls.Add(this.picCarril1);
            this.panel1.Controls.Add(this.picCarril2);
            this.panel1.Controls.Add(this.picCarril4);
            this.panel1.Controls.Add(this.picCarril3);
            this.panel1.Location = new System.Drawing.Point(107, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 422);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picCarril6
            // 
            this.picCarril6.BackColor = System.Drawing.Color.Transparent;
            this.picCarril6.Location = new System.Drawing.Point(3, 354);
            this.picCarril6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCarril6.Name = "picCarril6";
            this.picCarril6.Size = new System.Drawing.Size(55, 62);
            this.picCarril6.TabIndex = 5;
            this.picCarril6.TabStop = false;
            // 
            // picCarril5
            // 
            this.picCarril5.BackColor = System.Drawing.Color.Transparent;
            this.picCarril5.Location = new System.Drawing.Point(3, 284);
            this.picCarril5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCarril5.Name = "picCarril5";
            this.picCarril5.Size = new System.Drawing.Size(55, 62);
            this.picCarril5.TabIndex = 6;
            this.picCarril5.TabStop = false;
            // 
            // picCarril1
            // 
            this.picCarril1.BackColor = System.Drawing.Color.Transparent;
            this.picCarril1.Location = new System.Drawing.Point(3, 4);
            this.picCarril1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCarril1.Name = "picCarril1";
            this.picCarril1.Size = new System.Drawing.Size(55, 62);
            this.picCarril1.TabIndex = 4;
            this.picCarril1.TabStop = false;
            // 
            // picCarril2
            // 
            this.picCarril2.BackColor = System.Drawing.Color.Transparent;
            this.picCarril2.Location = new System.Drawing.Point(3, 74);
            this.picCarril2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCarril2.Name = "picCarril2";
            this.picCarril2.Size = new System.Drawing.Size(55, 62);
            this.picCarril2.TabIndex = 3;
            this.picCarril2.TabStop = false;
            // 
            // picCarril4
            // 
            this.picCarril4.BackColor = System.Drawing.Color.Transparent;
            this.picCarril4.Location = new System.Drawing.Point(3, 214);
            this.picCarril4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCarril4.Name = "picCarril4";
            this.picCarril4.Size = new System.Drawing.Size(55, 62);
            this.picCarril4.TabIndex = 2;
            this.picCarril4.TabStop = false;
            // 
            // picCarril3
            // 
            this.picCarril3.BackColor = System.Drawing.Color.Transparent;
            this.picCarril3.Location = new System.Drawing.Point(3, 144);
            this.picCarril3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picCarril3.Name = "picCarril3";
            this.picCarril3.Size = new System.Drawing.Size(55, 62);
            this.picCarril3.TabIndex = 1;
            this.picCarril3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblsaldo
            // 
            this.lblsaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblsaldo.Font = new System.Drawing.Font("Sylfaen", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblsaldo.Location = new System.Drawing.Point(863, 565);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(99, 26);
            this.lblsaldo.TabIndex = 25;
            this.lblsaldo.Text = "Saldo act";
            // 
            // lblApuestaEnJuego
            // 
            this.lblApuestaEnJuego.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApuestaEnJuego.AutoSize = true;
            this.lblApuestaEnJuego.BackColor = System.Drawing.Color.Transparent;
            this.lblApuestaEnJuego.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApuestaEnJuego.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApuestaEnJuego.Location = new System.Drawing.Point(918, 488);
            this.lblApuestaEnJuego.Name = "lblApuestaEnJuego";
            this.lblApuestaEnJuego.Size = new System.Drawing.Size(192, 31);
            this.lblApuestaEnJuego.TabIndex = 26;
            this.lblApuestaEnJuego.Text = "ApuestaEnJuego";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.SeaShell;
            this.btnSalir.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(379, 496);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 68);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtApuesta
            // 
            this.txtApuesta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApuesta.Location = new System.Drawing.Point(924, 524);
            this.txtApuesta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApuesta.Name = "txtApuesta";
            this.txtApuesta.Size = new System.Drawing.Size(176, 26);
            this.txtApuesta.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(853, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Podio:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(852, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Competidores actuales:";
            // 
            // CarreraCaballos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 632);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApuesta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblApuestaEnJuego);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblCaballo);
            this.Controls.Add(this.cmbApuestaPuesto);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.lstCompetidores);
            this.Controls.Add(this.btnIniciarCarrera);
            this.Controls.Add(this.btnNuevaCarrera);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CarreraCaballos";
            this.Text = "CarreraCaballos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCarril6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarril3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblCaballo;
        private System.Windows.Forms.ComboBox cmbApuestaPuesto;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.ListBox lstCompetidores;
        private System.Windows.Forms.Button btnIniciarCarrera;
        private System.Windows.Forms.Button btnNuevaCarrera;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picCarril6;
        private System.Windows.Forms.PictureBox picCarril5;
        private System.Windows.Forms.PictureBox picCarril1;
        private System.Windows.Forms.PictureBox picCarril2;
        private System.Windows.Forms.PictureBox picCarril4;
        private System.Windows.Forms.PictureBox picCarril3;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.Label lblApuestaEnJuego;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtApuesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}