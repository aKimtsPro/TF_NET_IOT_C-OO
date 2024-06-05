using System;
namespace Exo_Banque_09_Interface.Model
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
            if (Solde + LigneDeCredit < Montant) return;

            base.Retrait(Montant);
        }

        protected override double CalculInteret()
        {
            return Solde >= 0 ? Solde * 0.03 : Solde * 0.0975;
        }
    }

}
