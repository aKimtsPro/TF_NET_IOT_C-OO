using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exceptions.Models
{
    public class Utilisateur
    {
        public Utilisateur(string nom, string prenom, string email, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Age = age;
        }

        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
