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


        public static double operator +( Courant c1, Courant c2 )
        {
            double s1 = c1.Solde < 0 ? 0 : c1.Solde;
            double s2 = c2.Solde < 0 ? 0 : c2.Solde;

            return s1 + s2;
        }
        public static double operator +(double solde, Courant c2)
        {
            double s2 = c2.Solde < 0 ? 0 : c2.Solde;

            return solde + s2;
        }
    }
}
