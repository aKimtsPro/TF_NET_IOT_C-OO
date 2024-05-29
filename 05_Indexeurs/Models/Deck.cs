using System;
using System.Collections.Generic;

namespace _05_Indexeurs.Models
{
    internal class Deck
    {
        // Instanciation d'une nouvelle liste privée de type Card
        private readonly List<Card> _deck = new List<Card>();

        // Indexeur qui va permettre d'accèder aux cartes via un index
        // Cet indexeur va donc nous permettre de manipuler la liste _deck comme un véritable tableau
        public Card this[int index]
        {
            // Déclaration du getter pour récupérer une carte à un index i
            get
            {
                Card c = null;

                // Vérification si l'index reçu est dans les limites de la liste
                if (index < _deck.Count && index >= 0)
                {
                    // Récupération de la carte à l'index reçu et suppression de la carte dans le deck
                    c = _deck[index];
                    _deck.Remove(c);
                }

                // Return la carte ou null si mauvais index
                return c;
            }
            // Déclaration du setter pour définir une carte à un index i
            set
            {
                // Vérification si l'index reçu est dans les limites de la liste
                if (index < _deck.Count && index >= 0)
                {
                    // Mise à jour de la carte à l'index reçu
                    _deck[index] = value;
                } else
                {
                    // Ajout de la carte à la fin de la liste 
                    _deck.Add(value);
                }
            }
        }

        // Deuxième indexeur qui va nous permettre d'accèder aux cartes via une combinaison de couleur / valeur
        public Card this[Couleurs couleur, Valeurs valeur]
        {
            // Déclaration du getter pour récupérer la carte correspondant à la couleur et la valeur reçues
            get
            {
                Card c = null;

                // Itération dans la liste des cartes
                for (int i = 0; i < _deck.Count; i++)
                {
                    // Si une carte correspond à la couleur et la valeur, on la récupère et on la supprime du deck
                    if (_deck[i].Couleur == couleur && _deck[i].Valeur == valeur)
                    {
                        c = _deck[i];
                        _deck.Remove(c);
                        break; 
                    }
                }

                return c;
            }

            // Déclaration du setter pour définir une carte correspondant à une couleur et une valeur reçues
            set
            {
                Card c = null;

                // Itération dans la liste de cartes
                foreach(Card card in _deck)
                {
                    // Si une carte correspond à la couleur et la valeur elle est mise a jour
                    if (card.Couleur == couleur && card.Valeur == valeur)
                    {
                        c = card;
                        break;
                    }
                }

                if (c is null)
                {
                    _deck.Add(new Card { Couleur = couleur, Valeur = valeur });
                }
            }
        }

        // Méthode d'initialisation du deck avec toutes les combinaisons valeurs / couleurs possible
        internal void InitDeck()
        {
            // Parcours des noms des couleurs de l'enum Couleurs
            // Enum.GetNames va permettre de rassembler toutes les valeurs de l'enum sous la forme d'un tableau
            // Ce qui va nous permettre d'itérer dedans
            foreach(string color in Enum.GetNames(typeof(Couleurs)))
            {
                // Parcours des noms des valeurs de l'enum Valeurs
                foreach (string value in Enum.GetNames(typeof(Valeurs)))
                {
                    // Instanciation d'une nouvelle carte pour chaque combinaison
                    Card card = new Card
                    {
                        Couleur = Enum.Parse<Couleurs>(color),
                        Valeur = Enum.Parse<Valeurs>(value)
                    };

                    // Ajout de la carte dans le deck
                    _deck.Add(card);
                }
            }
        }
    }
}
