namespace ES01_PERSONE
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
            this.btnInserimento = new System.Windows.Forms.Button();
            this.dgvElenco = new System.Windows.Forms.DataGridView();
            this.btnRicercaPerCognome = new System.Windows.Forms.Button();
            this.btnRicercaPerAnno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElenco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserimento
            // 
            this.btnInserimento.Location = new System.Drawing.Point(100, 200);
            this.btnInserimento.Name = "btnInserimento";
            this.btnInserimento.Size = new System.Drawing.Size(75, 23);
            this.btnInserimento.TabIndex = 0;
            this.btnInserimento.Text = "inserisci";
            this.btnInserimento.UseVisualStyleBackColor = true;
            this.btnInserimento.Click += new System.EventHandler(this.btnInserimento_Click);
            // 
            // dgvElenco
            // 
            this.dgvElenco.AllowUserToAddRows = false;
            this.dgvElenco.AllowUserToDeleteRows = false;
            this.dgvElenco.AllowUserToResizeRows = false;
            this.dgvElenco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElenco.Location = new System.Drawing.Point(283, 25);
            this.dgvElenco.Name = "dgvElenco";
            this.dgvElenco.ReadOnly = true;
            this.dgvElenco.Size = new System.Drawing.Size(493, 242);
            this.dgvElenco.TabIndex = 1;
            this.dgvElenco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElenco_CellClick);
            // 
            // btnRicercaPerCognome
            // 
            this.btnRicercaPerCognome.Location = new System.Drawing.Point(71, 260);
            this.btnRicercaPerCognome.Name = "btnRicercaPerCognome";
            this.btnRicercaPerCognome.Size = new System.Drawing.Size(147, 23);
            this.btnRicercaPerCognome.TabIndex = 2;
            this.btnRicercaPerCognome.Text = "Ricerca Per Nome";
            this.btnRicercaPerCognome.UseVisualStyleBackColor = true;
            this.btnRicercaPerCognome.Click += new System.EventHandler(this.btnRicercaPerCognome_Click);
            // 
            // btnRicercaPerAnno
            // 
            this.btnRicercaPerAnno.Location = new System.Drawing.Point(71, 308);
            this.btnRicercaPerAnno.Name = "btnRicercaPerAnno";
            this.btnRicercaPerAnno.Size = new System.Drawing.Size(147, 23);
            this.btnRicercaPerAnno.TabIndex = 3;
            this.btnRicercaPerAnno.Text = "Ricerca Per Data";
            this.btnRicercaPerAnno.UseVisualStyleBackColor = true;
            this.btnRicercaPerAnno.Click += new System.EventHandler(this.btnRicercaPerAnno_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 375);
            this.Controls.Add(this.btnRicercaPerAnno);
            this.Controls.Add(this.btnRicercaPerCognome);
            this.Controls.Add(this.dgvElenco);
            this.Controls.Add(this.btnInserimento);
            this.Name = "frmMain";
            this.Text = "Gestione Personale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElenco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserimento;
        private System.Windows.Forms.DataGridView dgvElenco;
        private System.Windows.Forms.Button btnRicercaPerCognome;
        private System.Windows.Forms.Button btnRicercaPerAnno;
    }
}

