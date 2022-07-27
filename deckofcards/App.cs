using System;
using System.Collections.Generic;
using System.Text;

namespace deckofcards
{
    public class App
    {
        public List<CardClass> Cards = new List<CardClass>();

        public App()
        {
        }

        public string Choice()
        {
            Console.WriteLine("Deck of Cards");
            Console.WriteLine("1 - Create");
            Console.WriteLine("2 - Shuffle");
            Console.WriteLine("3 - Deal");
            Console.WriteLine("4 - Display Deck");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            return choice;
        }

        public void CreateDeck()
        {
            Cards.Clear();
            foreach (string suit in Enum.GetNames(typeof(Suits)))
            {
                foreach (string rank in Enum.GetNames(typeof(Ranks)))
                {
                    CardClass card = new CardClass();
                    card.suit = suit;
                    card.rank = rank;
                    Cards.Add(card);
                }
            }
            Console.WriteLine("New deck created!");
        }

        public void ShuffleDeck()
        {
            if (Cards.Count > 0)
            {
                for (int i = 0; i < Cards.Count; i++)
                {
                    Random rand = new Random();
                    int j = rand.Next(0, Cards.Count - 1);

                    var temp = Cards[i];
                    Cards[i] = Cards[j];
                    Cards[j] = temp;
                }
                Console.WriteLine("Deck shuffled.");
            }
            else
            {
                Console.WriteLine("Deck is empty!");
            }

        }

        public void DisplayDeck()
        {
            if (Cards.Count > 0)
            {
                for (int i = 0; i < Cards.Count; i++)
                {
                    Console.WriteLine("Suit: " + Cards[i].suit.PadRight(10) + "Rank: " + Cards[i].rank);
                }
            }

            Console.WriteLine("Number of cards: " + Cards.Count);
        }

        public void Deal(int num)
        {
            if (Cards.Count >= num)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Suit: " + Cards[0].suit.PadRight(10) + " Rank: " + Cards[0].rank);
                    Cards.RemoveAt(0);
                }
            }
            else
            {
                Console.WriteLine("Cammot deal if deck has less cards than the asked numeber.");
            }
        }
    }
}
