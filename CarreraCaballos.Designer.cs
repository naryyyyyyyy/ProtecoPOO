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
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblCaballo = new System.Windows.Forms.Label();
            this.cmbApuestaPuesto = new System.Windows.Forms.ComboBox();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lstCompetidores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(773, 387);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(49, 16);
            this.lblPuesto.TabIndex = 24;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblCaballo
            // 
            this.lblCaballo.AutoSize = true;
            this.lblCaballo.Location = new System.Drawing.Point(773, 370);
            this.lblCaballo.Name = "lblCaballo";
            this.lblCaballo.Size = new System.Drawing.Size(180, 16);
            this.lblCaballo.TabIndex = 23;
            this.lblCaballo.Text = "Caballo: Ninguno Registrado";
            // 
            // cmbApuestaPuesto
            // 
            this.cmbApuestaPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApuestaPuesto.FormattingEnabled = true;
            this.cmbApuestaPuesto.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbApuestaPuesto.Location = new System.Drawing.Point(776, 405);
            this.cmbApuestaPuesto.Name = "cmbApuestaPuesto";
            this.cmbApuestaPuesto.Size = new System.Drawing.Size(37, 24);
            this.cmbApuestaPuesto.TabIndex = 22;
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(828, 405);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(75, 23);
            this.btnApostar.TabIndex = 21;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lstCompetidores
            // 
            this.lstCompetidores.FormattingEnabled = true;
            this.lstCompetidores.ItemHeight = 16;
            this.lstCompetidores.Location = new System.Drawing.Point(776, 219);
            this.lstCompetidores.Name = "lstCompetidores";
            this.lstCompetidores.Size = new System.Drawing.Size(221, 148);
            this.lstCompetidores.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ver competidores en una carrera";
            // 
            // btnIniciarCarrera
            // 
            this.btnIniciarCarrera.Location = new System.Drawing.Point(367, 406);
            this.btnIniciarCarrera.Name = "btnIniciarCarrera";
            this.btnIniciarCarrera.Size = new System.Drawing.Size(79, 54);
            this.btnIniciarCarrera.TabIndex = 18;
            this.btnIniciarCarrera.Text = "Iniciar Carrera";
            this.btnIniciarCarrera.UseVisualStyleBackColor = true;
            this.btnIniciarCarrera.Click += new System.EventHandler(this.btnIniciarCarrera_Click);
            // 
            // btnNuevaCarrera
            // 
            this.btnNuevaCarrera.Location = new System.Drawing.Point(126, 406);
            this.btnNuevaCarrera.Name = "btnNuevaCarrera";
            this.btnNuevaCarrera.Size = new System.Drawing.Size(81, 54);
            this.btnNuevaCarrera.TabIndex = 17;
            this.btnNuevaCarrera.Text = "Nueva Carrera";
            this.btnNuevaCarrera.UseVisualStyleBackColor = true;
            this.btnNuevaCarrera.Click += new System.EventHandler(this.btnNuevaCarrera_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBox1.ForeColor = System.Drawing.Color.Gold;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(776, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 148);
            this.listBox1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.picCarril6);
            this.panel1.Controls.Add(this.picCarril5);
            this.panel1.Controls.Add(this.picCarril1);
            this.panel1.Controls.Add(this.picCarril2);
            this.panel1.Controls.Add(this.picCarril4);
            this.panel1.Controls.Add(this.picCarril3);
            this.panel1.Location = new System.Drawing.Point(126, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 338);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picCarril6
            // 
            this.picCarril6.Location = new System.Drawing.Point(3, 283);
            this.picCarril6.Name = "picCarril6";
            this.picCarril6.Size = new System.Drawing.Size(49, 50);
            this.picCarril6.TabIndex = 5;
            this.picCarril6.TabStop = false;
            // 
            // picCarril5
            // 
            this.picCarril5.Location = new System.Drawing.Point(3, 227);
            this.picCarril5.Name = "picCarril5";
            this.picCarril5.Size = new System.Drawing.Size(49, 50);
            this.picCarril5.TabIndex = 6;
            this.picCarril5.TabStop = false;
            // 
            // picCarril1
            // 
            this.picCarril1.Location = new System.Drawing.Point(3, 3);
            this.picCarril1.Name = "picCarril1";
            this.picCarril1.Size = new System.Drawing.Size(49, 50);
            this.picCarril1.TabIndex = 4;
            this.picCarril1.TabStop = false;
            // 
            // picCarril2
            // 
            this.picCarril2.Location = new System.Drawing.Point(3, 59);
            this.picCarril2.Name = "picCarril2";
            this.picCarril2.Size = new System.Drawing.Size(49, 50);
            this.picCarril2.TabIndex = 3;
            this.picCarril2.TabStop = false;
            // 
            // picCarril4
            // 
            this.picCarril4.Location = new System.Drawing.Point(3, 171);
            this.picCarril4.Name = "picCarril4";
            this.picCarril4.Size = new System.Drawing.Size(49, 50);
            this.picCarril4.TabIndex = 2;
            this.picCarril4.TabStop = false;
            // 
            // picCarril3
            // 
            this.picCarril3.Location = new System.Drawing.Point(3, 115);
            this.picCarril3.Name = "picCarril3";
            this.picCarril3.Size = new System.Drawing.Size(49, 50);
            this.picCarril3.TabIndex = 1;
            this.picCarril3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // CarreraCaballos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 506);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblCaballo);
            this.Controls.Add(this.cmbApuestaPuesto);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.lstCompetidores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciarCarrera);
            this.Controls.Add(this.btnNuevaCarrera);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Label label1;
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
    }
}