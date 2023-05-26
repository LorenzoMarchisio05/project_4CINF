namespace Master_Detail_MVC
{
    partial class frmMasterDetail
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
            this.btnCancella = new System.Windows.Forms.Button();
            this.btnNuovoAlunno = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.lblCitta = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtIdAlunno = new System.Windows.Forms.TextBox();
            this.lblIdAlunno = new System.Windows.Forms.Label();
            this.dgvAlunni = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNascita = new System.Windows.Forms.Label();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.lblAltezza = new System.Windows.Forms.Label();
            this.nudAltezza = new System.Windows.Forms.NumericUpDown();
            this.lblInglese = new System.Windows.Forms.Label();
            this.chkInglese = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltezza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancella
            // 
            this.btnCancella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancella.Location = new System.Drawing.Point(424, 289);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(99, 23);
            this.btnCancella.TabIndex = 10;
            this.btnCancella.Text = "Cancella Alunno";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // btnNuovoAlunno
            // 
            this.btnNuovoAlunno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuovoAlunno.Location = new System.Drawing.Point(424, 260);
            this.btnNuovoAlunno.Name = "btnNuovoAlunno";
            this.btnNuovoAlunno.Size = new System.Drawing.Size(99, 23);
            this.btnNuovoAlunno.TabIndex = 9;
            this.btnNuovoAlunno.Text = "Nuovo Alunno";
            this.btnNuovoAlunno.UseVisualStyleBackColor = true;
            this.btnNuovoAlunno.Click += new System.EventHandler(this.btnNuovoAlunno_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(424, 231);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(99, 23);
            this.btnSalva.TabIndex = 8;
            this.btnSalva.Text = "Salva Modifiche";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTelefono.Location = new System.Drawing.Point(117, 421);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(43, 424);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtCitta
            // 
            this.txtCitta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCitta.Location = new System.Drawing.Point(117, 301);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(100, 20);
            this.txtCitta.TabIndex = 3;
            // 
            // lblCitta
            // 
            this.lblCitta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCitta.AutoSize = true;
            this.lblCitta.Location = new System.Drawing.Point(42, 304);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(28, 13);
            this.lblCitta.TabIndex = 17;
            this.lblCitta.Text = "Città";
            // 
            // txtCognome
            // 
            this.txtCognome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCognome.Location = new System.Drawing.Point(117, 228);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 1;
            // 
            // lblCognome
            // 
            this.lblCognome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(42, 231);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 15;
            this.lblCognome.Text = "Cognome";
            // 
            // txtIdAlunno
            // 
            this.txtIdAlunno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdAlunno.Location = new System.Drawing.Point(117, 192);
            this.txtIdAlunno.Name = "txtIdAlunno";
            this.txtIdAlunno.ReadOnly = true;
            this.txtIdAlunno.Size = new System.Drawing.Size(100, 20);
            this.txtIdAlunno.TabIndex = 14;
            // 
            // lblIdAlunno
            // 
            this.lblIdAlunno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdAlunno.AutoSize = true;
            this.lblIdAlunno.Location = new System.Drawing.Point(44, 195);
            this.lblIdAlunno.Name = "lblIdAlunno";
            this.lblIdAlunno.Size = new System.Drawing.Size(48, 13);
            this.lblIdAlunno.TabIndex = 13;
            this.lblIdAlunno.Text = "idAlunno";
            // 
            // dgvAlunni
            // 
            this.dgvAlunni.AllowUserToAddRows = false;
            this.dgvAlunni.AllowUserToDeleteRows = false;
            this.dgvAlunni.AllowUserToOrderColumns = true;
            this.dgvAlunni.AllowUserToResizeColumns = false;
            this.dgvAlunni.AllowUserToResizeRows = false;
            this.dgvAlunni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlunni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunni.Location = new System.Drawing.Point(-1, 7);
            this.dgvAlunni.Name = "dgvAlunni";
            this.dgvAlunni.ReadOnly = true;
            this.dgvAlunni.Size = new System.Drawing.Size(802, 169);
            this.dgvAlunni.TabIndex = 12;
            this.dgvAlunni.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunni_RowEnter);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNome.Location = new System.Drawing.Point(117, 263);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(42, 266);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // lblDataNascita
            // 
            this.lblDataNascita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDataNascita.AutoSize = true;
            this.lblDataNascita.Location = new System.Drawing.Point(44, 336);
            this.lblDataNascita.Name = "lblDataNascita";
            this.lblDataNascita.Size = new System.Drawing.Size(69, 13);
            this.lblDataNascita.TabIndex = 28;
            this.lblDataNascita.Text = "Data Nascita";
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataNascita.Location = new System.Drawing.Point(117, 334);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNascita.TabIndex = 4;
            // 
            // lblAltezza
            // 
            this.lblAltezza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAltezza.AutoSize = true;
            this.lblAltezza.Location = new System.Drawing.Point(44, 368);
            this.lblAltezza.Name = "lblAltezza";
            this.lblAltezza.Size = new System.Drawing.Size(41, 13);
            this.lblAltezza.TabIndex = 30;
            this.lblAltezza.Text = "Altezza";
            // 
            // nudAltezza
            // 
            this.nudAltezza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudAltezza.Location = new System.Drawing.Point(118, 366);
            this.nudAltezza.Name = "nudAltezza";
            this.nudAltezza.Size = new System.Drawing.Size(100, 20);
            this.nudAltezza.TabIndex = 5;
            // 
            // lblInglese
            // 
            this.lblInglese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInglese.AutoSize = true;
            this.lblInglese.Location = new System.Drawing.Point(44, 396);
            this.lblInglese.Name = "lblInglese";
            this.lblInglese.Size = new System.Drawing.Size(41, 13);
            this.lblInglese.TabIndex = 32;
            this.lblInglese.Text = "Inglese";
            // 
            // chkInglese
            // 
            this.chkInglese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkInglese.AutoSize = true;
            this.chkInglese.Location = new System.Drawing.Point(117, 396);
            this.chkInglese.Name = "chkInglese";
            this.chkInglese.Size = new System.Drawing.Size(15, 14);
            this.chkInglese.TabIndex = 6;
            this.chkInglese.UseVisualStyleBackColor = true;
            // 
            // frmMasterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.chkInglese);
            this.Controls.Add(this.lblInglese);
            this.Controls.Add(this.nudAltezza);
            this.Controls.Add(this.lblAltezza);
            this.Controls.Add(this.dtpDataNascita);
            this.Controls.Add(this.lblDataNascita);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnNuovoAlunno);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.lblCitta);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtIdAlunno);
            this.Controls.Add(this.lblIdAlunno);
            this.Controls.Add(this.dgvAlunni);
            this.Name = "frmMasterDetail";
            this.Text = "Master-Detail";
            this.Load += new System.EventHandler(this.frmMasterDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltezza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.Button btnNuovoAlunno;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtIdAlunno;
        private System.Windows.Forms.Label lblIdAlunno;
        private System.Windows.Forms.DataGridView dgvAlunni;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascita;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.Label lblAltezza;
        private System.Windows.Forms.NumericUpDown nudAltezza;
        private System.Windows.Forms.Label lblInglese;
        private System.Windows.Forms.CheckBox chkInglese;
    }
}

