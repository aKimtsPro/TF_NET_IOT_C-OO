using Exo_Banque_04_Proprietes.Model;
using Exo_Banque_05_Indexeurs.Model;

Banque banque = new Banque() { Nom= "ma banque" };

Personne Amandine = new Personne { Nom = "Lottelin", Prenom = "Amandine", DateNaissance = DateTime.Now };
Courant courant = new Courant() { Numero = "1", Titulaire=Amandine };

banque.Ajouter(courant);

Courant courant1 = banque[Console.ReadLine()];
