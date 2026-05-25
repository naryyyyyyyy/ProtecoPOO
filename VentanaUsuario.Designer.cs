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
            this.btnblackjack = new System.Windows.Forms.Button();
            this.btnCarreraCaballos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnblackjack
            // 
            this.btnblackjack.Location = new System.Drawing.Point(336, 126);
            this.btnblackjack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnblackjack.Name = "btnblackjack";
            this.btnblackjack.Size = new System.Drawing.Size(100, 28);
            this.btnblackjack.TabIndex = 0;
            this.btnblackjack.Text = "blackjack";
            this.btnblackjack.UseVisualStyleBackColor = true;
            this.btnblackjack.Click += new System.EventHandler(this.btnblackjack_Click);
            // 
            // btnCarreraCaballos
            // 
            this.btnCarreraCaballos.Location = new System.Drawing.Point(336, 181);
            this.btnCarreraCaballos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarreraCaballos.Name = "btnCarreraCaballos";
            this.btnCarreraCaballos.Size = new System.Drawing.Size(115, 50);
            this.btnCarreraCaballos.TabIndex = 0;
            this.btnCarreraCaballos.Text = "Carrera de caballos";
            this.btnCarreraCaballos.UseVisualStyleBackColor = true;
            this.btnCarreraCaballos.Click += new System.EventHandler(this.btnCarreraCaballos_Click);
            // 
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCarreraCaballos);
            this.Controls.Add(this.btnblackjack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaUsuario";
            this.Text = "VentanaUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnblackjack;
        private System.Windows.Forms.Button btnCarreraCaballos;
    }
}