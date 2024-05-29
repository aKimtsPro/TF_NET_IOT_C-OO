using System;

namespace _04_Propriété
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Personne Gabriel = new Personne 
            { 
                Nom = "Glesner", 
                Prenom = "Gabriel", 
                DateNaissance = new DateTime(1995, 02, 02) 
            };

            Console.WriteLine($"{Gabriel.Prenom} {Gabriel.Nom} {Gabriel.Age}");

            Gabriel.DireBonjour();


        }
    }
}