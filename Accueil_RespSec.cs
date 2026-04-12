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
    public partial class Accueil_RespSec : Form
    {
        public string prenom;
        public Accueil_RespSec(string prenomUtilisateur)
        {
            prenom = prenomUtilisateur;
            InitializeComponent();
        }

        private void FichePraticiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichePraticien fiche = new FichePraticien();
            fiche.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label3.Text = "Bonjour " + prenom + " le responsable secteur !";
        }

        private void FicheproduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationProduit fiche = new ConsultationProduit();
            fiche.ShowDialog();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComptesrendusDeVisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationRapport c = new ConsultationRapport();
            c.ShowDialog();
        }
    }
}
