using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heritage.Models
{
    internal sealed class Voiture : Vehicule
    {
        public int NbrPortes { get; set; }

        public override void Rouler(int km)
        {
            Console.WriteLine("Vroom");
            base.Rouler(km);
        }

        public new double FairePlein()
        {
            // On part du part du principe que le reservoir a max 40L
            double ajout = 40 - Reservoir;
            Reservoir = 40;
            return ajout;
        }

    }
}
