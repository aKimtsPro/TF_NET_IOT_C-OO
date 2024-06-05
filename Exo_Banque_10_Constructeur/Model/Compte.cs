using Exo_Banque_10_Constructeur.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque_10_Constructeur.Model
{
    internal abstract class Compte : ICustomer, IBanker
    {

        protected Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
            
        }

        protected Compte(string numero, Personne titulaire, double solde) : this(numero, titulaire)
        {
            Solde = solde;
        }
        public string Numero { get; private set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; private set; }

        public virtual void Depot(double montant)
        {
            if (montant > 0)
                this.Solde += montant;
        }

        public virtual void Retrait(double montant)
        {
            if (montant > 0)
                this.Solde -= montant;
        }

        public static double operator + (Compte c1, Compte c2)
        {
            double s1 = c1.Solde < 0 ? 0 : c1.Solde;
            double s2 = c2.Solde < 0 ? 0 : c2.Solde;

            return s1 + s2;
        }

        public static double operator + (double solde, Compte c2)
        {
            double s2 = c2.Solde < 0 ? 0 : c2.Solde;

            return solde + s2;
        }

        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        public override string ToString()
        {
            return $"Numero de compte : {Numero}\n" +
                   $"Titulaire : {Titulaire.Prenom} {Titulaire.Nom}\n" +
                   $"Solde : {Solde:F2}";
        }
    }
}
