using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EcranConnexion
{
    public partial class RapportVisite : Form
    {

        private string provider = "localhost";
        private string dataBase = "ppe";
        private string uid = "root";
        private string mdp = "Mypassword";

        private ConnexionSql maConnexionSql;
        private MySqlCommand maRequete;

        public RapportVisite()
        {
            InitializeComponent();

            ChargerPraticiens();
            ChargerProduits();
            ChargerMotifs();

            btnValider.Click += btnValider_Click;
            btnAnnuler.Click += btnAnnuler_Click;
            button2.Click += Button2_Click;

        }

        // ==============================
        // CHARGEMENT PRATICIENS
        // ==============================

        private void ChargerPraticiens()
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.OpenConnexion();

                string req = "SELECT idPraticien, CONCAT(nom,' ',prenom) AS nomComplet FROM praticien";
                maRequete = maConnexionSql.reqExec(req);

                MySqlDataReader reader = maRequete.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                cmbPraticien.DataSource = table;
                cmbPraticien.DisplayMember = "nomComplet";
                cmbPraticien.ValueMember = "idPraticien";
                cmbPraticien.SelectedIndex = -1;

                reader.Close();
                maConnexionSql.CloseConnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==============================
        // CHARGEMENT PRODUITS
        // ==============================

        private void ChargerProduits()
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.OpenConnexion();

                string req = "SELECT Num, Nom FROM produit";
                maRequete = maConnexionSql.reqExec(req);

                MySqlDataReader reader = maRequete.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                cmbProduit1.DataSource = table.Copy();
                cmbProduit1.DisplayMember = "Nom";
                cmbProduit1.ValueMember = "Num";
                cmbProduit1.SelectedIndex = -1;

                cmbProduit2.DataSource = table;
                cmbProduit2.DisplayMember = "Nom";
                cmbProduit2.ValueMember = "Num";
                cmbProduit2.SelectedIndex = -1;

                reader.Close();
                maConnexionSql.CloseConnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==============================
        // CHARGEMENT MOTIFS
        // ==============================

        private void ChargerMotifs()
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.OpenConnexion();

                string req = "SELECT idMotif, libelle FROM motif";
                maRequete = maConnexionSql.reqExec(req);

                MySqlDataReader reader = maRequete.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                cmbMotif.DataSource = table;
                cmbMotif.DisplayMember = "libelle";
                cmbMotif.ValueMember = "idMotif";
                cmbMotif.SelectedIndex = -1;

                reader.Close();
                maConnexionSql.CloseConnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ==============================
        // BOUTON VALIDER
        // ==============================

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification des champs obligatoires
                if (cmbPraticien.SelectedIndex == -1 || cmbMotif.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez sélectionner un praticien et un motif.");
                    return;
                }

                // Connexion
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.OpenConnexion();

                int visiteurId = 2; // ID du visiteur connecté

                // Insertion du rapport
                string reqRapport = @"INSERT INTO rapport_visite
                              (dateRapport, bilan, idPraticien, idVisiteur, idMotif)
                              VALUES (@date, @bilan, @praticien, @visiteur, @motif)";
                maRequete = maConnexionSql.reqExec(reqRapport);
                maRequete.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                maRequete.Parameters.AddWithValue("@bilan", txtBilan.Text);
                maRequete.Parameters.AddWithValue("@praticien", cmbPraticien.SelectedValue);
                maRequete.Parameters.AddWithValue("@visiteur", visiteurId);
                maRequete.Parameters.AddWithValue("@motif", cmbMotif.SelectedValue);

                maRequete.ExecuteNonQuery();

                int idRapport = (int)maRequete.LastInsertedId;

                // Ajout des produits
                AjouterProduit(idRapport, cmbProduit1, numQte1);
                AjouterProduit(idRapport, cmbProduit2, numQte2);

                maConnexionSql.CloseConnexion();

                MessageBox.Show("Rapport enregistré avec succès !");
                this.Close(); // <-- fermer le formulaire
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        // ==============================
        // AJOUT PRODUITS
        // ==============================

        private void AjouterProduit(int idRapport, ComboBox combo, NumericUpDown num)
        {
            if (combo.SelectedValue != null && num.Value > 0)
            {
                string req = @"INSERT INTO offrir
                              (idRapport, numProduit, qteOfferte)
                              VALUES (@idRapport, @numProduit, @qte)";

                maRequete = maConnexionSql.reqExec(req);
                maRequete.Parameters.AddWithValue("@idRapport", idRapport);
                maRequete.Parameters.AddWithValue("@numProduit", combo.SelectedValue);
                maRequete.Parameters.AddWithValue("@qte", num.Value);
                maRequete.ExecuteNonQuery();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
                // Réinitialiser les ComboBox
                cmbPraticien.SelectedIndex = -1;
                cmbMotif.SelectedIndex = -1;
                cmbProduit1.SelectedIndex = -1;
                cmbProduit2.SelectedIndex = -1;

                // Réinitialiser les NumericUpDown
                numQte1.Value = 0;
                numQte2.Value = 0;

                // Réinitialiser le TextBox
                txtBilan.Clear();

                // Réinitialiser le DateTimePicker à aujourd'hui
                dtpDate.Value = DateTime.Today;
            }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                // Optionnel : confirmation
                DialogResult result = MessageBox.Show(
                    "Voulez-vous vraiment vous déconnecter ?",
                    "Déconnexion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Fermer la fenêtre actuelle
                    this.Hide();

                    // Ouvrir l'écran de connexion
                    EcranConnexion loginForm = new EcranConnexion();
                    loginForm.Show();

                    // Fermer le formulaire courant lorsqu'on quitte l'écran de connexion
                    loginForm.FormClosed += (s, args) => this.Close();
                }
            }
        }

    }
 }
