using System;
namespace Exo_Banque_06_Proprietes.Model
{
    internal class Courant
    {
        private string _Numero;
        private double _Solde;
        private double _LigneDeCredit;
        private Personne _Titulaire;

        // Getters - Setters
        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public double Solde
        {
            get { return _Solde; }
            private set { _Solde = value; }
        }

        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set
            {
                if (value < 0) return; // Nous viendrons remplacer cette ligne par une exception

                _LigneDeCredit = value;
            }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            set { _Titulaire = value; }
        }

        public void Retrait(double Montant)
        {
            if (Montant <= 0) return; // Nous viendrons remplacer cette ligne par une exception

            if (Solde - Montant < LigneDeCredit) return;

            Solde -= Montant;
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0) return; // Nous viendrons remplacer cette ligne par une exception

            Solde += Montant;
        }


        public static double operator + ( Courant c1, Courant c2 )
        {
            double s1 = c1.Solde < 0 ? 0 : c1._Solde;
            double s2 = c2.Solde < 0 ? 0 : c2._Solde;

            return s1 + s2;
        }
        public static double operator +(double solde, Courant c2)
        {
            double s2 = c2._Solde < 0 ? 0 : c2._Solde;

            return solde + s2;
        }
    }
}
