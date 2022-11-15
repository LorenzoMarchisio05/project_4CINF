namespace Es02_MultiForm
{
    partial class frmPartenza
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
            this.btnApriFormFiglia = new System.Windows.Forms.Button();
            this.chkModale = new System.Windows.Forms.CheckBox();
            this.btnApriFormMDI = new System.Windows.Forms.Button();
            this.chkMDI = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnApriFormFiglia
            // 
            this.btnApriFormFiglia.Location = new System.Drawing.Point(71, 97);
            this.btnApriFormFiglia.Name = "btnApriFormFiglia";
            this.btnApriFormFiglia.Size = new System.Drawing.Size(92, 23);
            this.btnApriFormFiglia.TabIndex = 1;
            this.btnApriFormFiglia.Text = "Apri Form Figlia";
            this.btnApriFormFiglia.UseVisualStyleBackColor = true;
            this.btnApriFormFiglia.Click += new System.EventHandler(this.btnApriFormFiglia_Click);
            // 
            // chkModale
            // 
            this.chkModale.AutoSize = true;
            this.chkModale.Location = new System.Drawing.Point(200, 101);
            this.chkModale.Name = "chkModale";
            this.chkModale.Size = new System.Drawing.Size(61, 17);
            this.chkModale.TabIndex = 2;
            this.chkModale.Text = "Modale";
            this.chkModale.UseVisualStyleBackColor = true;
            // 
            // btnApriFormMDI
            // 
            this.btnApriFormMDI.Location = new System.Drawing.Point(71, 152);
            this.btnApriFormMDI.Name = "btnApriFormMDI";
            this.btnApriFormMDI.Size = new System.Drawing.Size(92, 23);
            this.btnApriFormMDI.TabIndex = 3;
            this.btnApriFormMDI.Text = "Apri Form MDI";
            this.btnApriFormMDI.UseVisualStyleBackColor = true;
            this.btnApriFormMDI.Click += new System.EventHandler(this.btnApriFormMDI_Click);
            // 
            // chkMDI
            // 
            this.chkMDI.AutoSize = true;
            this.chkMDI.Location = new System.Drawing.Point(200, 156);
            this.chkMDI.Name = "chkMDI";
            this.chkMDI.Size = new System.Drawing.Size(46, 17);
            this.chkMDI.TabIndex = 4;
            this.chkMDI.Text = "MDI";
            this.chkMDI.UseVisualStyleBackColor = true;
            this.chkMDI.CheckedChanged += new System.EventHandler(this.chkMDI_CheckedChanged);
            // 
            // frmPartenza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkMDI);
            this.Controls.Add(this.btnApriFormMDI);
            this.Controls.Add(this.chkModale);
            this.Controls.Add(this.btnApriFormFiglia);
            this.Name = "frmPartenza";
            this.Text = "Form Partenza";
            this.Load += new System.EventHandler(this.frmPartenza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApriFormFiglia;
        private System.Windows.Forms.CheckBox chkModale;
        private System.Windows.Forms.Button btnApriFormMDI;
        private System.Windows.Forms.CheckBox chkMDI;
    }
}

