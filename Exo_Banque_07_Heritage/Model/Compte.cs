using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque_07_Heritage.Model
{
    internal class Compte
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }

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
    }
}
