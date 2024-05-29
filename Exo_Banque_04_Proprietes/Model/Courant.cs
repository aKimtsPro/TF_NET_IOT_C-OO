using System;
namespace Exo_Banque_04_Proprietes.Model
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
    }
}
