namespace JobOverview
{
    partial class FormGestionTachesProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPers = new System.Windows.Forms.ComboBox();
            this.btAjouTache = new System.Windows.Forms.Button();
            this.dgvTacheProd = new System.Windows.Forms.DataGridView();
            this.cbLogiciel = new System.Windows.Forms.ComboBox();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.Logiciel = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacheProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // cbPers
            // 
            this.cbPers.FormattingEnabled = true;
            this.cbPers.Location = new System.Drawing.Point(12, 50);
            this.cbPers.Name = "cbPers";
            this.cbPers.Size = new System.Drawing.Size(121, 21);
            this.cbPers.TabIndex = 1;
            // 
            // btAjouTache
            // 
            this.btAjouTache.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouTache.Location = new System.Drawing.Point(37, 422);
            this.btAjouTache.Name = "btAjouTache";
            this.btAjouTache.Size = new System.Drawing.Size(137, 23);
            this.btAjouTache.TabIndex = 2;
            this.btAjouTache.Text = "Nouvelle Tache";
            this.btAjouTache.UseVisualStyleBackColor = true;
            // 
            // dgvTacheProd
            // 
            this.dgvTacheProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacheProd.Location = new System.Drawing.Point(12, 96);
            this.dgvTacheProd.Name = "dgvTacheProd";
            this.dgvTacheProd.Size = new System.Drawing.Size(601, 305);
            this.dgvTacheProd.TabIndex = 3;
            // 
            // cbLogiciel
            // 
            this.cbLogiciel.FormattingEnabled = true;
            this.cbLogiciel.Location = new System.Drawing.Point(156, 50);
            this.cbLogiciel.Name = "cbLogiciel";
            this.cbLogiciel.Size = new System.Drawing.Size(121, 21);
            this.cbLogiciel.TabIndex = 4;
            // 
            // cbVersion
            // 
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(299, 50);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(121, 21);
            this.cbVersion.TabIndex = 5;
            // 
            // Logiciel
            // 
            this.Logiciel.AutoSize = true;
            this.Logiciel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Logiciel.Location = new System.Drawing.Point(160, 34);
            this.Logiciel.Name = "Logiciel";
            this.Logiciel.Size = new System.Drawing.Size(43, 13);
            this.Logiciel.TabIndex = 6;
            this.Logiciel.Text = "Logiciel";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Version.Location = new System.Drawing.Point(301, 34);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(42, 13);
            this.Version.TabIndex = 7;
            this.Version.Text = "Version";
            // 
            // FormGestionTachesProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 470);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Logiciel);
            this.Controls.Add(this.cbVersion);
            this.Controls.Add(this.cbLogiciel);
            this.Controls.Add(this.dgvTacheProd);
            this.Controls.Add(this.btAjouTache);
            this.Controls.Add(this.cbPers);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionTachesProduct";
            this.Text = "FormGestionTachesProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacheProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPers;
        private System.Windows.Forms.Button btAjouTache;
        private System.Windows.Forms.DataGridView dgvTacheProd;
        private System.Windows.Forms.ComboBox cbLogiciel;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.Label Logiciel;
        private System.Windows.Forms.Label Version;
    }
}