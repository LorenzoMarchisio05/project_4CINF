namespace Es12_Email
{
    partial class FrmMain
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOggetto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitoloDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPathDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAggiungiEmail = new System.Windows.Forms.Button();
            this.chkAllegato = new System.Windows.Forms.CheckBox();
            this.cmbContatti = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(131, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Destinatario";
            // 
            // txtOggetto
            // 
            this.txtOggetto.Location = new System.Drawing.Point(71, 96);
            this.txtOggetto.Multiline = true;
            this.txtOggetto.Name = "txtOggetto";
            this.txtOggetto.Size = new System.Drawing.Size(172, 94);
            this.txtOggetto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oggetto";
            // 
            // txtTitoloDocumento
            // 
            this.txtTitoloDocumento.Location = new System.Drawing.Point(112, 196);
            this.txtTitoloDocumento.Name = "txtTitoloDocumento";
            this.txtTitoloDocumento.ReadOnly = true;
            this.txtTitoloDocumento.Size = new System.Drawing.Size(134, 20);
            this.txtTitoloDocumento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titolo Documento";
            // 
            // txtPathDocumento
            // 
            this.txtPathDocumento.Location = new System.Drawing.Point(112, 255);
            this.txtPathDocumento.Name = "txtPathDocumento";
            this.txtPathDocumento.ReadOnly = true;
            this.txtPathDocumento.Size = new System.Drawing.Size(138, 20);
            this.txtPathDocumento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Path Documento";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(394, 19);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(491, 290);
            this.dgv.TabIndex = 10;
            // 
            // btnAggiungiEmail
            // 
            this.btnAggiungiEmail.Location = new System.Drawing.Point(12, 286);
            this.btnAggiungiEmail.Name = "btnAggiungiEmail";
            this.btnAggiungiEmail.Size = new System.Drawing.Size(119, 23);
            this.btnAggiungiEmail.TabIndex = 11;
            this.btnAggiungiEmail.Text = "Aggiungi email";
            this.btnAggiungiEmail.UseVisualStyleBackColor = true;
            this.btnAggiungiEmail.Click += new System.EventHandler(this.btnAggiungiEmail_Click);
            // 
            // chkAllegato
            // 
            this.chkAllegato.AutoSize = true;
            this.chkAllegato.Location = new System.Drawing.Point(18, 229);
            this.chkAllegato.Name = "chkAllegato";
            this.chkAllegato.Size = new System.Drawing.Size(64, 17);
            this.chkAllegato.TabIndex = 12;
            this.chkAllegato.Text = "Allegato";
            this.chkAllegato.UseVisualStyleBackColor = true;
            this.chkAllegato.CheckedChanged += new System.EventHandler(this.chkAllegato_CheckedChanged);
            // 
            // cmbContatti
            // 
            this.cmbContatti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContatti.FormattingEnabled = true;
            this.cmbContatti.Location = new System.Drawing.Point(249, 56);
            this.cmbContatti.Name = "cmbContatti";
            this.cmbContatti.Size = new System.Drawing.Size(121, 21);
            this.cmbContatti.TabIndex = 13;
            this.cmbContatti.SelectedIndexChanged += new System.EventHandler(this.cmbContatti_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lista Contatti";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 321);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbContatti);
            this.Controls.Add(this.chkAllegato);
            this.Controls.Add(this.btnAggiungiEmail);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtPathDocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitoloDocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOggetto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "Email";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOggetto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitoloDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPathDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAggiungiEmail;
        private System.Windows.Forms.CheckBox chkAllegato;
        private System.Windows.Forms.ComboBox cmbContatti;
        private System.Windows.Forms.Label label6;
    }
}

