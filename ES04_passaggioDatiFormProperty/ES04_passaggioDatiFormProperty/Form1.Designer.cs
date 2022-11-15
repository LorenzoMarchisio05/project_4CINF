namespace ES04_passaggioDatiFormProperty
{
    partial class Form1
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
            this.lblRisposta = new System.Windows.Forms.Label();
            this.txtTestoLabel = new System.Windows.Forms.TextBox();
            this.btnApriForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRisposta
            // 
            this.lblRisposta.AutoSize = true;
            this.lblRisposta.Location = new System.Drawing.Point(304, 108);
            this.lblRisposta.Name = "lblRisposta";
            this.lblRisposta.Size = new System.Drawing.Size(35, 13);
            this.lblRisposta.TabIndex = 5;
            this.lblRisposta.Text = "label1";
            // 
            // txtTestoLabel
            // 
            this.txtTestoLabel.Location = new System.Drawing.Point(172, 105);
            this.txtTestoLabel.Name = "txtTestoLabel";
            this.txtTestoLabel.Size = new System.Drawing.Size(100, 20);
            this.txtTestoLabel.TabIndex = 4;
            // 
            // btnApriForm
            // 
            this.btnApriForm.Location = new System.Drawing.Point(52, 102);
            this.btnApriForm.Name = "btnApriForm";
            this.btnApriForm.Size = new System.Drawing.Size(75, 23);
            this.btnApriForm.TabIndex = 3;
            this.btnApriForm.Text = "apri";
            this.btnApriForm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 419);
            this.Controls.Add(this.lblRisposta);
            this.Controls.Add(this.txtTestoLabel);
            this.Controls.Add(this.btnApriForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRisposta;
        private System.Windows.Forms.TextBox txtTestoLabel;
        private System.Windows.Forms.Button btnApriForm;
    }
}

