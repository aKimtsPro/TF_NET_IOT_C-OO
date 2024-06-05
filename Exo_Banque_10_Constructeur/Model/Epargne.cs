using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque_10_Constructeur.Model
{
    internal class Epargne : Compte
    {
        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Epargne(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
        }

        public DateTime DateDernierRetrait { get; private set; }


        public override void Retrait(double montant)
        {
            if( montant > 0 && montant <= Solde )
            { 
                base.Retrait(montant);
                this.DateDernierRetrait = DateTime.Now;
            }

        }

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }


    }
}
