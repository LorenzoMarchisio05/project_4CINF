namespace thread10___Programmazione_concorrente
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
            this.btnLock = new System.Windows.Forms.Button();
            this.dgvLock = new System.Windows.Forms.DataGridView();
            this.dgvMutex = new System.Windows.Forms.DataGridView();
            this.btnMutex = new System.Windows.Forms.Button();
            this.dgvSemaphore = new System.Windows.Forms.DataGridView();
            this.btnSemaphore = new System.Windows.Forms.Button();
            this.dgvSemaphoreSlim = new System.Windows.Forms.DataGridView();
            this.btnSemaphoreSlim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMutex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemaphore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemaphoreSlim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(12, 12);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(201, 23);
            this.btnLock.TabIndex = 0;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // dgvLock
            // 
            this.dgvLock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLock.Location = new System.Drawing.Point(12, 51);
            this.dgvLock.Name = "dgvLock";
            this.dgvLock.Size = new System.Drawing.Size(201, 387);
            this.dgvLock.TabIndex = 1;
            // 
            // dgvMutex
            // 
            this.dgvMutex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMutex.Location = new System.Drawing.Point(220, 51);
            this.dgvMutex.Name = "dgvMutex";
            this.dgvMutex.Size = new System.Drawing.Size(201, 387);
            this.dgvMutex.TabIndex = 3;
            // 
            // btnMutex
            // 
            this.btnMutex.Location = new System.Drawing.Point(220, 12);
            this.btnMutex.Name = "btnMutex";
            this.btnMutex.Size = new System.Drawing.Size(201, 23);
            this.btnMutex.TabIndex = 2;
            this.btnMutex.Text = "Butex";
            this.btnMutex.UseVisualStyleBackColor = true;
            this.btnMutex.Click += new System.EventHandler(this.btnMutex_Click);
            // 
            // dgvSemaphore
            // 
            this.dgvSemaphore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemaphore.Location = new System.Drawing.Point(427, 51);
            this.dgvSemaphore.Name = "dgvSemaphore";
            this.dgvSemaphore.Size = new System.Drawing.Size(201, 387);
            this.dgvSemaphore.TabIndex = 5;
            // 
            // btnSemaphore
            // 
            this.btnSemaphore.Location = new System.Drawing.Point(427, 12);
            this.btnSemaphore.Name = "btnSemaphore";
            this.btnSemaphore.Size = new System.Drawing.Size(201, 23);
            this.btnSemaphore.TabIndex = 4;
            this.btnSemaphore.Text = "Semaphore";
            this.btnSemaphore.UseVisualStyleBackColor = true;
            this.btnSemaphore.Click += new System.EventHandler(this.btnSemaphore_Click);
            // 
            // dgvSemaphoreSlim
            // 
            this.dgvSemaphoreSlim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemaphoreSlim.Location = new System.Drawing.Point(634, 51);
            this.dgvSemaphoreSlim.Name = "dgvSemaphoreSlim";
            this.dgvSemaphoreSlim.Size = new System.Drawing.Size(201, 387);
            this.dgvSemaphoreSlim.TabIndex = 7;
            // 
            // btnSemaphoreSlim
            // 
            this.btnSemaphoreSlim.Location = new System.Drawing.Point(634, 12);
            this.btnSemaphoreSlim.Name = "btnSemaphoreSlim";
            this.btnSemaphoreSlim.Size = new System.Drawing.Size(201, 23);
            this.btnSemaphoreSlim.TabIndex = 6;
            this.btnSemaphoreSlim.Text = "Semaphore Slim";
            this.btnSemaphoreSlim.UseVisualStyleBackColor = true;
            this.btnSemaphoreSlim.Click += new System.EventHandler(this.btnSemaphoreSlim_Click);
            // 
            // FrmThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.dgvSemaphoreSlim);
            this.Controls.Add(this.btnSemaphoreSlim);
            this.Controls.Add(this.dgvSemaphore);
            this.Controls.Add(this.btnSemaphore);
            this.Controls.Add(this.dgvMutex);
            this.Controls.Add(this.btnMutex);
            this.Controls.Add(this.dgvLock);
            this.Controls.Add(this.btnLock);
            this.Name = "FrmThread";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.FrmThread_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMutex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemaphore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemaphoreSlim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.DataGridView dgvLock;
        private System.Windows.Forms.DataGridView dgvMutex;
        private System.Windows.Forms.Button btnMutex;
        private System.Windows.Forms.DataGridView dgvSemaphore;
        private System.Windows.Forms.Button btnSemaphore;
        private System.Windows.Forms.DataGridView dgvSemaphoreSlim;
        private System.Windows.Forms.Button btnSemaphoreSlim;
    }
}

