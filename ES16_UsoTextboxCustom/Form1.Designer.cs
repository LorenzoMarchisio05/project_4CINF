namespace ES16_UsoTextboxCustom
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucTextBox1 = new Es16_TextBoxPersonalizzata.UCTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chkSoloNumeri = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.Location = new System.Drawing.Point(98, 92);
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Numero = true;
            this.ucTextBox1.Size = new System.Drawing.Size(151, 20);
            this.ucTextBox1.TabIndex = 0;
            this.ucTextBox1.Testo = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pulisci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Minuscolo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Maiuscolo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkSoloNumeri
            // 
            this.chkSoloNumeri.AutoSize = true;
            this.chkSoloNumeri.Location = new System.Drawing.Point(255, 95);
            this.chkSoloNumeri.Name = "chkSoloNumeri";
            this.chkSoloNumeri.Size = new System.Drawing.Size(81, 17);
            this.chkSoloNumeri.TabIndex = 4;
            this.chkSoloNumeri.Text = "Solo numeri";
            this.chkSoloNumeri.UseVisualStyleBackColor = true;
            this.chkSoloNumeri.CheckedChanged += new System.EventHandler(this.chkSoloNumeri_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSoloNumeri);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucTextBox1);
            this.Name = "FrmMain";
            this.Text = "Uso textbox";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Es16_TextBoxPersonalizzata.UCTextBox ucTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkSoloNumeri;
    }
}

