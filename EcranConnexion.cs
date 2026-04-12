using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text;          // Pour StringBuilder et Encoding
using System.Security.Cryptography;

namespace EcranConnexion
{
    public partial class EcranConnexion : Form
    {
        private string provider = "localhost";
        private string dataBase = "ppe";
        private string uid = "root";
        private string mdp = "Mypassword";

        private ConnexionSql maConnexionSql;
        private MySqlCommand maRequete;

        public EcranConnexion()
        {
            InitializeComponent(); 
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }

            private void Button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string motdepasse = txtMdp.Text;

            // Déclarer les ressources ICI pour qu'elles soient accessibles dans le bloc 'finally'
            MySqlDataReader reader = null;
            ConnexionSql maConnexionSql = null; // Remis à null pour être sûr

            try
            {
                // 1. Connexion
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.OpenConnexion();

                string motdepasseHash = HashPassword(motdepasse);

                // 2. Requête et paramètres
                string req = @"
    SELECT employe.prenom, employe.nom, libelle FROM employe
    INNER JOIN grade ON employe.id = grade.id
    WHERE id_connexion = @login AND mdp_connexion = @mdp";

                maRequete = maConnexionSql.reqExec(req);
                maRequete.Parameters.AddWithValue("@login", login);
                maRequete.Parameters.AddWithValue("@mdp", motdepasse);

                // 3. Exécution du DataReader
                reader = maRequete.ExecuteReader();

                if (reader.Read())
                {
                    // Logique de succès : Affichage et ouverture du nouveau formulaire
                    string nom = reader.GetString("nom");
                    string prenom = reader.GetString("prenom");
                    string libelle = reader.GetString("libelle");

                    reader.Close(); // Ceci libère la connexion Singleton
                    reader = null;

                    if (libelle == "Visiteur") {
                        Accueil_Visiteur accvisi = new Accueil_Visiteur(prenom);
                        this.Hide();
                        accvisi.ShowDialog();
                    }

                    else if (libelle == "delegue regional") {
                        Accueil_DelegReg accdel = new Accueil_DelegReg(prenom);
                        this.Hide();
                        accdel.ShowDialog();
                    }
                    else if (libelle == "responsable secteur") {
                        Accueil_RespSec accresp = new Accueil_RespSec(prenom);
                        this.Hide();
                        accresp.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bonjour " + prenom + ", vous êtes " + libelle + " et ne pouvez pas vous connecter.");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur login/mot de passe invalide. Connexion impossible ! ");
                }

                // 4. NOTE IMPORTANTE : Les lignes de fermeture sont déplacées dans le 'finally'
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                // 5. FERMETURE GARANTIE (MÊME EN CAS D'EXCEPTION)

                // Fermeture du DataReader s'il a été ouvert
                if (reader != null)
                {
                    reader.Close();
                }

                // Fermeture de la connexion s'il a été instanciée (et si elle est ouverte)
                if (maConnexionSql != null)
                {
                    // Vous n'avez pas besoin de vérifier l'état ici si ConnexionSql est bien faite,
                    // mais c'est une bonne pratique.
                    maConnexionSql.CloseConnexion();
                }
            }
        }

        private void TxtMdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 