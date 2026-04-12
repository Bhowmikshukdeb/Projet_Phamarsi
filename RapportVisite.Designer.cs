namespace EcranConnexion
{
    partial class RapportVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RapportVisite));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPraticien = new System.Windows.Forms.ComboBox();
            this.cmbMotif = new System.Windows.Forms.ComboBox();
            this.cmbProduit1 = new System.Windows.Forms.ComboBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.numQte1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProduit2 = new System.Windows.Forms.ComboBox();
            this.numQte2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQte2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(334, 67);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(182, 20);
            this.dtpDate.TabIndex = 0;
            // 
            // cmbPraticien
            // 
            this.cmbPraticien.FormattingEnabled = true;
            this.cmbPraticien.Location = new System.Drawing.Point(334, 109);
            this.cmbPraticien.Name = "cmbPraticien";
            this.cmbPraticien.Size = new System.Drawing.Size(182, 21);
            this.cmbPraticien.TabIndex = 1;
            this.cmbPraticien.Text = "Choisissez un particien";
            // 
            // cmbMotif
            // 
            this.cmbMotif.FormattingEnabled = true;
            this.cmbMotif.Location = new System.Drawing.Point(334, 149);
            this.cmbMotif.Name = "cmbMotif";
            this.cmbMotif.Size = new System.Drawing.Size(182, 21);
            this.cmbMotif.TabIndex = 2;
            this.cmbMotif.Text = "Choisissez un motif";
            // 
            // cmbProduit1
            // 
            this.cmbProduit1.FormattingEnabled = true;
            this.cmbProduit1.Location = new System.Drawing.Point(334, 237);
            this.cmbProduit1.Name = "cmbProduit1";
            this.cmbProduit1.Size = new System.Drawing.Size(182, 21);
            this.cmbProduit1.TabIndex = 3;
            this.cmbProduit1.Text = "Choisissez un premier produit";
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(334, 189);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(182, 42);
            this.txtBilan.TabIndex = 5;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.LightGreen;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(244, 416);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(83, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(395, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Réinitialiser";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Red;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(540, 416);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(83, 23);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Fermer";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // numQte1
            // 
            this.numQte1.Location = new System.Drawing.Point(334, 335);
            this.numQte1.Name = "numQte1";
            this.numQte1.Size = new System.Drawing.Size(182, 20);
            this.numQte1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(331, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre d\'échantillons";
            // 
            // cmbProduit2
            // 
            this.cmbProduit2.FormattingEnabled = true;
            this.cmbProduit2.Location = new System.Drawing.Point(334, 264);
            this.cmbProduit2.Name = "cmbProduit2";
            this.cmbProduit2.Size = new System.Drawing.Size(221, 21);
            this.cmbProduit2.TabIndex = 11;
            this.cmbProduit2.Text = "Choisissez un deuxième produit si besoin";
            // 
            // numQte2
            // 
            this.numQte2.Location = new System.Drawing.Point(334, 361);
            this.numQte2.Name = "numQte2";
            this.numQte2.Size = new System.Drawing.Size(182, 20);
            this.numQte2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(233, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Saissisez une date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(231, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Choisir un praticien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(231, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Choissisez un motif";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.Location = new System.Drawing.Point(202, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Saisir votre bilan de visite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label6.Location = new System.Drawing.Point(183, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Choissisez un premier produit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Location = new System.Drawing.Point(128, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Choissisez un deuxième produit si besoin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label8.Location = new System.Drawing.Point(249, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Premier produit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label9.Location = new System.Drawing.Point(239, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Deuxième produit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(753, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Se déconnecter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numQte2);
            this.Controls.Add(this.cmbProduit2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numQte1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.cmbProduit1);
            this.Controls.Add(this.cmbMotif);
            this.Controls.Add(this.cmbPraticien);
            this.Controls.Add(this.dtpDate);
            this.Name = "RapportVisite";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numQte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQte2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbPraticien;
        private System.Windows.Forms.ComboBox cmbMotif;
        private System.Windows.Forms.ComboBox cmbProduit1;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.NumericUpDown numQte1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProduit2;
        private System.Windows.Forms.NumericUpDown numQte2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}