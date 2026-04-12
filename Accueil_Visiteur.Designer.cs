namespace EcranConnexion
{
    partial class Accueil_Visiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil_Visiteur));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichesPraticiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteRendusDeVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportDeVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem,
            this.saisieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheProduitsToolStripMenuItem,
            this.fichesPraticiensToolStripMenuItem,
            this.compteRendusDeVisiteToolStripMenuItem});
            this.consultationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // ficheProduitsToolStripMenuItem
            // 
            this.ficheProduitsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ficheProduitsToolStripMenuItem.Name = "ficheProduitsToolStripMenuItem";
            this.ficheProduitsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ficheProduitsToolStripMenuItem.Text = "Fiche produits";
            this.ficheProduitsToolStripMenuItem.Click += new System.EventHandler(this.FicheProduitsToolStripMenuItem_Click);
            // 
            // fichesPraticiensToolStripMenuItem
            // 
            this.fichesPraticiensToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fichesPraticiensToolStripMenuItem.Name = "fichesPraticiensToolStripMenuItem";
            this.fichesPraticiensToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.fichesPraticiensToolStripMenuItem.Text = "Fiches praticiens";
            this.fichesPraticiensToolStripMenuItem.Click += new System.EventHandler(this.FichesPraticiensToolStripMenuItem_Click);
            // 
            // compteRendusDeVisiteToolStripMenuItem
            // 
            this.compteRendusDeVisiteToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compteRendusDeVisiteToolStripMenuItem.Name = "compteRendusDeVisiteToolStripMenuItem";
            this.compteRendusDeVisiteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.compteRendusDeVisiteToolStripMenuItem.Text = "Compte-rendus de visite";
            this.compteRendusDeVisiteToolStripMenuItem.Click += new System.EventHandler(this.CompteRendusDeVisiteToolStripMenuItem_Click);
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportDeVisiteToolStripMenuItem});
            this.saisieToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.saisieToolStripMenuItem.Text = "Saisie";
            // 
            // rapportDeVisiteToolStripMenuItem
            // 
            this.rapportDeVisiteToolStripMenuItem.Name = "rapportDeVisiteToolStripMenuItem";
            this.rapportDeVisiteToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.rapportDeVisiteToolStripMenuItem.Text = "Rapport de visite";
            this.rapportDeVisiteToolStripMenuItem.Click += new System.EventHandler(this.RapportDeVisiteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(453, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Accueil_Visiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil_Visiteur";
            this.Text = "Accueil Visiteur";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ficheProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichesPraticiensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteRendusDeVisiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportDeVisiteToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}