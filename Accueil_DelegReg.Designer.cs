namespace EcranConnexion
{
    partial class Accueil_DelegReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil_DelegReg));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichesProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichesPratitensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compterendusVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportDeVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieToolStripMenuItem,
            this.saisieToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(996, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichesProduitToolStripMenuItem,
            this.fichesPratitensToolStripMenuItem,
            this.compterendusVisitesToolStripMenuItem});
            this.saisieToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.saisieToolStripMenuItem.Text = "Consultation";
            // 
            // fichesProduitToolStripMenuItem
            // 
            this.fichesProduitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.fichesProduitToolStripMenuItem.Name = "fichesProduitToolStripMenuItem";
            this.fichesProduitToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.fichesProduitToolStripMenuItem.Text = "Fiches Produit";
            this.fichesProduitToolStripMenuItem.Click += new System.EventHandler(this.FichesProduitToolStripMenuItem_Click);
            // 
            // fichesPratitensToolStripMenuItem
            // 
            this.fichesPratitensToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.fichesPratitensToolStripMenuItem.Name = "fichesPratitensToolStripMenuItem";
            this.fichesPratitensToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.fichesPratitensToolStripMenuItem.Text = "Fiches Praticiens";
            this.fichesPratitensToolStripMenuItem.Click += new System.EventHandler(this.fichesPraticiensToolStripMenuItem_Click);
            // 
            // compterendusVisitesToolStripMenuItem
            // 
            this.compterendusVisitesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.compterendusVisitesToolStripMenuItem.Name = "compterendusVisitesToolStripMenuItem";
            this.compterendusVisitesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.compterendusVisitesToolStripMenuItem.Text = "Compte-rendus de visite";
            this.compterendusVisitesToolStripMenuItem.Click += new System.EventHandler(this.CompterendusVisitesToolStripMenuItem_Click);
            // 
            // saisieToolStripMenuItem1
            // 
            this.saisieToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportDeVisiteToolStripMenuItem});
            this.saisieToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.saisieToolStripMenuItem1.Name = "saisieToolStripMenuItem1";
            this.saisieToolStripMenuItem1.Size = new System.Drawing.Size(66, 22);
            this.saisieToolStripMenuItem1.Text = "Saisie";
            // 
            // rapportDeVisiteToolStripMenuItem
            // 
            this.rapportDeVisiteToolStripMenuItem.Name = "rapportDeVisiteToolStripMenuItem";
            this.rapportDeVisiteToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.rapportDeVisiteToolStripMenuItem.Text = "Rapport de visite";
            this.rapportDeVisiteToolStripMenuItem.Click += new System.EventHandler(this.RapportDeVisiteToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(341, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(447, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Accueil_DelegReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil_DelegReg";
            this.Text = "Accueil Délégué Régional";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fichesProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichesPratitensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compterendusVisitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportDeVisiteToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}