namespace Es12_Interfacce
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
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.dtDataRilascio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComune = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodiceCarta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvIscritto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIscritto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(66, 225);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(112, 23);
            this.btnAggiungi.TabIndex = 0;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // dtDataRilascio
            // 
            this.dtDataRilascio.Location = new System.Drawing.Point(96, 174);
            this.dtDataRilascio.Name = "dtDataRilascio";
            this.dtDataRilascio.Size = new System.Drawing.Size(134, 20);
            this.dtDataRilascio.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Rilascio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome Comune";
            // 
            // txtComune
            // 
            this.txtComune.Location = new System.Drawing.Point(96, 133);
            this.txtComune.Name = "txtComune";
            this.txtComune.Size = new System.Drawing.Size(134, 20);
            this.txtComune.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Codice Carta Identita";
            // 
            // txtCodiceCarta
            // 
            this.txtCodiceCarta.Location = new System.Drawing.Point(116, 94);
            this.txtCodiceCarta.Name = "txtCodiceCarta";
            this.txtCodiceCarta.Size = new System.Drawing.Size(114, 20);
            this.txtCodiceCarta.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(76, 57);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(154, 20);
            this.txtCognome.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 14;
            // 
            // dgvIscritto
            // 
            this.dgvIscritto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIscritto.Location = new System.Drawing.Point(236, 12);
            this.dgvIscritto.Name = "dgvIscritto";
            this.dgvIscritto.Size = new System.Drawing.Size(574, 236);
            this.dgvIscritto.TabIndex = 18;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 252);
            this.Controls.Add(this.dgvIscritto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtDataRilascio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtComune);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodiceCarta);
            this.Controls.Add(this.btnAggiungi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Interfacce";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIscritto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.DateTimePicker dtDataRilascio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComune;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodiceCarta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvIscritto;
    }
}

