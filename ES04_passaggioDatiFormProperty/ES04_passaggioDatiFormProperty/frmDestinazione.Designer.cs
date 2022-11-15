namespace ES04_passaggioDatiFormProperty
{
    partial class frmDestinazione
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChiudi = new System.Windows.Forms.Button();
            this.txtTesto = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChiudi
            // 
            this.btnChiudi.Location = new System.Drawing.Point(37, 98);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.Size = new System.Drawing.Size(75, 23);
            this.btnChiudi.TabIndex = 0;
            this.btnChiudi.Text = "chiudi form";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // txtTesto
            // 
            this.txtTesto.Location = new System.Drawing.Point(37, 72);
            this.txtTesto.Name = "txtTesto";
            this.txtTesto.Size = new System.Drawing.Size(190, 20);
            this.txtTesto.TabIndex = 1;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(34, 45);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(35, 13);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "label1";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(152, 98);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 3;
            this.btnAnnulla.Text = "annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // frmDestinazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 165);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtTesto);
            this.Controls.Add(this.btnChiudi);
            this.Name = "frmDestinazione";
            this.Text = "frmDestinazione";
            this.Load += new System.EventHandler(this.frmDestinazione_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.TextBox txtTesto;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnAnnulla;
    }
}