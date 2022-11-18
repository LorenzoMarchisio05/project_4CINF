namespace Es10_Delegate
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnSomma = new System.Windows.Forms.Button();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSottrazione = new System.Windows.Forms.Button();
            this.btnProdotto = new System.Windows.Forms.Button();
            this.btnDivisione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(66, 46);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(193, 20);
            this.txtNumero1.TabIndex = 1;
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(12, 140);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(122, 23);
            this.btnSomma.TabIndex = 2;
            this.btnSomma.Text = "Somma";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnOperazione_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(66, 91);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(193, 20);
            this.txtNumero2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 2";
            // 
            // btnSottrazione
            // 
            this.btnSottrazione.Location = new System.Drawing.Point(140, 140);
            this.btnSottrazione.Name = "btnSottrazione";
            this.btnSottrazione.Size = new System.Drawing.Size(119, 23);
            this.btnSottrazione.TabIndex = 7;
            this.btnSottrazione.Text = "Sottrazione";
            this.btnSottrazione.UseVisualStyleBackColor = true;
            this.btnSottrazione.Click += new System.EventHandler(this.btnOperazione_Click);
            // 
            // btnProdotto
            // 
            this.btnProdotto.Location = new System.Drawing.Point(12, 182);
            this.btnProdotto.Name = "btnProdotto";
            this.btnProdotto.Size = new System.Drawing.Size(122, 23);
            this.btnProdotto.TabIndex = 8;
            this.btnProdotto.Text = "Prodotto";
            this.btnProdotto.UseVisualStyleBackColor = true;
            this.btnProdotto.Click += new System.EventHandler(this.btnOperazione_Click);
            // 
            // btnDivisione
            // 
            this.btnDivisione.Location = new System.Drawing.Point(140, 182);
            this.btnDivisione.Name = "btnDivisione";
            this.btnDivisione.Size = new System.Drawing.Size(122, 23);
            this.btnDivisione.TabIndex = 9;
            this.btnDivisione.Text = "Divisione";
            this.btnDivisione.UseVisualStyleBackColor = true;
            this.btnDivisione.Click += new System.EventHandler(this.btnOperazione_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 215);
            this.Controls.Add(this.btnDivisione);
            this.Controls.Add(this.btnProdotto);
            this.Controls.Add(this.btnSottrazione);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSomma);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Delegate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSottrazione;
        private System.Windows.Forms.Button btnProdotto;
        private System.Windows.Forms.Button btnDivisione;
    }
}

