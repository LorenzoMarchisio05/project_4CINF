namespace ES22_GestioneModuliWord
{
    partial class Form
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
            this.BtnCreaModulo = new System.Windows.Forms.Button();
            this.btnLeggiDatiModulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreaModulo
            // 
            this.BtnCreaModulo.Location = new System.Drawing.Point(52, 53);
            this.BtnCreaModulo.Name = "BtnCreaModulo";
            this.BtnCreaModulo.Size = new System.Drawing.Size(109, 28);
            this.BtnCreaModulo.TabIndex = 0;
            this.BtnCreaModulo.Text = "Crea Modulo";
            this.BtnCreaModulo.UseVisualStyleBackColor = true;
            this.BtnCreaModulo.Click += new System.EventHandler(this.BtnCreaModulo_Click);
            // 
            // btnLeggiDatiModulo
            // 
            this.btnLeggiDatiModulo.Location = new System.Drawing.Point(186, 53);
            this.btnLeggiDatiModulo.Name = "btnLeggiDatiModulo";
            this.btnLeggiDatiModulo.Size = new System.Drawing.Size(109, 28);
            this.btnLeggiDatiModulo.TabIndex = 1;
            this.btnLeggiDatiModulo.Text = "Leggi Dati Modulo";
            this.btnLeggiDatiModulo.UseVisualStyleBackColor = true;
            this.btnLeggiDatiModulo.Click += new System.EventHandler(this.btnLeggiDatiModulo_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeggiDatiModulo);
            this.Controls.Add(this.BtnCreaModulo);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreaModulo;
        private System.Windows.Forms.Button btnLeggiDatiModulo;
    }
}

