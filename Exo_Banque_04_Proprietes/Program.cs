using System;
using Exo_Banque_04_Proprietes.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" ---- Création des différentes personnes ---- ");
        Personne Amandine = new Personne { Nom = "Lottelin", Prenom = "Amandine", DateNaissance = DateTime.Now};
        Console.WriteLine($"La personne {Amandine.Nom} {Amandine.Prenom} a bien été créée. ");

        Console.WriteLine(" ---- Création des différents comptes courants ---- ");
        Courant AmandineCourant = new Courant { Titulaire = Amandine, Numero = "001", LigneDeCredit = 100 };

        Console.WriteLine($"Solde avant dépôt : {AmandineCourant.Solde} du compte de {AmandineCourant.Titulaire.Nom}");
        AmandineCourant.Depot(600);
        Console.WriteLine($"Solde après dépôt : {AmandineCourant.Solde}");
        AmandineCourant.Retrait(800);
        Console.WriteLine($"Solde après premier retrait : {AmandineCourant.Solde}");
        AmandineCourant.Retrait(100);
        Console.WriteLine($"Solde après deuxième retrait : {AmandineCourant.Solde}");
    }
}