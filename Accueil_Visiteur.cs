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
    public partial class Accueil_Visiteur : Form
    {
        private string prenom;
        public Accueil_Visiteur(string prenomUtilisateur)
        {
            InitializeComponent();
            prenom = prenomUtilisateur;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Bonjour " + prenom + " le visiteur !";
        }
        private void FichesPraticiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichePraticien fiche = new FichePraticien();
            fiche.ShowDialog();
            this.Hide();
        }

        private void FicheProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationProduit fiche = new ConsultationProduit();
            fiche.ShowDialog();
            this.Hide();
        }

        private void RapportDeVisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RapportVisite f = new RapportVisite();
            f.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompteRendusDeVisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationRapport c = new ConsultationRapport();
            c.ShowDialog();
        }
    }
}
