using System;
using System.Collections.Generic;

namespace EcranConnexion
{
    public class Produit
    {
        // Propriétés de base du praticien
        public int NumProd { get; set; }
        public string NomCommercial { get; set; }
        public string Famille { get; set; }
        public decimal Prix { get; set; }
        public string Effets { get; set; }
        public string CI { get; set; }
        public string Interactions { get; set; }

        // Collection pour les spécialités formatées (incluant le coefficient dans la chaîne)
        public List<(string composant, int qte)> Composants { get; set; }
        // Constructeur
        public Produit()
        {
            Composants = new List<(string, int)>();
        }
    }
}