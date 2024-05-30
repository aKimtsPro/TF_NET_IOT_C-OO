using Exo_Banque_04_Proprietes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque_05_Indexeurs.Model
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

    }
}
