using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeurs
{
    public class Personne
    {
        Random random = new Random();

        public Personne() { }


        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = DateTime.Now;
            Poids = random.Next(2500, 4301);
            SePresenter();
        }

        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaiss { get; set; }
        public double Poids { get; set; }


        private void SePresenter()
        {
            Console.WriteLine($"Bonjour je suis {Prenom} {Nom}, je suis arrivé dans ce monde le {DateNaiss} en pesant {Poids/1000} kg");
        }
    }
}
