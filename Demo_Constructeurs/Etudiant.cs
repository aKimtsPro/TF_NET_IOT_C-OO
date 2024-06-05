using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeurs
{
    public class Etudiant : Personne, IDisposable
    {
        public Etudiant(string nom, string prenom, DateTime dateNaiss, int idEcole) : base(nom, prenom, dateNaiss) 
        {
            IdEcole = idEcole;
        }

        public Etudiant(string nom, string prenom, int idEcole)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = DateTime.Now;
            IdEcole = idEcole;
        }
        public int IdEcole {  get; set; }

        public void Dispose()
        {
        }
    }
}
