﻿namespace Es06_EditorHTML
{
    partial class TableForm
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
            this.txtNumeroColonne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroRighe = new System.Windows.Forms.TextBox();
            this.btnCreaTabella = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroColonne
            // 
            this.txtNumeroColonne.Location = new System.Drawing.Point(103, 26);
            this.txtNumeroColonne.Name = "txtNumeroColonne";
            this.txtNumeroColonne.Size = new System.Drawing.Size(105, 20);
            this.txtNumeroColonne.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero colonne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero righe";
            // 
            // txtNumeroRighe
            // 
            this.txtNumeroRighe.Location = new System.Drawing.Point(103, 52);
            this.txtNumeroRighe.Name = "txtNumeroRighe";
            this.txtNumeroRighe.Size = new System.Drawing.Size(105, 20);
            this.txtNumeroRighe.TabIndex = 2;
            // 
            // btnCreaTabella
            // 
            this.btnCreaTabella.Location = new System.Drawing.Point(7, 104);
            this.btnCreaTabella.Name = "btnCreaTabella";
            this.btnCreaTabella.Size = new System.Drawing.Size(201, 23);
            this.btnCreaTabella.TabIndex = 4;
            this.btnCreaTabella.Text = "Crea";
            this.btnCreaTabella.UseVisualStyleBackColor = true;
            this.btnCreaTabella.Click += new System.EventHandler(this.btnCreaTabella_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 131);
            this.Controls.Add(this.btnCreaTabella);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroRighe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroColonne);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroColonne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroRighe;
        private System.Windows.Forms.Button btnCreaTabella;
    }
}