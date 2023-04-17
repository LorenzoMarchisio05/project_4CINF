namespace Es27_ADONET01
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
            this.btnCountStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCountStudents
            // 
            this.btnCountStudents.Location = new System.Drawing.Point(37, 37);
            this.btnCountStudents.Name = "btnCountStudents";
            this.btnCountStudents.Size = new System.Drawing.Size(137, 30);
            this.btnCountStudents.TabIndex = 0;
            this.btnCountStudents.Text = "Conta Alunni";
            this.btnCountStudents.UseVisualStyleBackColor = true;
            this.btnCountStudents.Click += new System.EventHandler(this.btnCountStudents_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCountStudents);
            this.Name = "FrmMain";
            this.Text = "Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCountStudents;
    }
}

