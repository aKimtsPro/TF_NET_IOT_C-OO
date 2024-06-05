using Demo_Constructeurs;

Personne personne = new Personne("Doe", "John");

Thread.Sleep(1000);

Personne personne2 = new Personne("Smith", "Paul"); 


Personne etudiant = new Etudiant("Willis", "Bruce", new DateTime(1975,05,01), 000001);
Personne etudiant2 = new Etudiant("Willis", "Bruce", 000001);

Console.WriteLine(etudiant.GetType()); // Type est Etudiant

using(Etudiant e = new Etudiant("Milano", "Alyssa", 000002))
{
    Console.WriteLine(e.Nom);
}


Console.ReadLine();