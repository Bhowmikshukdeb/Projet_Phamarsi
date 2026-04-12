using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EcranConnexion
{
    public partial class ConsultationProduit : Form
    {
        private string provider = "localhost";
        private string dataBase = "ppe";
        private string uid = "root";
        private string mdp = "Mypassword";

        private ConnexionSql maConnexionSql;
        private MySqlCommand maRequete;

        public ConsultationProduit()
        {
            InitializeComponent();
            ChargerListeProduits();
        }

        // -------------------------------------------------------------
        // 1️⃣ Charger les produits dans le ComboBox
        // -------------------------------------------------------------
        private void ChargerListeProduits()
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.OpenConnexion();

                string req = "SELECT Num, Nom FROM produit";
                maRequete = new MySqlCommand(req, maConnexionSql.getSqlConnexion());
                MySqlDataReader reader = maRequete.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(new
                    {
                        Id = reader.GetInt32("Num"),
                        Nom = reader.GetString("Nom")
                    });
                }

                comboBox1.DisplayMember = "Nom";
                comboBox1.ValueMember = "Id";

                reader.Close();
                maConnexionSql.CloseConnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement produits : " + ex.Message);
            }
        }

        // -------------------------------------------------------------
        // 3️⃣ Récupérer toutes les infos d’un produit
        // -------------------------------------------------------------
        private void AfficherInfosProduit(int idProduit)
        {
            listBox1.Items.Clear();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.OpenConnexion();

                string reqInfo = @"
            SELECT p.Num, p.Nom, p.PrixEchantillons, p.Effets,
                   p.ContreIndication, f.libelle AS Famille,
                   p.Num_Produit
            FROM produit p
            LEFT JOIN famille f ON f.idFamille = p.idFamille
            WHERE p.Num = @id";

                maRequete = maConnexionSql.reqExec(reqInfo);
                maRequete.Parameters.AddWithValue("@id", idProduit);

                MySqlDataReader reader = maRequete.ExecuteReader();

                int num = 0;
                string nom = "", famille = "", effets = "", ci = "", interactions = "";
                decimal prix = 0;
                int? parentProduit = null;

                if (reader.Read())
                {
                    num = reader.GetInt32("Num");
                    nom = reader.GetString("Nom");
                    effets = reader.GetString("Effets");
                    prix = reader.GetDecimal("PrixEchantillons");
                    famille = reader["Famille"] != DBNull.Value ? reader.GetString("Famille") : "Aucune";
                    ci = reader["ContreIndication"] != DBNull.Value ? reader.GetString("ContreIndication") : "Aucune";
                    parentProduit = reader["Num_Produit"] != DBNull.Value ? reader.GetInt32("Num_Produit") : (int?)null;
                }
                else
                {
                    MessageBox.Show("Produit introuvable.");
                    reader.Close();
                    return;
                }

                reader.Close();

                // -------- Interactions (effets du parent) ----------
                if (parentProduit != null)
                {
                    string reqInter = "SELECT Effets FROM produit WHERE Num = @pid";
                    maRequete = maConnexionSql.reqExec(reqInter);
                    maRequete.Parameters.AddWithValue("@pid", parentProduit);

                    reader = maRequete.ExecuteReader();
                    if (reader.Read())
                        interactions = reader.GetString("Effets");
                    reader.Close();
                }
                else
                {
                    interactions = "Aucune interaction connue";
                }

                // -------- AFFICHAGE --------
                listBox1.Items.Add("Numéro : " + num);
                listBox1.Items.Add("Nom : " + nom);
                listBox1.Items.Add("Famille : " + famille);
                listBox1.Items.Add("Prix échantillon : " + prix + " €");
                listBox1.Items.Add("Effets : " + effets);
                listBox1.Items.Add("Contre-indications : " + ci);
                listBox1.Items.Add("Interactions : " + interactions);
                listBox1.Items.Add("----- COMPOSANTS -----");

                // -------- Composants --------
                string reqComp = @"
            SELECT c.libelle, ct.QteComp
            FROM contient ct
            JOIN composant c ON c.id = ct.id
            WHERE ct.Num = @id";

                maRequete = maConnexionSql.reqExec(reqComp);
                maRequete.Parameters.AddWithValue("@id", idProduit);

                reader = maRequete.ExecuteReader();

                while (reader.Read())
                {
                    string comp = reader.GetString("libelle");
                    int qte = reader.GetInt32("QteComp");
                    listBox1.Items.Add($"{comp} : {qte} mg");
                }

                reader.Close();
                maConnexionSql.CloseConnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur consultation : " + ex.Message);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un produit !");
                return;
            }

            dynamic selected = comboBox1.SelectedItem;
            int idProduit = selected.Id;

            AfficherInfosProduit(idProduit);
        }

        private void ConsultationProduit_Load(object sender, EventArgs e)
        {

        }
    }
}
