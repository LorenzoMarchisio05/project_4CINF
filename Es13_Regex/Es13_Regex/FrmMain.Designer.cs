namespace Es13_Regex
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTelefono = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnClasse = new System.Windows.Forms.Button();
            this.btnCodiceFiscale = new System.Windows.Forms.Button();
            this.btnSpecializzazione = new System.Windows.Forms.Button();
            this.btnIndirizzo = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnImporto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // btnTelefono
            // 
            this.btnTelefono.Location = new System.Drawing.Point(12, 52);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(102, 23);
            this.btnTelefono.TabIndex = 1;
            this.btnTelefono.Text = "Telefono";
            this.btnTelefono.UseVisualStyleBackColor = true;
            this.btnTelefono.Click += new System.EventHandler(this.btnMatch_click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(49, 14);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(203, 20);
            this.txtInput.TabIndex = 2;
            // 
            // btnClasse
            // 
            this.btnClasse.Location = new System.Drawing.Point(150, 52);
            this.btnClasse.Name = "btnClasse";
            this.btnClasse.Size = new System.Drawing.Size(102, 23);
            this.btnClasse.TabIndex = 3;
            this.btnClasse.Text = "Classe";
            this.btnClasse.UseVisualStyleBackColor = true;
            this.btnClasse.Click += new System.EventHandler(this.btnMatch_click);
            // 
            // btnCodiceFiscale
            // 
            this.btnCodiceFiscale.Location = new System.Drawing.Point(150, 104);
            this.btnCodiceFiscale.Name = "btnCodiceFiscale";
            this.btnCodiceFiscale.Size = new System.Drawing.Size(102, 23);
            this.btnCodiceFiscale.TabIndex = 5;
            this.btnCodiceFiscale.Text = "Codice Fiscale";
            this.btnCodiceFiscale.UseVisualStyleBackColor = true;
            this.btnCodiceFiscale.Click += new System.EventHandler(this.btnMatch_click);
            // 
            // btnSpecializzazione
            // 
            this.btnSpecializzazione.Location = new System.Drawing.Point(12, 104);
            this.btnSpecializzazione.Name = "btnSpecializzazione";
            this.btnSpecializzazione.Size = new System.Drawing.Size(102, 23);
            this.btnSpecializzazione.TabIndex = 4;
            this.btnSpecializzazione.Text = "Specializzazione";
            this.btnSpecializzazione.UseVisualStyleBackColor = true;
            this.btnSpecializzazione.Click += new System.EventHandler(this.btnMatch_click);
            // 
            // btnIndirizzo
            // 
            this.btnIndirizzo.Location = new System.Drawing.Point(150, 158);
            this.btnIndirizzo.Name = "btnIndirizzo";
            this.btnIndirizzo.Size = new System.Drawing.Size(102, 23);
            this.btnIndirizzo.TabIndex = 7;
            this.btnIndirizzo.Text = "Indirizzo";
            this.btnIndirizzo.UseVisualStyleBackColor = true;
            this.btnIndirizzo.Click += new System.EventHandler(this.btnMatch_click);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(12, 158);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(102, 23);
            this.btnEmail.TabIndex = 6;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnMatch_click);
            // 
            // btnImporto
            // 
            this.btnImporto.Location = new System.Drawing.Point(15, 206);
            this.btnImporto.Name = "btnImporto";
            this.btnImporto.Size = new System.Drawing.Size(99, 23);
            this.btnImporto.TabIndex = 8;
            this.btnImporto.Text = "Importo";
            this.btnImporto.UseVisualStyleBackColor = true;
            this.btnImporto.Click += new System.EventHandler(this.btnMatch_click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 246);
            this.Controls.Add(this.btnImporto);
            this.Controls.Add(this.btnIndirizzo);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnCodiceFiscale);
            this.Controls.Add(this.btnSpecializzazione);
            this.Controls.Add(this.btnClasse);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnTelefono);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTelefono;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnClasse;
        private System.Windows.Forms.Button btnCodiceFiscale;
        private System.Windows.Forms.Button btnSpecializzazione;
        private System.Windows.Forms.Button btnIndirizzo;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnImporto;
    }
}

