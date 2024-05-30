using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heritage.Models
{
    internal class Vehicule
    {

        public int Puissance { get; set; }
        public string Couleur { get; set; }
        public int KmParcourus { get; private set; }
        
        public void Rouler(int km)
        {
            if (km > 0)
                this.KmParcourus += km;
        }

        public override string ToString()
        {
            return $"Vehicule{{Puissance: {Puissance}; Couleur: {Couleur}; KmParcourus: {KmParcourus}}}";
        }
    }
}
