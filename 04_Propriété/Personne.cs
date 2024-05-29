using System;

namespace _04_Propriété
{
    internal class Personne
    {
        // Accesseur => Accèder à la donnée => Getter
        // Mutateur => Modifier la donnée => Setter

        // Full-properties
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
            // Lambda expression, permet de raccourcir le code mais au risque de le rendre
            // moins facilement lisible
            // set => _nom = value;
        }

        // Auto-properties
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        // Auto-properties en lecture seule
        // Ne retourne que l'âge en fonction de la date de naissance fournie
        public int Age 
        { 
            get => (int)(DateTime.Today - DateNaissance).TotalDays / 365; 
        }

        // Même chose mais avec une lambda
        // public int Age => (int)(DateTime.Today - DateNaissance).TotalDays / 365;

        public void Marcher()
        {
            Console.WriteLine("Je marche...");
        }

        public void DireBonjour()
        {
            Console.WriteLine($"{Nom} {Prenom} dit bonjour");
        }

    }
}
