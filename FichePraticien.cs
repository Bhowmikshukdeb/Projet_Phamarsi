 using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Globalization;
using System.Linq;

namespace EcranConnexion
{
    public partial class FichePraticien : Form
    {
        private List<Praticien> listePraticiens;

        public FichePraticien()
        {
            InitializeComponent();
            this.Load += FichePraticien_Load;
            this.button1.Click += btnValider_Click; // Assure que le bouton est lié
        }

        private void FichePraticien_Load(object sender, EventArgs e)
        {
            ChargerListePraticiens();
        }
        private void ChargerListePraticiens()
        {
            listePraticiens = new List<Praticien>();
            ConnexionSql maConnexionSql = null;
            MySqlDataReader reader = null;

            try
            {
                maConnexionSql = ConnexionSql.getInstance("localhost", "ppe", "root", "Mypassword");
                maConnexionSql.OpenConnexion();

                string requete = "SELECT idPraticien, nom, prenom FROM Praticien ORDER BY nom, prenom;";
                MySqlCommand maRequete = maConnexionSql.reqExec(requete);
                reader = maRequete.ExecuteReader();

                while (reader.Read())
                {
                    Praticien p = new Praticien
                    {
                        Id = reader.GetInt32(0),
                        Nom = reader.GetString(1),
                        Prenom = reader.GetString(2)
                    };
                    listePraticiens.Add(p);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des praticiens : {ex.Message}");
            }
            finally
            {
                if (reader != null) reader.Close();
                if (maConnexionSql != null) maConnexionSql.CloseConnexion();
            }
            comboBox1.DataSource = listePraticiens;
            comboBox1.DisplayMember = "NomPrenom";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;
        }

        private Praticien GetPraticienComplet(int idPraticien)
        {
            Praticien lePraticien = null;
            ConnexionSql maConnexionSql = null;
            MySqlDataReader reader = null;

            string reqComplete = "SELECT p.idPraticien, p.nom, p.prenom, p.adresse, p.cp, p.ville, p.coeffNotoriete, t.libelle AS TypePraticien, s.libelle AS Specialite, a.coeffPrescription " +
                                 "FROM Praticien p " +
                                 "JOIN TypePraticien t ON p.idTypePraticien = t.idTypePraticien " +
                                 "LEFT JOIN AvoirSpecialite a ON p.idPraticien = a.idPraticien " +
                                 "LEFT JOIN Specialite s ON a.idSpecialite = s.idSpecialite " +
                                 $"WHERE p.idPraticien = {idPraticien};";

            try
            {
                maConnexionSql = ConnexionSql.getInstance("localhost", "votre_base_de_donnees", "root", "votre_mdp");
                maConnexionSql.OpenConnexion();

                MySqlCommand cmdComplete = maConnexionSql.reqExec(reqComplete);
                reader = cmdComplete.ExecuteReader();

                bool isFirstRow = true;

                while (reader.Read())
                {
                    if (isFirstRow)
                    {
                        // Instanciation de l'objet Praticien (une seule fois)
                        lePraticien = new Praticien
                        {
                            Id = reader.GetInt32(0),
                            Nom = reader.GetString(1),
                            Prenom = reader.GetString(2),
                            Adresse = reader.GetString(3),
                            Cp = reader.GetString(4),
                            Ville = reader.GetString(5),
                            Notoriete = reader.GetDecimal(6),
                            TypePraticien = reader.GetString(7)
                        };
                        isFirstRow = false;
                    }

                    // Ajout des Spécialités (toutes les lignes, vérification si la colonne n'est pas NULL)
                    if (!reader.IsDBNull(8))
                    {
                        string libelle = reader.GetString(8);
                        decimal coeff = reader.GetDecimal(9);

                        // Création de la chaîne formatée
                        string specialiteFormatee = $"{libelle} (Coef. Prescription: {coeff.ToString("0.00", CultureInfo.InvariantCulture)})";
                        lePraticien.Specialites.Add(specialiteFormatee);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération de la fiche : {ex.Message}");
                lePraticien = null;
            }
            finally
            {
                if (reader != null) reader.Close();
                if (maConnexionSql != null) maConnexionSql.CloseConnexion();
            }

            return lePraticien;
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            // Vérifie qu'un élément est sélectionné dans le ComboBox
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un praticien.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupère l'objet Praticien (avec l'ID) sélectionné dans le ComboBox
            Praticien selectionne = (Praticien)comboBox1.SelectedItem;
            int idPraticien = selectionne.Id;

            // Récupération de la fiche complète
            Praticien ficheComplete = GetPraticienComplet(idPraticien);

            if (ficheComplete != null)
            {
                listBox1.Items.Clear(); // Nettoyage de la ListBox

                // Ajout des informations principales
                listBox1.Items.Add($"Nom: {ficheComplete.Nom} {ficheComplete.Prenom}");
                listBox1.Items.Add($"Adresse: {ficheComplete.Adresse}, {ficheComplete.Cp} {ficheComplete.Ville}");
                listBox1.Items.Add($"Type de Praticien: {ficheComplete.TypePraticien}");
                listBox1.Items.Add($"Coefficient de Notoriété: {ficheComplete.Notoriete.ToString("0.00")}");
                listBox1.Items.Add("-------------------------------------");
                listBox1.Items.Add("Spécialités / Diplômes (avec Coef.) :");

                // Ajout de la liste des spécialités
                if (ficheComplete.Specialites.Any())
                {
                    foreach (string spec in ficheComplete.Specialites)
                    {
                        listBox1.Items.Add(spec);
                    }
                }
                else
                {
                    listBox1.Items.Add("Aucune spécialité enregistrée.");
                }
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Erreur : Impossible de charger les données du praticien.");
            }
        }
    }
}