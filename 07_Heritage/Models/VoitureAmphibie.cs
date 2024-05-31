using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heritage.Models
{
    internal class VoitureAmphibie : Vehicule, IAmphibie // ,IRouler, INaviguer
    {
        public void Naviguer()
        {
            Console.WriteLine("Plouf plif");
        }

        public override void Klaxonner()
        {
            Console.WriteLine("Klaxon aquatique mais terrestre quand même");
        }

    }
}
