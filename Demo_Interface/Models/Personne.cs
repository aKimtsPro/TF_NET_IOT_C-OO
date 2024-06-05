using Demo_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Models
{
    public class Personne : IScout, ILouveteau
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public void FaireUneRando()
        {
            Console.WriteLine("Je vais faire un tour dans les bois");
        }

        public void FaireUnFeu()
        {
            Console.WriteLine("Il faut rassembler des brindilles et frotter du silex");
        }

        public void MonterUnAbri()
        {
            Console.WriteLine("Préparer une structure en bois, ici c'est pas le patro, pas de Queshua");
        }

        public void PreparerLeRepas()
        {
            Console.WriteLine("Mettre la nourriture sur le feu");
        }
    }
}
