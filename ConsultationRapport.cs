using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PharmaSI
{
    public partial class ConsultationRapport : Form
    {
        ConnexionSql maConnexion;

        public ConsultationRapport()
        {
            InitializeComponent();
            // On prépare la connexion à la base de données
            maConnexion = ConnexionSql.getInstance("localhost", "ppe", "root", "Mypassword");
        }

        private void ConsultationRapport_Load(object sender, EventArgs e)
        {
            ChargerRapports();
        }

        // On remplit la liste déroulante au démarrage
        private void ChargerRapports()
        {
            comboBoxRapport.Items.Clear();

            try
            {
                // Ici, le nom de la fonction correspond EXACTEMENT à la classe Rapport
                List<Rapport> tousLesRapports = Rapport.ObtenirTousLesRapports(maConnexion);

                foreach (Rapport r in tousLesRapports)
                {
                    comboBoxRapport.Items.Add(r);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Souci de connexion : " + ex.Message);
            }
        }

        // Quand on clique sur le bouton Valider
        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (comboBoxRapport.SelectedItem == null)
            {
                MessageBox.Show("Sélectionnez un rapport d'abord, s'il vous plaît.");
                return;
            }

            // On vide l'écran avant d'afficher les nouvelles infos
            listBoxInfos.Items.Clear();
            listBoxProduits.Items.Clear();

            try
            {
                Rapport rapportChoisi = (Rapport)comboBoxRapport.SelectedItem;

                // On demande à la classe de chercher les détails
                rapportChoisi.ChargerDetails(maConnexion);

                // On affiche les infos
                listBoxInfos.Items.Add("Date : " + rapportChoisi.DateRapport);
                listBoxInfos.Items.Add("Praticien : " + rapportChoisi.PrenomPraticien + " " + rapportChoisi.NomPraticien);
                listBoxInfos.Items.Add("Motif : " + rapportChoisi.Motif);
                listBoxInfos.Items.Add("Bilan : " + rapportChoisi.Bilan);

                // Ici aussi, le nom de la fonction correspond EXACTEMENT
                List<string> listeProduits = rapportChoisi.ObtenirProduitsOfferts(maConnexion);

                foreach (string produit in listeProduits)
                {
                    listBoxProduits.Items.Add(produit);
                }

                if (listBoxProduits.Items.Count == 0)
                {
                    listBoxProduits.Items.Add("Aucun produit offert cette fois-ci.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }
    }
}