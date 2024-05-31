using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque_07_Heritage.Model
{
    internal class Epargne : Compte
    {
        public DateTime DateDernierRetrait { get; private set; }


        public override void Retrait(double montant)
        {
            if( montant > 0 && montant <= Solde )
            { 
                base.Retrait(montant);
                this.DateDernierRetrait = DateTime.Now;
            }

        }



    }
}
