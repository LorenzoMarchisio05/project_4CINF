namespace Es08_Poligoni
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
            this.txtNumeroLati = new System.Windows.Forms.TextBox();
            this.txtLunghezzaLato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntAreaPerimetro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero lati";
            // 
            // txtNumeroLati
            // 
            this.txtNumeroLati.Location = new System.Drawing.Point(97, 35);
            this.txtNumeroLati.Name = "txtNumeroLati";
            this.txtNumeroLati.Size = new System.Drawing.Size(185, 20);
            this.txtNumeroLati.TabIndex = 1;
            // 
            // txtLunghezzaLato
            // 
            this.txtLunghezzaLato.Location = new System.Drawing.Point(97, 70);
            this.txtLunghezzaLato.Name = "txtLunghezzaLato";
            this.txtLunghezzaLato.Size = new System.Drawing.Size(185, 20);
            this.txtLunghezzaLato.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lunghezza lato";
            // 
            // bntAreaPerimetro
            // 
            this.bntAreaPerimetro.Location = new System.Drawing.Point(15, 118);
            this.bntAreaPerimetro.Name = "bntAreaPerimetro";
            this.bntAreaPerimetro.Size = new System.Drawing.Size(267, 28);
            this.bntAreaPerimetro.TabIndex = 5;
            this.bntAreaPerimetro.Text = "Calcola Area e Perimetro";
            this.bntAreaPerimetro.UseVisualStyleBackColor = true;
            this.bntAreaPerimetro.Click += new System.EventHandler(this.bntAreaPerimetro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 176);
            this.Controls.Add(this.bntAreaPerimetro);
            this.Controls.Add(this.txtLunghezzaLato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroLati);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Poligoni Regolari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroLati;
        private System.Windows.Forms.TextBox txtLunghezzaLato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntAreaPerimetro;
    }
}

