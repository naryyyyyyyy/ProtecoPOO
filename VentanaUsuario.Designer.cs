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
            this.SuspendLayout();
            // 
            // btnblackjack
            // 
            this.btnblackjack.Location = new System.Drawing.Point(479, 265);
            this.btnblackjack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnblackjack.Name = "btnblackjack";
            this.btnblackjack.Size = new System.Drawing.Size(112, 35);
            this.btnblackjack.TabIndex = 0;
            this.btnblackjack.Text = "blackjack";
            this.btnblackjack.UseVisualStyleBackColor = true;
            this.btnblackjack.Click += new System.EventHandler(this.btnblackjack_Click);
            // 
            // btnCarreraCaballos
            // 
            this.btnCarreraCaballos.Location = new System.Drawing.Point(479, 332);
            this.btnCarreraCaballos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCarreraCaballos.Name = "btnCarreraCaballos";
            this.btnCarreraCaballos.Size = new System.Drawing.Size(129, 62);
            this.btnCarreraCaballos.TabIndex = 0;
            this.btnCarreraCaballos.Text = "Carrera de caballos";
            this.btnCarreraCaballos.UseVisualStyleBackColor = true;
            this.btnCarreraCaballos.Click += new System.EventHandler(this.btnCarreraCaballos_Click);
            // 
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 543);
            this.Controls.Add(this.btnCarreraCaballos);
            this.Controls.Add(this.btnblackjack);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaUsuario";
            this.Text = "VentanaUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnblackjack;
        private System.Windows.Forms.Button btnCarreraCaballos;
    }
}