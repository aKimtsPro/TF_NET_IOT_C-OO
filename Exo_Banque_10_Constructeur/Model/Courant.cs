using System;
namespace Exo_Banque_10_Constructeur.Model
{
    internal class Courant : Compte
    {
        public Courant(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Courant(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
        }

        public Courant(double ligneDeCredit, string numero, Personne titulaire) :  base(numero, titulaire)
        {
            _LigneDeCredit = ligneDeCredit;
        }


        private double _LigneDeCredit;


        // Getters - Setters
        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            private set
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
