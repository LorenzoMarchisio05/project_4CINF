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
            this.lblFont = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbModifiers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTextAlign = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRighe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbColonne = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
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
            this.txtText.Size = new System.Drawing.Size(384, 218);
            this.txtText.TabIndex = 2;
            // 
            // btnInsertText
            // 
            this.btnInsertText.Location = new System.Drawing.Point(416, 328);
            this.btnInsertText.Name = "btnInsertText";
            this.btnInsertText.Size = new System.Drawing.Size(118, 23);
            this.btnInsertText.TabIndex = 3;
            this.btnInsertText.Text = "Inserisci Testo";
            this.btnInsertText.UseVisualStyleBackColor = true;
            this.btnInsertText.Click += new System.EventHandler(this.btnInsertText_Click);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(12, 47);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(28, 13);
            this.lblFont.TabIndex = 4;
            this.lblFont.Text = "Font";
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(12, 63);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(121, 21);
            this.cmbFont.TabIndex = 5;
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(151, 63);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 21);
            this.cmbSize.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Size";
            // 
            // cmbModifiers
            // 
            this.cmbModifiers.FormattingEnabled = true;
            this.cmbModifiers.Location = new System.Drawing.Point(289, 63);
            this.cmbModifiers.Name = "cmbModifiers";
            this.cmbModifiers.Size = new System.Drawing.Size(121, 21);
            this.cmbModifiers.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Underlined";
            // 
            // cmbTextAlign
            // 
            this.cmbTextAlign.FormattingEnabled = true;
            this.cmbTextAlign.Location = new System.Drawing.Point(416, 63);
            this.cmbTextAlign.Name = "cmbTextAlign";
            this.cmbTextAlign.Size = new System.Drawing.Size(121, 21);
            this.cmbTextAlign.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Text align";
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(15, 97);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(47, 17);
            this.chkBold.TabIndex = 12;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(77, 97);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(48, 17);
            this.chkItalic.TabIndex = 13;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(416, 117);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Color";
            // 
            // cmbRighe
            // 
            this.cmbRighe.FormattingEnabled = true;
            this.cmbRighe.Location = new System.Drawing.Point(6, 32);
            this.cmbRighe.Name = "cmbRighe";
            this.cmbRighe.Size = new System.Drawing.Size(121, 21);
            this.cmbRighe.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Righe";
            // 
            // cmbColonne
            // 
            this.cmbColonne.FormattingEnabled = true;
            this.cmbColonne.Location = new System.Drawing.Point(5, 72);
            this.cmbColonne.Name = "cmbColonne";
            this.cmbColonne.Size = new System.Drawing.Size(121, 21);
            this.cmbColonne.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Colonne";
            // 
            // btnInsertTable
            // 
            this.btnInsertTable.Location = new System.Drawing.Point(6, 99);
            this.btnInsertTable.Name = "btnInsertTable";
            this.btnInsertTable.Size = new System.Drawing.Size(118, 23);
            this.btnInsertTable.TabIndex = 20;
            this.btnInsertTable.Text = "Inserisci Tabella";
            this.btnInsertTable.UseVisualStyleBackColor = true;
            this.btnInsertTable.Click += new System.EventHandler(this.btnInsertTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRighe);
            this.groupBox1.Controls.Add(this.btnInsertTable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbColonne);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(416, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 140);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabella";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.cmbTextAlign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbModifiers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.btnInsertText);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblTesto);
            this.Controls.Add(this.btnNewDocument);
            this.Name = "Form";
            this.Text = "Word C#";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewDocument;
        private System.Windows.Forms.Label lblTesto;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnInsertText;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbModifiers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTextAlign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRighe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbColonne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertTable;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

