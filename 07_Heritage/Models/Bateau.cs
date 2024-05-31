using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heritage.Models
{
    internal class Bateau : Vehicule, INaviguer
    {
        public override void Klaxonner()
        {
            throw new NotImplementedException();
        }
        public int Taille { get; set; }

        public void Naviguer()
        {
            Console.WriteLine("plouf plouf");
        }

        public override string ToString()
        {
            return "C'est un bateau";
        }
    }
}
