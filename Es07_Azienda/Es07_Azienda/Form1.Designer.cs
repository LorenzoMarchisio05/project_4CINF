namespace Es07_Azienda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOreSpecializzazione = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnStipendioTotale = new System.Windows.Forms.Button();
            this.btnCntOperaiSpecializzati = new System.Windows.Forms.Button();
            this.btnNumeroOreSpecializzazione = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(69, 48);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(165, 20);
            this.txtCognome.TabIndex = 1;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(15, 179);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(219, 23);
            this.btnInserisci.TabIndex = 2;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Location = new System.Drawing.Point(264, -1);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(524, 416);
            this.dgv.TabIndex = 3;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txtOre
            // 
            this.txtOre.Location = new System.Drawing.Point(69, 100);
            this.txtOre.Name = "txtOre";
            this.txtOre.Size = new System.Drawing.Size(165, 20);
            this.txtOre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ore";
            // 
            // txtOreSpecializzazione
            // 
            this.txtOreSpecializzazione.Location = new System.Drawing.Point(123, 126);
            this.txtOreSpecializzazione.Name = "txtOreSpecializzazione";
            this.txtOreSpecializzazione.Size = new System.Drawing.Size(111, 20);
            this.txtOreSpecializzazione.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ore Specializzazione";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(15, 218);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(219, 23);
            this.btnAnnulla.TabIndex = 10;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnStipendioTotale
            // 
            this.btnStipendioTotale.Location = new System.Drawing.Point(15, 261);
            this.btnStipendioTotale.Name = "btnStipendioTotale";
            this.btnStipendioTotale.Size = new System.Drawing.Size(219, 23);
            this.btnStipendioTotale.TabIndex = 11;
            this.btnStipendioTotale.Text = "StipendioTotale";
            this.btnStipendioTotale.UseVisualStyleBackColor = true;
            this.btnStipendioTotale.Click += new System.EventHandler(this.btnStipendioTotale_Click);
            // 
            // btnCntOperaiSpecializzati
            // 
            this.btnCntOperaiSpecializzati.Location = new System.Drawing.Point(12, 301);
            this.btnCntOperaiSpecializzati.Name = "btnCntOperaiSpecializzati";
            this.btnCntOperaiSpecializzati.Size = new System.Drawing.Size(219, 23);
            this.btnCntOperaiSpecializzati.TabIndex = 12;
            this.btnCntOperaiSpecializzati.Text = "Numero Operai Specialzzati";
            this.btnCntOperaiSpecializzati.UseVisualStyleBackColor = true;
            this.btnCntOperaiSpecializzati.Click += new System.EventHandler(this.btnCntOperaiSpecializzati_Click);
            // 
            // btnNumeroOreSpecializzazione
            // 
            this.btnNumeroOreSpecializzazione.Location = new System.Drawing.Point(15, 343);
            this.btnNumeroOreSpecializzazione.Name = "btnNumeroOreSpecializzazione";
            this.btnNumeroOreSpecializzazione.Size = new System.Drawing.Size(219, 23);
            this.btnNumeroOreSpecializzazione.TabIndex = 13;
            this.btnNumeroOreSpecializzazione.Text = "Numero Ore Specializzazione";
            this.btnNumeroOreSpecializzazione.UseVisualStyleBackColor = true;
            this.btnNumeroOreSpecializzazione.Click += new System.EventHandler(this.btnNumeroOreSpecializzazione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.btnNumeroOreSpecializzazione);
            this.Controls.Add(this.btnCntOperaiSpecializzati);
            this.Controls.Add(this.btnStipendioTotale);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.txtOreSpecializzazione);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOreSpecializzazione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnStipendioTotale;
        private System.Windows.Forms.Button btnCntOperaiSpecializzati;
        private System.Windows.Forms.Button btnNumeroOreSpecializzazione;
    }
}

