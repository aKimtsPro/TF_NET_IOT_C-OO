using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque_11_Exceptions.Model
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
            if( montant > 0 && SoldeSuffissant(montant) )
            { 
                base.Retrait(montant);
                this.DateDernierRetrait = DateTime.Now;
            }

        }

        protected override bool SoldeSuffissant(double montant)
        {
            return montant <= Solde;
        }

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }


    }
}
