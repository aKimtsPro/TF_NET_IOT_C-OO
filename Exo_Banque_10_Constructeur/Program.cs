using Exo_Banque_10_Constructeur.Interface;
using Exo_Banque_10_Constructeur.Model;

Banque TFBanque = new Banque()
{
    Nom = "TFBanque"
};

Personne client1 = new Personne("Doe", "John", new DateTime(2000, 01, 01));
Personne client2 = new Personne("Doe", "Jane", new DateTime(2004, 01, 01));

Courant courant1 = new Courant(200, "BE00001", client1);
Epargne epargne1 = new Epargne("BEE0001", client1);
Courant courant2 = new Courant(1000, "BE00002", client2);

TFBanque.Ajouter(courant1);
TFBanque.Ajouter(courant2);
TFBanque.Ajouter(epargne1);

TFBanque["BE00001"].Depot(200);
TFBanque["BE00002"].Depot(500);
TFBanque["BEE0001"].Depot(300);

TFBanque["BE00001"].Retrait(300);

// Methode AvoirDesComptes

Console.WriteLine("Total des avoirs : " + TFBanque.AvoirDesComptes(client1));

// Appliquer les interets

TFBanque.Interet();

//TFBanque["BE00001"].AppliquerInteret();
//TFBanque["BEE0001"].AppliquerInteret();

Console.WriteLine("Total des avoirs : " + TFBanque.AvoirDesComptes(client1));

// Interfaces

IBanker banker = TFBanque["BE00001"];
banker.Depot(200);
banker.Retrait(50);
banker.AppliquerInteret();

ICustomer customer = TFBanque["BE00001"];
customer.Depot(200);
customer.Retrait(100);

Console.WriteLine(TFBanque["BE00001"].ToString());


