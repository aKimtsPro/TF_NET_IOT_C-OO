using System;
namespace Exo_Banque_07_Heritage.Model
{
    internal class Courant : Compte
    {
        private double _LigneDeCredit;

        // Getters - Setters
        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set
            {
                if (value < 0) return; // Nous viendrons remplacer cette ligne par une exception
                _LigneDeCredit = value;
            }
        }


        public override void Retrait(double Montant)
        {
            if (Solde - Montant < LigneDeCredit) return;

            base.Retrait(Montant);
        }
    }
}
