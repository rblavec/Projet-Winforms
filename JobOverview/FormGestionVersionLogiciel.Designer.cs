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
            this.dgv_modules = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModulesVersions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modules)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_logiciels
            // 
            this.cbox_logiciels.Location = new System.Drawing.Point(12, 27);
            this.cbox_logiciels.Name = "cbox_logiciels";
            this.cbox_logiciels.Size = new System.Drawing.Size(156, 21);
            this.cbox_logiciels.TabIndex = 0;
            // 
            // dgv_ModulesVersions
            // 
            this.dgv_ModulesVersions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ModulesVersions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ModulesVersions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ModulesVersions.Location = new System.Drawing.Point(12, 274);
            this.dgv_ModulesVersions.Name = "dgv_ModulesVersions";
            this.dgv_ModulesVersions.Size = new System.Drawing.Size(561, 126);
            this.dgv_ModulesVersions.TabIndex = 1;
            // 
            // btn_AjoutVersion
            // 
            this.btn_AjoutVersion.Location = new System.Drawing.Point(12, 417);
            this.btn_AjoutVersion.Name = "btn_AjoutVersion";
            this.btn_AjoutVersion.Size = new System.Drawing.Size(94, 23);
            this.btn_AjoutVersion.TabIndex = 2;
            this.btn_AjoutVersion.Text = "Ajout Version";
            this.btn_AjoutVersion.UseVisualStyleBackColor = true;
            // 
            // btn_suppVersion
            // 
            this.btn_suppVersion.Location = new System.Drawing.Point(464, 417);
            this.btn_suppVersion.Name = "btn_suppVersion";
            this.btn_suppVersion.Size = new System.Drawing.Size(109, 23);
            this.btn_suppVersion.TabIndex = 3;
            this.btn_suppVersion.Text = "Supprimer Version";
            this.btn_suppVersion.UseVisualStyleBackColor = true;
            // 
            // dgv_modules
            // 
            this.dgv_modules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_modules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_modules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modules.Location = new System.Drawing.Point(12, 97);
            this.dgv_modules.Name = "dgv_modules";
            this.dgv_modules.Size = new System.Drawing.Size(561, 126);
            this.dgv_modules.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Liste des Logiciels :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liste des Modules :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(9, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liste des Versions :";
            // 
            // FormGestionVersionLogiciel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_modules);
            this.Controls.Add(this.btn_suppVersion);
            this.Controls.Add(this.btn_AjoutVersion);
            this.Controls.Add(this.dgv_ModulesVersions);
            this.Controls.Add(this.cbox_logiciels);
            this.Name = "FormGestionVersionLogiciel";
            this.Text = "FormGestionVersionLogiciel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModulesVersions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_logiciels;
        private System.Windows.Forms.DataGridView dgv_ModulesVersions;
        private System.Windows.Forms.Button btn_AjoutVersion;
        private System.Windows.Forms.Button btn_suppVersion;
        private System.Windows.Forms.DataGridView dgv_modules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}