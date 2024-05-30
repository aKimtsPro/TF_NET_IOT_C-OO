// See https://aka.ms/new-console-template for more information
using _06_SurchargeOperateurs;

Frigo f1 = new Frigo();
f1.Ajouter(new Nourriture() { Nom = "banane", Quantite = 3, Unite = "unité" });

Frigo f2 = new Frigo();
f2.Ajouter(new Nourriture() { Nom = "Lait", Quantite = 0.75, Unite = "litre" });


//Frigo f3 = f1.Ajouter(f2);
Frigo f3 = f1 + f2;

Frigo f4 = f3 - f2;

if(f4 - f1)
{
    Console.WriteLine("pas vide");
}
else
{
    Console.WriteLine("vide");
}