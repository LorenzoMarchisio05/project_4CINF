namespace thread9___Forms
{
    partial class FrmThread
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
            this.lblClock = new System.Windows.Forms.Label();
            this.lblClockThread = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnSaveFileThread = new System.Windows.Forms.Button();
            this.btnOtherOperations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(42, 39);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(25, 24);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "X";
            // 
            // lblClockThread
            // 
            this.lblClockThread.AutoSize = true;
            this.lblClockThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockThread.Location = new System.Drawing.Point(42, 86);
            this.lblClockThread.Name = "lblClockThread";
            this.lblClockThread.Size = new System.Drawing.Size(25, 24);
            this.lblClockThread.TabIndex = 1;
            this.lblClockThread.Text = "X";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 193);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(370, 23);
            this.progressBar.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(12, 131);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFile.TabIndex = 3;
            this.btnWriteFile.Text = "Scrivi File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnSaveFileThread
            // 
            this.btnSaveFileThread.Location = new System.Drawing.Point(118, 131);
            this.btnSaveFileThread.Name = "btnSaveFileThread";
            this.btnSaveFileThread.Size = new System.Drawing.Size(100, 23);
            this.btnSaveFileThread.TabIndex = 4;
            this.btnSaveFileThread.Text = "Scrivi File Thread";
            this.btnSaveFileThread.UseVisualStyleBackColor = true;
            this.btnSaveFileThread.Click += new System.EventHandler(this.btnSaveFileThread_Click);
            // 
            // btnOtherOperations
            // 
            this.btnOtherOperations.Location = new System.Drawing.Point(241, 131);
            this.btnOtherOperations.Name = "btnOtherOperations";
            this.btnOtherOperations.Size = new System.Drawing.Size(100, 23);
            this.btnOtherOperations.TabIndex = 5;
            this.btnOtherOperations.Text = "Altre Operazioni";
            this.btnOtherOperations.UseVisualStyleBackColor = true;
            this.btnOtherOperations.Click += new System.EventHandler(this.btnOtherOperations_Click);
            // 
            // FrmThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 232);
            this.Controls.Add(this.btnOtherOperations);
            this.Controls.Add(this.btnSaveFileThread);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblClockThread);
            this.Controls.Add(this.lblClock);
            this.Name = "FrmThread";
            this.Text = "Threads";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmThread_FormClosing);
            this.Load += new System.EventHandler(this.FrmThread_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblClockThread;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnSaveFileThread;
        private System.Windows.Forms.Button btnOtherOperations;
    }
}

