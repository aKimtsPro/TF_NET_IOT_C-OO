using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heritage.Models
{
    internal class JetSki : Moto, INaviguer //, Bateau // Impossible, pas d'Heritage multiple
    {
        public void Naviguer()
        {
            Console.WriteLine("Plif plouf");
        }
    }
}
