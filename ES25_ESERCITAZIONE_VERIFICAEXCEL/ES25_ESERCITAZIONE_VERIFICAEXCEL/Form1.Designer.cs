namespace ES25_ESERCITAZIONE_VERIFICAEXCEL
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
            this.btnCreateModule = new System.Windows.Forms.Button();
            this.btnCreateReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateModule
            // 
            this.btnCreateModule.Location = new System.Drawing.Point(12, 12);
            this.btnCreateModule.Name = "btnCreateModule";
            this.btnCreateModule.Size = new System.Drawing.Size(152, 23);
            this.btnCreateModule.TabIndex = 0;
            this.btnCreateModule.Text = "Crea Modulo";
            this.btnCreateModule.UseVisualStyleBackColor = true;
            this.btnCreateModule.Click += new System.EventHandler(this.btnCreateModule_Click);
            // 
            // btnCreateReview
            // 
            this.btnCreateReview.Location = new System.Drawing.Point(12, 50);
            this.btnCreateReview.Name = "btnCreateReview";
            this.btnCreateReview.Size = new System.Drawing.Size(152, 23);
            this.btnCreateReview.TabIndex = 1;
            this.btnCreateReview.Text = "Leggi dati e crea Excel";
            this.btnCreateReview.UseVisualStyleBackColor = true;
            this.btnCreateReview.Click += new System.EventHandler(this.btnCreateReview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 83);
            this.Controls.Add(this.btnCreateReview);
            this.Controls.Add(this.btnCreateModule);
            this.Name = "Form1";
            this.Text = "Esercitazione verifica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateModule;
        private System.Windows.Forms.Button btnCreateReview;
    }
}

