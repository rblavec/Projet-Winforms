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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // cbPers
            // 
            this.cbPers.FormattingEnabled = true;
            this.cbPers.Location = new System.Drawing.Point(37, 53);
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
            // FormGestionTachesProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 470);
            this.Controls.Add(this.btAjouTache);
            this.Controls.Add(this.cbPers);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionTachesProduct";
            this.Text = "FormGestionTachesProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPers;
        private System.Windows.Forms.Button btAjouTache;
    }
}