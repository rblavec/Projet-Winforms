﻿namespace JobOverview
{
	partial class MDIForm
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.menuGestionVersionLogiciels = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesVersionsDeLogicielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeneral
            // 
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestionVersionLogiciels,
            this.menu2,
            this.menuWindows});
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(787, 24);
            this.menuGeneral.TabIndex = 0;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // menuGestionVersionLogiciels
            // 
            this.menuGestionVersionLogiciels.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesVersionsDeLogicielsToolStripMenuItem});
            this.menuGestionVersionLogiciels.Name = "menuGestionVersionLogiciels";
            this.menuGestionVersionLogiciels.Size = new System.Drawing.Size(188, 20);
            this.menuGestionVersionLogiciels.Text = "Gestion des versions de logiciels";
            // 
            // menu2
            // 
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(56, 20);
            this.menu2.Text = "Menu2";
            // 
            // menuWindows
            // 
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(63, 20);
            this.menuWindows.Text = "Fenêtres";
            // 
            // gestionDesVersionsDeLogicielsToolStripMenuItem
            // 
            this.gestionDesVersionsDeLogicielsToolStripMenuItem.Name = "gestionDesVersionsDeLogicielsToolStripMenuItem";
            this.gestionDesVersionsDeLogicielsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 514);
            this.Controls.Add(this.menuGeneral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGeneral;
            this.Name = "MDIForm";
            this.Text = "JobOverview";
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuGeneral;
		private System.Windows.Forms.ToolStripMenuItem menuGestionVersionLogiciels;
		private System.Windows.Forms.ToolStripMenuItem menuWindows;
		private System.Windows.Forms.ToolStripMenuItem menu2;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVersionsDeLogicielsToolStripMenuItem;
    }
}

