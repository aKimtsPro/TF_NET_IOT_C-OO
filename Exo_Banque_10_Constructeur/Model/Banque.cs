
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque_10_Constructeur.Model
{
    internal class Banque
    {
        public string Nom { get; set; }
        private readonly Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>();

        public Compte this[string key]
        {
            get
            {
                _comptes.TryGetValue(key, out Compte compte);
                return compte;
                //return _comptes[key];
            }
        }

        public void Ajouter(Compte compte)
        {
            if( !_comptes.ContainsKey(compte.Numero) )
            {
                _comptes.Add(compte.Numero, compte);
            }
        }


        public void Supprimer(string numero)
        {
            _comptes.Remove(numero);
        }


        public double AvoirDesComptes(Personne titulaire)
        {
            double rslt = 0;

            foreach( Compte compte in _comptes.Values )
            {
                if( compte.Titulaire == titulaire )
                {
                    rslt = rslt + compte;
                }
            }

            return rslt;
        }

        public void Interet()
        {
            foreach (KeyValuePair<string,Compte> compte in _comptes)
            {
                compte.Value.AppliquerInteret();
            }
        }

    }
}
