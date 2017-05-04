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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_version = new System.Windows.Forms.Label();
            this.txt_millesime = new System.Windows.Forms.Label();
            this.txt_DateOuverture = new System.Windows.Forms.Label();
            this.txt_DateSortiePrevue = new System.Windows.Forms.Label();
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(133, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 20);
            this.textBox4.TabIndex = 1;
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
            // txt_millesime
            // 
            this.txt_millesime.AutoSize = true;
            this.txt_millesime.Location = new System.Drawing.Point(72, 66);
            this.txt_millesime.Name = "txt_millesime";
            this.txt_millesime.Size = new System.Drawing.Size(49, 13);
            this.txt_millesime.TabIndex = 2;
            this.txt_millesime.Text = "Millesime";
            // 
            // txt_DateOuverture
            // 
            this.txt_DateOuverture.AutoSize = true;
            this.txt_DateOuverture.Location = new System.Drawing.Point(35, 110);
            this.txt_DateOuverture.Name = "txt_DateOuverture";
            this.txt_DateOuverture.Size = new System.Drawing.Size(86, 13);
            this.txt_DateOuverture.TabIndex = 2;
            this.txt_DateOuverture.Text = "Date d\'ouverture";
            // 
            // txt_DateSortiePrevue
            // 
            this.txt_DateSortiePrevue.AutoSize = true;
            this.txt_DateSortiePrevue.Location = new System.Drawing.Point(13, 152);
            this.txt_DateSortiePrevue.Name = "txt_DateSortiePrevue";
            this.txt_DateSortiePrevue.Size = new System.Drawing.Size(109, 13);
            this.txt_DateSortiePrevue.TabIndex = 2;
            this.txt_DateSortiePrevue.Text = "Date de sortie prévue";
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
            this.Controls.Add(this.txt_DateSortiePrevue);
            this.Controls.Add(this.txt_DateOuverture);
            this.Controls.Add(this.txt_millesime);
            this.Controls.Add(this.txt_version);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txt_version;
        private System.Windows.Forms.Label txt_millesime;
        private System.Windows.Forms.Label txt_DateOuverture;
        private System.Windows.Forms.Label txt_DateSortiePrevue;
    }
}