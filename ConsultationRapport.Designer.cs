
namespace PharmaSI
{
    partial class ConsultationRapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationRapport));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxRapport = new System.Windows.Forms.ComboBox();
            this.listBoxInfos = new System.Windows.Forms.ListBox();
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(674, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // comboBoxRapport
            // 
            this.comboBoxRapport.FormattingEnabled = true;
            this.comboBoxRapport.Location = new System.Drawing.Point(406, 148);
            this.comboBoxRapport.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRapport.Name = "comboBoxRapport";
            this.comboBoxRapport.Size = new System.Drawing.Size(242, 21);
            this.comboBoxRapport.TabIndex = 1;
            // 
            // listBoxInfos
            // 
            this.listBoxInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBoxInfos.FormattingEnabled = true;
            this.listBoxInfos.Location = new System.Drawing.Point(396, 232);
            this.listBoxInfos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxInfos.Name = "listBoxInfos";
            this.listBoxInfos.Size = new System.Drawing.Size(270, 82);
            this.listBoxInfos.TabIndex = 2;
            // 
            // listBoxProduits
            // 
            this.listBoxProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBoxProduits.FormattingEnabled = true;
            this.listBoxProduits.Location = new System.Drawing.Point(396, 341);
            this.listBoxProduits.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProduits.Name = "listBoxProduits";
            this.listBoxProduits.Size = new System.Drawing.Size(270, 82);
            this.listBoxProduits.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choissisez un rapport de visite";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ConsultationRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProduits);
            this.Controls.Add(this.listBoxInfos);
            this.Controls.Add(this.comboBoxRapport);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultationRapport";
            this.Text = "ConsultationRapport";
            this.Load += new System.EventHandler(this.ConsultationRapport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxRapport;
        private System.Windows.Forms.ListBox listBoxInfos;
        private System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.Label label1;
    }
}