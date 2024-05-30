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
        public double Reservoir { get; protected set; }
        public double Consommation { get; set; }

        public virtual void Rouler(int km)
        {
            if (km > 0)
            {
                this.KmParcourus += km;
                this.Reservoir -= km * (Consommation / 100);
            }
        }

        public  double FairePlein()
        {
            // On part du part du principe que le reservoir a max 20L
            double ajout = 20 - this.Reservoir;
            this.Reservoir = 20;
            return ajout;
        } 

        // sealed vient bloquer les overrides chez les enfants suivants.
        public /*sealed*/ override string ToString()
        {
            return $"Vehicule{{Puissance: {Puissance}; Couleur: {Couleur}; KmParcourus: {KmParcourus}}}";
        }
    }
}
