namespace ES23_StampaUnione
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
            this.btnCreateModuleTemplate = new System.Windows.Forms.Button();
            this.btnReadModuleData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateModuleTemplate
            // 
            this.btnCreateModuleTemplate.Location = new System.Drawing.Point(40, 26);
            this.btnCreateModuleTemplate.Name = "btnCreateModuleTemplate";
            this.btnCreateModuleTemplate.Size = new System.Drawing.Size(154, 46);
            this.btnCreateModuleTemplate.TabIndex = 0;
            this.btnCreateModuleTemplate.Text = "Crea Modulo";
            this.btnCreateModuleTemplate.UseVisualStyleBackColor = true;
            this.btnCreateModuleTemplate.Click += new System.EventHandler(this.btnCreateModuleTemplate_Click);
            // 
            // btnReadModuleData
            // 
            this.btnReadModuleData.Location = new System.Drawing.Point(237, 26);
            this.btnReadModuleData.Name = "btnReadModuleData";
            this.btnReadModuleData.Size = new System.Drawing.Size(154, 46);
            this.btnReadModuleData.TabIndex = 1;
            this.btnReadModuleData.Text = "Leggi dati modulo su file .docx";
            this.btnReadModuleData.UseVisualStyleBackColor = true;
            this.btnReadModuleData.Click += new System.EventHandler(this.btnReadModuleData_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadModuleData);
            this.Controls.Add(this.btnCreateModuleTemplate);
            this.Name = "Form";
            this.Text = "Stampa Unione";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateModuleTemplate;
        private System.Windows.Forms.Button btnReadModuleData;
    }
}

