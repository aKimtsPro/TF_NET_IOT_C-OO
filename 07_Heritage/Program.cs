﻿using _07_Heritage.Models;
using _07_Heritage.Utils;

//Vehicule v1 = new Vehicule() { Puissance = 100, Couleur = "rouge" };
//Moto moto = new Moto() { Puissance = 80, Couleur = "vert", NbrRoues = 2 };
//Vehicule v2 = moto;
//Object obj = moto;

//if (v1 is Moto)
//    moto = (Moto)v1;

//if (v2 is Moto m2)
//    moto = m2;

//Console.WriteLine(v1);  // def Vehicule
//Console.WriteLine(moto);// def Moto
//Console.WriteLine(v2);  // def Moto
//Console.WriteLine(obj); // def Moto


//Vehicule vehicule1 = new Vehicule();
//Voiture voiture = new Voiture();
//Vehicule vehicule2 = new Voiture();

//Console.WriteLine(vehicule1.FairePlein());  // 20
//Console.WriteLine(voiture.FairePlein());    // 40
//Console.WriteLine(vehicule2.FairePlein());  // 20


//vehicule1.Rouler(15);
//vehicule1.Rouler(15, true);
//vehicule1.Rouler(true, 15);

string format = Voiture.GetFormatMatricule();

Parking p1 = Parking.Instance;
Parking p2 = Parking.Instance;
Parking p3 = Parking.Instance;
Parking p4 = Parking.Instance;
Parking p5 = Parking.Instance;

if( p1 == p2 && p1 == p3 && p1 == p4 && p1== p5 )
    Console.WriteLine("les mêmes");

INaviguer naviguer = new Bateau();
INaviguer naviguer2 = new JetSki();

Console.WriteLine( naviguer.ToString() );
Console.WriteLine( naviguer2.ToString() );

List<INaviguer> list = new List<INaviguer>();

list.Add(naviguer);
list.Add(naviguer2);


