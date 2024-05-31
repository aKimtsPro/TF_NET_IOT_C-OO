using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heritage.Models
{
    internal abstract class Vehicule
    {
        public int Puissance { get; set; }
        public string Couleur { get; set; }
        public int KmParcourus { get; private set; }
        public double Reservoir { get; protected set; }
        public double Consommation { get; set; }

        // Vehicule.Rouler(int)
        public virtual void Rouler(int km)
        {
            this.Rouler(km, false);
        }

        // Vehicule.Rouler(int,bool)
        public void Rouler(int km, bool conduiteSport)
        {
            if (km > 0)
            {
                int modifSport = conduiteSport ? 2 : 1;
                this.KmParcourus += km;
                this.Reservoir -= km * modifSport * (Consommation / 100);
            }
        }

        // Vehicule.Rouler(bool,int)
        public void Rouler(bool clim, int km)
        {
            if (km > 0)
            {
                double modifClim = clim ? 1.5 : 1;
                this.KmParcourus += km;
                this.Reservoir -= km * modifClim * (Consommation / 100);
            }
        }

        public abstract void Klaxonner();

        public double FairePlein()
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

        protected static string GetFormatMatricule()
        {
            return "_*_";
        }
    }
}
