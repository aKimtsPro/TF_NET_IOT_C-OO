
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque_07_Heritage.Model
{
    internal class Banque
    {
        public string Nom { get; set; }
        private readonly Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();

        
        public Courant this[string key]
        {
            get
            {
                return _comptes[key];
            }
        }

        public void Ajouter(Courant courant)
        {
            if( !_comptes.ContainsKey(courant.Numero) )
            {
                _comptes.Add(courant.Numero, courant);
            }
        }

        public void Supprimer(string numero)
        {
            _comptes.Remove(numero);
        }


        public double AvoirDesComptes(Personne titulaire)
        {
            double rslt = 0;

            foreach( Courant compte in _comptes.Values )
            {
                if( compte.Titulaire == titulaire )
                {
                    rslt += compte;
                }
            }

            return rslt;
        }

    }
}
