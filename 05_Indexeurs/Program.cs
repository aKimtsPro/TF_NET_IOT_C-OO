using System;
using _05_Indexeurs.Models;

// Instanciation d'un nouveau Deck
Deck deck = new Deck();

// Remplissage de notre deck avec nos cartes
deck.InitDeck();

// Création d'un tableau de 7 cartes 
Card[] main = new Card[7];

// Remplissage de notre main avec les premières cartes du deck
for (int i = 0; i < main.Length; i++)
{
    // Utilisation de l'indexeur de Deck pour récupérer la carte à l'index 0 et la supprimer du deck
    main[i] = deck[0];
}

// Itération de notre main pour afficher les cartes y étant
foreach(Card card in main)
{
    Console.WriteLine($"Le {card.Valeur} de {card.Couleur}");
}

// Remplacement de la cinquième carte dans la main par la carte dame de trèfle
// Utilisation de l'indexeur pour récupérer et supprimer la carte Dame de Trefle du deck
main[4] = deck[Couleurs.Trefle, Valeurs.Dame];

// Itération de notre main pour afficher la nouvelle carte
foreach (Card card in main)
{
    Console.WriteLine($"Le {card.Valeur} de {card.Couleur}");
}