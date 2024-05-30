using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SurchargeOperateurs
{
    internal class Frigo
    {
        private readonly Dictionary<string, Nourriture> _contenu = new Dictionary<string, Nourriture>();

        public void Ajouter(Nourriture nourriture)
        {
            if( _contenu.ContainsKey(nourriture.Nom) )
            {
                Nourriture existing = this._contenu[nourriture.Nom];
                existing.Quantite += nourriture.Quantite;
            }
            else
            {
                _contenu.Add(nourriture.Nom, nourriture);
            }
        }


        public void Retirer(Nourriture nourriture)
        {

            if( _contenu.ContainsKey( nourriture.Nom ) )
            {
                Nourriture existing = this._contenu[nourriture.Nom];

                if( existing.Quantite > nourriture.Quantite)
                {
                    existing.Quantite -= nourriture.Quantite;
                }
                else
                {
                    existing.Quantite = 0;
                    _contenu.Remove(existing.Nom);
                }
            }

        }

        public Frigo Ajouter(Frigo frigo)
        {
            Frigo frigoRslt = new Frigo();
            foreach (Nourriture item in this._contenu.Values)
            {
                frigoRslt.Ajouter(item);
            }

            foreach (Nourriture item in frigo._contenu.Values)
            {
                frigoRslt.Ajouter(item);
            }

            return frigoRslt;
        }

        public static Frigo operator + (Frigo avantPlus, Frigo apresPlus)
        {
            return avantPlus.Ajouter(apresPlus);

            //Frigo frigoRslt = new Frigo();
            //foreach (Nourriture item in avantPlus._contenu.Values)
            //{
            //    frigoRslt.Ajouter(item);
            //}

            //foreach (Nourriture item in apresPlus._contenu.Values)
            //{
            //    frigoRslt.Ajouter(item);
            //}

            //return frigoRslt;
        }

        public static Frigo operator - (Frigo avantMoins,  Frigo apresMoins)
        {
            Frigo fRslt = new Frigo();

            foreach (Nourriture item in avantMoins._contenu.Values)
            {
                fRslt.Ajouter(item);
            }


            foreach (Nourriture item in apresMoins._contenu.Values)
            {
                fRslt.Retirer(item);
            }

            return fRslt;
        }

        public static bool operator true (Frigo frigo)
        {
            return frigo._contenu.Count != 0; 
        }

        public static bool operator false (Frigo frigo)
        {
            return frigo._contenu.Count == 0;
        }
    }
}
