namespace Es20_WordCSharp
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
            this.btnNewDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewDocument
            // 
            this.btnNewDocument.Location = new System.Drawing.Point(12, 12);
            this.btnNewDocument.Name = "btnNewDocument";
            this.btnNewDocument.Size = new System.Drawing.Size(130, 23);
            this.btnNewDocument.TabIndex = 0;
            this.btnNewDocument.Text = "Crea Documento Word";
            this.btnNewDocument.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewDocument);
            this.Name = "Form";
            this.Text = "Word C#";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewDocument;
    }
}

