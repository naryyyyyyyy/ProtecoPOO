namespace ProtecoPOO
{
    partial class VentanaElegirPersonaje
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCaballero = new System.Windows.Forms.Button();
            this.btnPicaro = new System.Windows.Forms.Button();
            this.btnMago = new System.Windows.Forms.Button();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.Controls.Add(this.btnMago);
            this.panelContenedor.Controls.Add(this.btnPicaro);
            this.panelContenedor.Controls.Add(this.btnCaballero);
            this.panelContenedor.Location = new System.Drawing.Point(-4, -3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(807, 456);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnCaballero
            // 
            this.btnCaballero.Location = new System.Drawing.Point(369, 356);
            this.btnCaballero.Name = "btnCaballero";
            this.btnCaballero.Size = new System.Drawing.Size(75, 23);
            this.btnCaballero.TabIndex = 0;
            this.btnCaballero.Text = "Caballero";
            this.btnCaballero.UseVisualStyleBackColor = true;
            this.btnCaballero.Click += new System.EventHandler(this.btnCaballero_Click);
            // 
            // btnPicaro
            // 
            this.btnPicaro.Location = new System.Drawing.Point(571, 356);
            this.btnPicaro.Name = "btnPicaro";
            this.btnPicaro.Size = new System.Drawing.Size(75, 23);
            this.btnPicaro.TabIndex = 0;
            this.btnPicaro.Text = "Picaro";
            this.btnPicaro.UseVisualStyleBackColor = true;
            this.btnPicaro.Click += new System.EventHandler(this.btnPicaro_Click);
            // 
            // btnMago
            // 
            this.btnMago.Location = new System.Drawing.Point(181, 356);
            this.btnMago.Name = "btnMago";
            this.btnMago.Size = new System.Drawing.Size(75, 23);
            this.btnMago.TabIndex = 0;
            this.btnMago.Text = "Mago";
            this.btnMago.UseVisualStyleBackColor = true;
            this.btnMago.Click += new System.EventHandler(this.btnMago_Click);
            // 
            // VentanaElegirPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Name = "VentanaElegirPersonaje";
            this.Text = "VentanaElegirPersonaje";
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnMago;
        private System.Windows.Forms.Button btnPicaro;
        private System.Windows.Forms.Button btnCaballero;
    }
}