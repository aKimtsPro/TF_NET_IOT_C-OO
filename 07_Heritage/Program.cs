// See https://aka.ms/new-console-template for more information


using _07_Heritage.Models;

Vehicule v1 = new Vehicule() { Puissance = 100, Couleur = "rouge" };
Moto moto = new Moto() { Puissance= 80, Couleur="vert", NbrRoues=2};
Vehicule v2 = moto;
Object obj = moto;

if (v1 is Moto)
    moto = (Moto)v1;

if ( v2 is Moto m2 )
    moto = m2;




//Console.WriteLine(v1);  // def Vehicule
//Console.WriteLine(moto);// def Moto
//Console.WriteLine(v2);  // def Moto
//Console.WriteLine(obj); // def Moto

