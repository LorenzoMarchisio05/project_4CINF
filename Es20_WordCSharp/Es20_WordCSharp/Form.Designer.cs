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
            this.btnCreatePdf = new System.Windows.Forms.Button();
            this.btnSaveDoc = new System.Windows.Forms.Button();
            this.btnPrintDocument = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblSelectFrom = new System.Windows.Forms.Label();
            this.txtSelectFrom = new System.Windows.Forms.TextBox();
            this.txtSelectTo = new System.Windows.Forms.TextBox();
            this.lblSelectTo = new System.Windows.Forms.Label();
            this.btnSelectText = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkReplaceText = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchReplace = new System.Windows.Forms.Button();
            this.txtSearchFor = new System.Windows.Forms.TextBox();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.txtText.Size = new System.Drawing.Size(437, 315);
            this.txtText.TabIndex = 2;
            // 
            // btnInsertText
            // 
            this.btnInsertText.Location = new System.Drawing.Point(468, 192);
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
            this.cmbColor.Location = new System.Drawing.Point(555, 63);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 47);
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
            this.cmbRighe.Size = new System.Drawing.Size(99, 21);
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
            this.cmbColonne.Size = new System.Drawing.Size(100, 21);
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
            this.btnInsertTable.Size = new System.Drawing.Size(99, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(759, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 125);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabella";
            // 
            // btnCreatePdf
            // 
            this.btnCreatePdf.Location = new System.Drawing.Point(295, 12);
            this.btnCreatePdf.Name = "btnCreatePdf";
            this.btnCreatePdf.Size = new System.Drawing.Size(118, 23);
            this.btnCreatePdf.TabIndex = 22;
            this.btnCreatePdf.Text = "Crea PDF";
            this.btnCreatePdf.UseVisualStyleBackColor = true;
            this.btnCreatePdf.Click += new System.EventHandler(this.btnCreatePdf_Click);
            // 
            // btnSaveDoc
            // 
            this.btnSaveDoc.Location = new System.Drawing.Point(468, 163);
            this.btnSaveDoc.Name = "btnSaveDoc";
            this.btnSaveDoc.Size = new System.Drawing.Size(118, 23);
            this.btnSaveDoc.TabIndex = 23;
            this.btnSaveDoc.Text = "Salva e chiudi word";
            this.btnSaveDoc.UseVisualStyleBackColor = true;
            this.btnSaveDoc.Click += new System.EventHandler(this.btnSaveDoc_Click);
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.Location = new System.Drawing.Point(419, 12);
            this.btnPrintDocument.Name = "btnPrintDocument";
            this.btnPrintDocument.Size = new System.Drawing.Size(118, 23);
            this.btnPrintDocument.TabIndex = 24;
            this.btnPrintDocument.Text = "Stampa";
            this.btnPrintDocument.UseVisualStyleBackColor = true;
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(468, 131);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Chiudi word";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(163, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(126, 23);
            this.btnOpen.TabIndex = 26;
            this.btnOpen.Text = "Apri Documento Word";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblSelectFrom
            // 
            this.lblSelectFrom.AutoSize = true;
            this.lblSelectFrom.Location = new System.Drawing.Point(6, 16);
            this.lblSelectFrom.Name = "lblSelectFrom";
            this.lblSelectFrom.Size = new System.Drawing.Size(71, 13);
            this.lblSelectFrom.TabIndex = 27;
            this.lblSelectFrom.Text = "Seleziona da:";
            // 
            // txtSelectFrom
            // 
            this.txtSelectFrom.Location = new System.Drawing.Point(5, 32);
            this.txtSelectFrom.Name = "txtSelectFrom";
            this.txtSelectFrom.Size = new System.Drawing.Size(100, 20);
            this.txtSelectFrom.TabIndex = 28;
            // 
            // txtSelectTo
            // 
            this.txtSelectTo.Location = new System.Drawing.Point(5, 84);
            this.txtSelectTo.Name = "txtSelectTo";
            this.txtSelectTo.Size = new System.Drawing.Size(100, 20);
            this.txtSelectTo.TabIndex = 30;
            // 
            // lblSelectTo
            // 
            this.lblSelectTo.AutoSize = true;
            this.lblSelectTo.Location = new System.Drawing.Point(6, 68);
            this.lblSelectTo.Name = "lblSelectTo";
            this.lblSelectTo.Size = new System.Drawing.Size(85, 13);
            this.lblSelectTo.TabIndex = 29;
            this.lblSelectTo.Text = "Seleziona fino a:";
            // 
            // btnSelectText
            // 
            this.btnSelectText.Location = new System.Drawing.Point(6, 110);
            this.btnSelectText.Name = "btnSelectText";
            this.btnSelectText.Size = new System.Drawing.Size(97, 23);
            this.btnSelectText.TabIndex = 31;
            this.btnSelectText.Text = "Seleziona testo";
            this.btnSelectText.UseVisualStyleBackColor = true;
            this.btnSelectText.Click += new System.EventHandler(this.btnSelectText_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSelectFrom);
            this.groupBox2.Controls.Add(this.btnSelectText);
            this.groupBox2.Controls.Add(this.txtSelectFrom);
            this.groupBox2.Controls.Add(this.txtSelectTo);
            this.groupBox2.Controls.Add(this.lblSelectTo);
            this.groupBox2.Location = new System.Drawing.Point(759, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 145);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkReplaceText);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnSearchReplace);
            this.groupBox3.Controls.Add(this.txtSearchFor);
            this.groupBox3.Controls.Add(this.txtReplaceWith);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(759, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 154);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find and replace";
            // 
            // chkReplaceText
            // 
            this.chkReplaceText.AutoSize = true;
            this.chkReplaceText.Location = new System.Drawing.Point(14, 125);
            this.chkReplaceText.Name = "chkReplaceText";
            this.chkReplaceText.Size = new System.Drawing.Size(100, 17);
            this.chkReplaceText.TabIndex = 32;
            this.chkReplaceText.Text = "Rimpiazza testo";
            this.chkReplaceText.UseVisualStyleBackColor = true;
            this.chkReplaceText.CheckedChanged += new System.EventHandler(this.chkReplaceText_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Testo da cercare:";
            // 
            // btnSearchReplace
            // 
            this.btnSearchReplace.Location = new System.Drawing.Point(7, 96);
            this.btnSearchReplace.Name = "btnSearchReplace";
            this.btnSearchReplace.Size = new System.Drawing.Size(97, 23);
            this.btnSearchReplace.TabIndex = 31;
            this.btnSearchReplace.Text = "Ricerca testo";
            this.btnSearchReplace.UseVisualStyleBackColor = true;
            this.btnSearchReplace.Click += new System.EventHandler(this.btnSearchReplace_Click);
            // 
            // txtSearchFor
            // 
            this.txtSearchFor.Location = new System.Drawing.Point(5, 32);
            this.txtSearchFor.Name = "txtSearchFor";
            this.txtSearchFor.Size = new System.Drawing.Size(100, 20);
            this.txtSearchFor.TabIndex = 28;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(3, 70);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(100, 20);
            this.txtReplaceWith.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sostituisci con";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 460);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrintDocument);
            this.Controls.Add(this.btnSaveDoc);
            this.Controls.Add(this.btnCreatePdf);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button btnCreatePdf;
        private System.Windows.Forms.Button btnSaveDoc;
        private System.Windows.Forms.Button btnPrintDocument;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblSelectFrom;
        private System.Windows.Forms.TextBox txtSelectFrom;
        private System.Windows.Forms.TextBox txtSelectTo;
        private System.Windows.Forms.Label lblSelectTo;
        private System.Windows.Forms.Button btnSelectText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearchReplace;
        private System.Windows.Forms.TextBox txtSearchFor;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkReplaceText;
    }
}

