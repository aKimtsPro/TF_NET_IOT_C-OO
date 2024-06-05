using Exo_Banque_09_Interface.Interface;
using Exo_Banque_09_Interface.Model;

Banque TFBanque = new Banque() 
{
    Nom = "TFBanque"
};

Personne client1 = new Personne()
{
    Nom = "Doe",
    Prenom = "John",
    DateNaissance = new DateTime(2000,01,01)
};

Personne client2 = new Personne()
{
    Nom = "Doe",
    Prenom = "Jane",
    DateNaissance = new DateTime(2004, 01, 01)
};

Courant courant1 = new Courant()
{
    Numero = "BE00001",
    Titulaire = client1,
    LigneDeCredit = 200

};

Epargne epargne1 = new Epargne()
{
    Numero = "BEE0001",
    Titulaire = client1,

};

Courant courant2 = new Courant()
{
    Numero = "BE00002",
    Titulaire = client2,
    LigneDeCredit = 1000

};

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


