using _07_Heritage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heritage.Utils
{
    internal static class VehiculeUtils
    {

        public static void ChangerCouleur(Voiture voiture, string couleur)
        {
            if (voiture == null)
            {
                voiture.Couleur = couleur;
            }
        }

    }
}
