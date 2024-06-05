using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque_11_Exceptions.Exceptions
{
    internal class SoldeInsuffisantException : ArgumentException
    {
        public double SoldeCourant { get; private set; }
        

        public SoldeInsuffisantException(double solde) : base("Solde insuffisant") {
            this.SoldeCourant = solde;
        }
    }
}
