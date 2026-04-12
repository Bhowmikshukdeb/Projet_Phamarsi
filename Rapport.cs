using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace PharmaSI
{
    public class Rapport
    {
        // Les variables qui stockent les infos du rapport
        public int IdRapport { get; set; }
        public string DateRapport { get; set; }
        public string NomPraticien { get; set; }
        public string PrenomPraticien { get; set; }
        public string Motif { get; set; }
        public string Bilan { get; set; }

        // Pour afficher joliment le texte dans la liste déroulante (ComboBox)
        public override string ToString()
        {
            return IdRapport + " - Dr " + NomPraticien + " - " + DateRapport;
        }

        // Fonction pour récupérer TOUS les rapports
        public static List<Rapport> ObtenirTousLesRapports(ConnexionSql maConnexion)
        {
            List<Rapport> liste = new List<Rapport>();
            maConnexion.OpenConnexion();

            string req = "SELECT rv.idRapport, p.nom, rv.dateRapport FROM rapport_visite rv JOIN praticien p ON rv.idPraticien = p.idPraticien";
            MySqlCommand cmd = maConnexion.reqExec(req);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Rapport r = new Rapport();
                r.IdRapport = Convert.ToInt32(reader["idRapport"]);
                r.NomPraticien = reader["nom"].ToString();
                r.DateRapport = reader["dateRapport"].ToString();
                liste.Add(r);
            }

            reader.Close();
            maConnexion.CloseConnexion();
            return liste;
        }

        // Fonction pour récupérer les détails d'un rapport précis
        public void ChargerDetails(ConnexionSql maConnexion)
        {
            maConnexion.OpenConnexion();
            string req = @"SELECT rv.dateRapport, rv.bilan, p.nom, p.prenom, m.libelle
                           FROM rapport_visite rv
                           JOIN praticien p ON rv.idPraticien = p.idPraticien
                           JOIN motif m ON rv.idMotif = m.idMotif
                           WHERE rv.idRapport = @idRapport";

            MySqlCommand cmd = maConnexion.reqExec(req);
            cmd.Parameters.AddWithValue("@idRapport", this.IdRapport);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                this.DateRapport = reader["dateRapport"].ToString();
                this.NomPraticien = reader["nom"].ToString();
                this.PrenomPraticien = reader["prenom"].ToString();
                this.Motif = reader["libelle"].ToString();
                this.Bilan = reader["bilan"].ToString();
            }
            reader.Close();
            maConnexion.CloseConnexion();
        }

        // Fonction pour récupérer les produits offerts
        public List<string> ObtenirProduitsOfferts(ConnexionSql maConnexion)
        {
            List<string> produits = new List<string>();
            maConnexion.OpenConnexion();

            string reqProduits = @"SELECT pr.Nom, o.qteOfferte
                                   FROM offrir o
                                   JOIN produit pr ON o.numProduit = pr.Num
                                   WHERE o.idRapport = @idRapport";

            MySqlCommand cmd = maConnexion.reqExec(reqProduits);
            cmd.Parameters.AddWithValue("@idRapport", this.IdRapport);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                produits.Add(reader["Nom"] + " - Echantillons : " + reader["qteOfferte"]);
            }
            reader.Close();
            maConnexion.CloseConnexion();

            return produits;
        }
    }
}