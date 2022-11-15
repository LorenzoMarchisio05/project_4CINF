namespace ES03_PassaggioDatiForm
{
    partial class frmDestCostruttore
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtRisposta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(58, 101);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 0;
            // 
            // txtRisposta
            // 
            this.txtRisposta.Location = new System.Drawing.Point(92, 207);
            this.txtRisposta.Name = "txtRisposta";
            this.txtRisposta.Size = new System.Drawing.Size(189, 20);
            this.txtRisposta.TabIndex = 1;
            // 
            // frmDestCostruttore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRisposta);
            this.Controls.Add(this.lblMsg);
            this.Name = "frmDestCostruttore";
            this.Text = "frmDestCostruttore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDestCostruttore_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtRisposta;
    }
}