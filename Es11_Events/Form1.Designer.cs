namespace Es11_Events
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
            this.components = new System.ComponentModel.Container();
            this.btnAccellera = new System.Windows.Forms.Button();
            this.pbVelocità = new System.Windows.Forms.ProgressBar();
            this.btnFrena = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAccendiMacchina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarcia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccellera
            // 
            this.btnAccellera.Location = new System.Drawing.Point(8, 73);
            this.btnAccellera.Name = "btnAccellera";
            this.btnAccellera.Size = new System.Drawing.Size(122, 23);
            this.btnAccellera.TabIndex = 0;
            this.btnAccellera.Text = "Accellera";
            this.btnAccellera.UseVisualStyleBackColor = true;
            // 
            // pbVelocità
            // 
            this.pbVelocità.Location = new System.Drawing.Point(8, 121);
            this.pbVelocità.Maximum = 10000;
            this.pbVelocità.Name = "pbVelocità";
            this.pbVelocità.Size = new System.Drawing.Size(250, 23);
            this.pbVelocità.TabIndex = 2;
            // 
            // btnFrena
            // 
            this.btnFrena.Location = new System.Drawing.Point(136, 73);
            this.btnFrena.Name = "btnFrena";
            this.btnFrena.Size = new System.Drawing.Size(122, 23);
            this.btnFrena.TabIndex = 3;
            this.btnFrena.Text = "Frena";
            this.btnFrena.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAccendiMacchina
            // 
            this.btnAccendiMacchina.Location = new System.Drawing.Point(12, 12);
            this.btnAccendiMacchina.Name = "btnAccendiMacchina";
            this.btnAccendiMacchina.Size = new System.Drawing.Size(110, 29);
            this.btnAccendiMacchina.TabIndex = 4;
            this.btnAccendiMacchina.Text = "ACCENDI";
            this.btnAccendiMacchina.UseVisualStyleBackColor = true;
            this.btnAccendiMacchina.Click += new System.EventHandler(this.btnAccendiMacchina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marcia: ";
            // 
            // lblMarcia
            // 
            this.lblMarcia.AutoSize = true;
            this.lblMarcia.Location = new System.Drawing.Point(196, 28);
            this.lblMarcia.Name = "lblMarcia";
            this.lblMarcia.Size = new System.Drawing.Size(49, 13);
            this.lblMarcia.TabIndex = 6;
            this.lblMarcia.Text = "N marcia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero Giri:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 153);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMarcia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccendiMacchina);
            this.Controls.Add(this.btnFrena);
            this.Controls.Add(this.pbVelocità);
            this.Controls.Add(this.btnAccellera);
            this.Name = "frmMain";
            this.Text = "Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccellera;
        private System.Windows.Forms.ProgressBar pbVelocità;
        private System.Windows.Forms.Button btnFrena;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAccendiMacchina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarcia;
        private System.Windows.Forms.Label label2;
    }
}

