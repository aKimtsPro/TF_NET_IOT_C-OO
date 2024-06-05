using System;

namespace Exo_Banque_10_Constructeur.Model
{
    internal class Personne
    {
        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public string Nom {  get; private set; }
        public string Prenom { get; private set; }
        public DateTime DateNaissance { get; private set; }
    }
}
