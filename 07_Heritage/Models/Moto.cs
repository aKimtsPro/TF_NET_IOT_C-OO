using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heritage.Models
{
    internal class Moto : Vehicule
    {
        public int NbrRoues { get; set; }

        public override string ToString()
        {
            return $"Moto{{Puissance: {Puissance}; Couleur: {Couleur}; KmParcourus: {KmParcourus}, NbrRoues: {NbrRoues}}}";
        }

        public override void Rouler(int km)
        {
            base.Rouler(5*km);
        }
    }
}
