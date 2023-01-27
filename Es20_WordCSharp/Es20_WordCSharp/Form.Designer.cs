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
            this.lblTesto = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnInsertText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewDocument
            // 
            this.btnNewDocument.Location = new System.Drawing.Point(12, 12);
            this.btnNewDocument.Name = "btnNewDocument";
            this.btnNewDocument.Size = new System.Drawing.Size(145, 23);
            this.btnNewDocument.TabIndex = 0;
            this.btnNewDocument.Text = "Crea Documento Word";
            this.btnNewDocument.UseVisualStyleBackColor = true;
            this.btnNewDocument.Click += new System.EventHandler(this.btnNewDocument_Click);
            // 
            // lblTesto
            // 
            this.lblTesto.AutoSize = true;
            this.lblTesto.Location = new System.Drawing.Point(12, 117);
            this.lblTesto.Name = "lblTesto";
            this.lblTesto.Size = new System.Drawing.Size(34, 13);
            this.lblTesto.TabIndex = 1;
            this.lblTesto.Text = "Testo";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 133);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(145, 63);
            this.txtText.TabIndex = 2;
            // 
            // btnInsertText
            // 
            this.btnInsertText.Location = new System.Drawing.Point(12, 202);
            this.btnInsertText.Name = "btnInsertText";
            this.btnInsertText.Size = new System.Drawing.Size(75, 23);
            this.btnInsertText.TabIndex = 3;
            this.btnInsertText.Text = "Inserisci Testo";
            this.btnInsertText.UseVisualStyleBackColor = true;
            this.btnInsertText.Click += new System.EventHandler(this.btnInsertText_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 234);
            this.Controls.Add(this.btnInsertText);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.btnNewDocument);
            this.Name = "Form";
            this.Text = "Word C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewDocument;
        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnInsertText;
    }
}

