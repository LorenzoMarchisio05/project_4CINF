namespace View
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
            this.dgvCaseEditrici = new System.Windows.Forms.DataGridView();
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaseEditrici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaseEditrici
            // 
            this.dgvCaseEditrici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaseEditrici.Location = new System.Drawing.Point(12, 12);
            this.dgvCaseEditrici.Name = "dgvCaseEditrici";
            this.dgvCaseEditrici.Size = new System.Drawing.Size(362, 304);
            this.dgvCaseEditrici.TabIndex = 0;
            this.dgvCaseEditrici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaseEditrici_CellClick);
            // 
            // dgvLibri
            // 
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Location = new System.Drawing.Point(397, 12);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.Size = new System.Drawing.Size(327, 304);
            this.dgvLibri.TabIndex = 1;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(730, 327);
            this.Controls.Add(this.dgvLibri);
            this.Controls.Add(this.dgvCaseEditrici);
            this.Name = "frmMain";
            this.Text = "Libri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaseEditrici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaseEditrici;
        private System.Windows.Forms.DataGridView dgvLibri;
    }
}

