namespace ES17_FormLogin
{
    partial class frmLogin
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
            this.ucLogin1 = new ES17_FormLogin.UCLogin();
            this.SuspendLayout();
            // 
            // ucLogin1
            // 
            this.ucLogin1.Location = new System.Drawing.Point(12, 12);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(211, 117);
            this.ucLogin1.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucLogin1);
            this.Name = "frmLogin";
            this.Text = "Uso my login";
            this.ResumeLayout(false);

        }

        #endregion

        private UCLogin ucLogin1;
    }
}

