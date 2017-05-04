namespace JobOverview
{
    partial class FormGestionVersionLogiciel
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
            this.cbox_logiciels = new System.Windows.Forms.ComboBox();
            this.dgv_ModulesVersions = new System.Windows.Forms.DataGridView();
            this.btn_AjoutVersion = new System.Windows.Forms.Button();
            this.btn_suppVersion = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModulesVersions)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_logiciels
            // 
            this.cbox_logiciels.Location = new System.Drawing.Point(36, 25);
            this.cbox_logiciels.Name = "cbox_logiciels";
            this.cbox_logiciels.Size = new System.Drawing.Size(156, 21);
            this.cbox_logiciels.TabIndex = 0;
            // 
            // dgv_ModulesVersions
            // 
            this.dgv_ModulesVersions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ModulesVersions.Location = new System.Drawing.Point(36, 77);
            this.dgv_ModulesVersions.Name = "dgv_ModulesVersions";
            this.dgv_ModulesVersions.Size = new System.Drawing.Size(681, 385);
            this.dgv_ModulesVersions.TabIndex = 1;
            // 
            // btn_AjoutVersion
            // 
            this.btn_AjoutVersion.Location = new System.Drawing.Point(363, 25);
            this.btn_AjoutVersion.Name = "btn_AjoutVersion";
            this.btn_AjoutVersion.Size = new System.Drawing.Size(94, 23);
            this.btn_AjoutVersion.TabIndex = 2;
            this.btn_AjoutVersion.Text = "Ajout Version";
            this.btn_AjoutVersion.UseVisualStyleBackColor = true;
            // 
            // btn_suppVersion
            // 
            this.btn_suppVersion.Location = new System.Drawing.Point(608, 25);
            this.btn_suppVersion.Name = "btn_suppVersion";
            this.btn_suppVersion.Size = new System.Drawing.Size(109, 23);
            this.btn_suppVersion.TabIndex = 3;
            this.btn_suppVersion.Text = "Supprimer Version";
            this.btn_suppVersion.UseVisualStyleBackColor = true;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(484, 25);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(94, 23);
            this.btn_enregistrer.TabIndex = 2;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            // 
            // FormGestionVersionLogiciel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 515);
            this.Controls.Add(this.btn_suppVersion);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_AjoutVersion);
            this.Controls.Add(this.dgv_ModulesVersions);
            this.Controls.Add(this.cbox_logiciels);
            this.Name = "FormGestionVersionLogiciel";
            this.Text = "FormGestionVersionLogiciel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModulesVersions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_logiciels;
        private System.Windows.Forms.DataGridView dgv_ModulesVersions;
        private System.Windows.Forms.Button btn_AjoutVersion;
        private System.Windows.Forms.Button btn_suppVersion;
        private System.Windows.Forms.Button btn_enregistrer;
    }
}