using System;

namespace _02_Encapsulation
{
    // Encapsulation par défaut dans un namespace : internal
    // Types d'encapsulation possible : public ou internal

    // Encapsulation par défaut dans une classe : private
    // Encapsulations possible dans une classe : 
    // - public
    // - protected
    // - internal
    // - protected internal
    // - private
    // - private protected

    internal class Program
    {
        private static void Main(string[] args)
        {
            var alain = new Personne();
            alain.nom = "Mathy";
            alain.prenom = "Alain";
            alain.dateNaissance = new DateTime(2000, 01, 01);
            alain.DireBonjour();
            alain.Marcher();

            Console.WriteLine($"{alain.nom} {alain.prenom} {alain.dateNaissance}");

            var nasser = new Personne();
            nasser.nom = "Tariki";
            nasser.prenom = "Nasser";
            nasser.DireBonjour();

            Console.WriteLine($"{nasser.nom} {nasser.prenom}");
        }
    }
}