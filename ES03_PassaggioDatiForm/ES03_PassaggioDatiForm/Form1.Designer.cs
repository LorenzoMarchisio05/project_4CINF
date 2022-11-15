namespace ES03_PassaggioDatiForm
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
            this.btnDestCostruttore = new System.Windows.Forms.Button();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.txtRisposta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDestCostruttore
            // 
            this.btnDestCostruttore.Location = new System.Drawing.Point(33, 135);
            this.btnDestCostruttore.Name = "btnDestCostruttore";
            this.btnDestCostruttore.Size = new System.Drawing.Size(163, 23);
            this.btnDestCostruttore.TabIndex = 1;
            this.btnDestCostruttore.Text = "Apri Destinazione Costruttore";
            this.btnDestCostruttore.UseVisualStyleBackColor = true;
            this.btnDestCostruttore.Click += new System.EventHandler(this.btnDestCostruttore_Click);
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Location = new System.Drawing.Point(33, 75);
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(163, 20);
            this.txtMessaggio.TabIndex = 2;
            // 
            // txtRisposta
            // 
            this.txtRisposta.Location = new System.Drawing.Point(229, 75);
            this.txtRisposta.Name = "txtRisposta";
            this.txtRisposta.Size = new System.Drawing.Size(163, 20);
            this.txtRisposta.TabIndex = 3;
            // 
            // frmPartenza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRisposta);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.btnDestCostruttore);
            this.Name = "frmPartenza";
            this.Text = "Partenza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDestCostruttore;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.TextBox txtRisposta;
    }
}

