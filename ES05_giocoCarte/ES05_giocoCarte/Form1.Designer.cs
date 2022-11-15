using System;

namespace ES05_giocoCarte
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblSeme = new System.Windows.Forms.Label();
            this.txtSeme = new System.Windows.Forms.TextBox();
            this.txtValore = new System.Windows.Forms.TextBox();
            this.lblValore = new System.Windows.Forms.Label();
            this.btnProponi = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnTotali = new System.Windows.Forms.Button();
            this.btnMescola = new System.Windows.Forms.Button();
            this.btnDammiCarta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(327, 13);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(461, 252);
            this.dgv.TabIndex = 0;
            // 
            // lblSeme
            // 
            this.lblSeme.AutoSize = true;
            this.lblSeme.Location = new System.Drawing.Point(63, 54);
            this.lblSeme.Name = "lblSeme";
            this.lblSeme.Size = new System.Drawing.Size(34, 13);
            this.lblSeme.TabIndex = 1;
            this.lblSeme.Text = "Seme";
            // 
            // txtSeme
            // 
            this.txtSeme.Location = new System.Drawing.Point(124, 51);
            this.txtSeme.Name = "txtSeme";
            this.txtSeme.Size = new System.Drawing.Size(186, 20);
            this.txtSeme.TabIndex = 2;
            // 
            // txtValore
            // 
            this.txtValore.Location = new System.Drawing.Point(124, 77);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(186, 20);
            this.txtValore.TabIndex = 4;
            // 
            // lblValore
            // 
            this.lblValore.AutoSize = true;
            this.lblValore.Location = new System.Drawing.Point(63, 80);
            this.lblValore.Name = "lblValore";
            this.lblValore.Size = new System.Drawing.Size(37, 13);
            this.lblValore.TabIndex = 3;
            this.lblValore.Text = "Valore";
            // 
            // btnProponi
            // 
            this.btnProponi.Location = new System.Drawing.Point(66, 136);
            this.btnProponi.Name = "btnProponi";
            this.btnProponi.Size = new System.Drawing.Size(102, 23);
            this.btnProponi.TabIndex = 5;
            this.btnProponi.Text = "Proponi";
            this.btnProponi.UseVisualStyleBackColor = true;
            this.btnProponi.Click += new System.EventHandler(this.btnProponi_Click);
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(194, 136);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(102, 23);
            this.btnInserisci.TabIndex = 6;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnTotali
            // 
            this.btnTotali.Location = new System.Drawing.Point(66, 191);
            this.btnTotali.Name = "btnTotali";
            this.btnTotali.Size = new System.Drawing.Size(102, 23);
            this.btnTotali.TabIndex = 7;
            this.btnTotali.Text = "Totali";
            this.btnTotali.UseVisualStyleBackColor = true;
            this.btnTotali.Click += new System.EventHandler(this.btnTotali_Click);
            // 
            // btnMescola
            // 
            this.btnMescola.Location = new System.Drawing.Point(194, 191);
            this.btnMescola.Name = "btnMescola";
            this.btnMescola.Size = new System.Drawing.Size(102, 23);
            this.btnMescola.TabIndex = 8;
            this.btnMescola.Text = "Mescola";
            this.btnMescola.UseVisualStyleBackColor = true;
            this.btnMescola.Click += new System.EventHandler(this.btnMescola_Click);
            // 
            // btnDammiCarta
            // 
            this.btnDammiCarta.Location = new System.Drawing.Point(66, 242);
            this.btnDammiCarta.Name = "btnDammiCarta";
            this.btnDammiCarta.Size = new System.Drawing.Size(230, 23);
            this.btnDammiCarta.TabIndex = 9;
            this.btnDammiCarta.Text = "Dammi la carta";
            this.btnDammiCarta.UseVisualStyleBackColor = true;
            this.btnDammiCarta.Click += new System.EventHandler(btnDammiCarta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 289);
            this.Controls.Add(this.btnDammiCarta);
            this.Controls.Add(this.btnMescola);
            this.Controls.Add(this.btnTotali);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.btnProponi);
            this.Controls.Add(this.txtValore);
            this.Controls.Add(this.lblValore);
            this.Controls.Add(this.txtSeme);
            this.Controls.Add(this.lblSeme);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Gioco Carte";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblSeme;
        private System.Windows.Forms.TextBox txtSeme;
        private System.Windows.Forms.TextBox txtValore;
        private System.Windows.Forms.Label lblValore;
        private System.Windows.Forms.Button btnProponi;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnTotali;
        private System.Windows.Forms.Button btnMescola;
        private System.Windows.Forms.Button btnDammiCarta;
    }
}

