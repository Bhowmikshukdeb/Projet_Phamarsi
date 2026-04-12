using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaSI;

namespace EcranConnexion
{
    public partial class Accueil_DelegReg : Form
    {
        private string prenom;
        public Accueil_DelegReg(string prenomUtilisateur)
        {
            prenom = prenomUtilisateur;
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = "Bonjour " + prenom + " le délégué régional !";
        }
        private void fichesPraticiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichePraticien fiche = new FichePraticien();
            fiche.ShowDialog();
        }

        private void FichesProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationProduit fiche = new ConsultationProduit();
            fiche.ShowDialog();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RapportDeVisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RapportVisite f = new RapportVisite();
            f.ShowDialog();
        }

        private void CompterendusVisitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationRapport c = new ConsultationRapport();
            c.ShowDialog();
        }
    }
}