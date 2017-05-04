namespace JobOverview
{
    partial class FormSaisieVersion
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.txt_NumeroVersion = new System.Windows.Forms.TextBox();
            this.txt_millesime = new System.Windows.Forms.TextBox();
            this.txt_DateSortiePrevue = new System.Windows.Forms.TextBox();
            this.txt_DateOuverture = new System.Windows.Forms.TextBox();
            this.txt_version = new System.Windows.Forms.Label();
            this.lbl_Millesime = new System.Windows.Forms.Label();
            this.lbl_DateOuverture = new System.Windows.Forms.Label();
            this.lbl_datePrevue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(157, 208);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "Ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Annuler.Location = new System.Drawing.Point(248, 208);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuler.TabIndex = 0;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            // 
            // txt_NumeroVersion
            // 
            this.txt_NumeroVersion.Location = new System.Drawing.Point(133, 16);
            this.txt_NumeroVersion.Name = "txt_NumeroVersion";
            this.txt_NumeroVersion.Size = new System.Drawing.Size(190, 20);
            this.txt_NumeroVersion.TabIndex = 1;
            // 
            // txt_millesime
            // 
            this.txt_millesime.Location = new System.Drawing.Point(133, 59);
            this.txt_millesime.Name = "txt_millesime";
            this.txt_millesime.Size = new System.Drawing.Size(122, 20);
            this.txt_millesime.TabIndex = 1;
            // 
            // txt_DateSortiePrevue
            // 
            this.txt_DateSortiePrevue.Location = new System.Drawing.Point(133, 145);
            this.txt_DateSortiePrevue.Name = "txt_DateSortiePrevue";
            this.txt_DateSortiePrevue.Size = new System.Drawing.Size(122, 20);
            this.txt_DateSortiePrevue.TabIndex = 1;
            // 
            // txt_DateOuverture
            // 
            this.txt_DateOuverture.Location = new System.Drawing.Point(133, 103);
            this.txt_DateOuverture.Name = "txt_DateOuverture";
            this.txt_DateOuverture.Size = new System.Drawing.Size(122, 20);
            this.txt_DateOuverture.TabIndex = 1;
            // 
            // txt_version
            // 
            this.txt_version.AutoSize = true;
            this.txt_version.Location = new System.Drawing.Point(13, 22);
            this.txt_version.Name = "txt_version";
            this.txt_version.Size = new System.Drawing.Size(108, 13);
            this.txt_version.TabIndex = 2;
            this.txt_version.Text = "Numéro de la Version";
            // 
            // lbl_Millesime
            // 
            this.lbl_Millesime.AutoSize = true;
            this.lbl_Millesime.Location = new System.Drawing.Point(72, 66);
            this.lbl_Millesime.Name = "lbl_Millesime";
            this.lbl_Millesime.Size = new System.Drawing.Size(49, 13);
            this.lbl_Millesime.TabIndex = 2;
            this.lbl_Millesime.Text = "Millesime";
            // 
            // lbl_DateOuverture
            // 
            this.lbl_DateOuverture.AutoSize = true;
            this.lbl_DateOuverture.Location = new System.Drawing.Point(35, 110);
            this.lbl_DateOuverture.Name = "lbl_DateOuverture";
            this.lbl_DateOuverture.Size = new System.Drawing.Size(86, 13);
            this.lbl_DateOuverture.TabIndex = 2;
            this.lbl_DateOuverture.Text = "Date d\'ouverture";
            // 
            // lbl_datePrevue
            // 
            this.lbl_datePrevue.AutoSize = true;
            this.lbl_datePrevue.Location = new System.Drawing.Point(13, 152);
            this.lbl_datePrevue.Name = "lbl_datePrevue";
            this.lbl_datePrevue.Size = new System.Drawing.Size(109, 13);
            this.lbl_datePrevue.TabIndex = 2;
            this.lbl_datePrevue.Text = "Date de sortie prévue";
            // 
            // FormSaisieVersion
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btn_Annuler;
            this.ClientSize = new System.Drawing.Size(344, 259);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_datePrevue);
            this.Controls.Add(this.lbl_DateOuverture);
            this.Controls.Add(this.lbl_Millesime);
            this.Controls.Add(this.txt_version);
            this.Controls.Add(this.txt_DateSortiePrevue);
            this.Controls.Add(this.txt_DateOuverture);
            this.Controls.Add(this.txt_millesime);
            this.Controls.Add(this.txt_NumeroVersion);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_OK);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormSaisieVersion";
            this.Text = "FormSaisieVersion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.TextBox txt_NumeroVersion;
        private System.Windows.Forms.TextBox txt_millesime;
        private System.Windows.Forms.TextBox txt_DateSortiePrevue;
        private System.Windows.Forms.TextBox txt_DateOuverture;
        private System.Windows.Forms.Label txt_version;
        private System.Windows.Forms.Label lbl_Millesime;
        private System.Windows.Forms.Label lbl_DateOuverture;
        private System.Windows.Forms.Label lbl_datePrevue;
    }
}