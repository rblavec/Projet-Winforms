﻿namespace JobOverview
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
            this.dgvTacheProd = new System.Windows.Forms.DataGridView();
            this.cbLogiciel = new System.Windows.Forms.ComboBox();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.Logiciel = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.chk_termine = new System.Windows.Forms.CheckBox();
            this.btAjouTache = new System.Windows.Forms.Button();
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
            this.cbPers.Size = new System.Drawing.Size(169, 21);
            this.cbPers.TabIndex = 1;
            // 
            // dgvTacheProd
            // 
            this.dgvTacheProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacheProd.Location = new System.Drawing.Point(12, 129);
            this.dgvTacheProd.Name = "dgvTacheProd";
            this.dgvTacheProd.Size = new System.Drawing.Size(639, 246);
            this.dgvTacheProd.TabIndex = 3;
            // 
            // cbLogiciel
            // 
            this.cbLogiciel.FormattingEnabled = true;
            this.cbLogiciel.Location = new System.Drawing.Point(244, 50);
            this.cbLogiciel.Name = "cbLogiciel";
            this.cbLogiciel.Size = new System.Drawing.Size(172, 21);
            this.cbLogiciel.TabIndex = 4;
            // 
            // cbVersion
            // 
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(486, 50);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(165, 21);
            this.cbVersion.TabIndex = 5;
            // 
            // Logiciel
            // 
            this.Logiciel.AutoSize = true;
            this.Logiciel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Logiciel.Location = new System.Drawing.Point(241, 34);
            this.Logiciel.Name = "Logiciel";
            this.Logiciel.Size = new System.Drawing.Size(43, 13);
            this.Logiciel.TabIndex = 6;
            this.Logiciel.Text = "Logiciel";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Version.Location = new System.Drawing.Point(483, 34);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(42, 13);
            this.Version.TabIndex = 7;
            this.Version.Text = "Version";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(12, 410);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(245, 23);
            this.tbDescription.TabIndex = 8;
            // 
            // chk_termine
            // 
            this.chk_termine.Location = new System.Drawing.Point(12, 94);
            this.chk_termine.Name = "chk_termine";
            this.chk_termine.Size = new System.Drawing.Size(111, 17);
            this.chk_termine.TabIndex = 0;
            this.chk_termine.Text = "Tâches terminées";
            this.chk_termine.UseVisualStyleBackColor = true;
            // 
            // btAjouTache
            // 
            this.btAjouTache.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouTache.Location = new System.Drawing.Point(12, 451);
            this.btAjouTache.Name = "btAjouTache";
            this.btAjouTache.Size = new System.Drawing.Size(137, 23);
            this.btAjouTache.TabIndex = 2;
            this.btAjouTache.Text = "Nouvelle Tache";
            this.btAjouTache.UseVisualStyleBackColor = true;
            // 
            // FormGestionTachesProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 496);
            this.Controls.Add(this.chk_termine);
            this.Controls.Add(this.tbDescription);
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
        private System.Windows.Forms.DataGridView dgvTacheProd;
        private System.Windows.Forms.ComboBox cbLogiciel;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.Label Logiciel;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.CheckBox chk_termine;
        private System.Windows.Forms.Button btAjouTache;
    }
}