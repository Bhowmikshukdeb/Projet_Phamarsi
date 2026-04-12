using System;
using System.Collections.Generic;

namespace EcranConnexion
{
    public class Praticien
    {
        // Propriétés de base du praticien
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Cp { get; set; }
        public string Ville { get; set; }
        public decimal Notoriete { get; set; }
        public string TypePraticien { get; set; } // Nom du type (ex: 'Médecin Généraliste')

        // Collection pour les spécialités formatées (incluant le coefficient dans la chaîne)
        public List<string> Specialites { get; set; }

        // Constructeur
        public Praticien()
        {
            Specialites = new List<string>();
        }

        // Propriété calculée utile pour le ComboBox d'affichage (Nom Prenom)
        public string NomPrenom => $"{Nom} {Prenom}";
    }
}