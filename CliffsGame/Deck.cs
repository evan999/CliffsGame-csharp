using System;
using System.Collections.Generic;
using System.Text;

namespace CliffsGame
{
    public class Deck 
    {
        static readonly Random random = new Random();
        readonly List<Card> deck = new List<Card>(52);

        public Deck()
        {
            for (int face = 2; face <= 13; face++)
            {
                for (int suit = 1; suit <= 4; suit++)
                {
                    Card card = new Card(face, suit);
                    deck.Add(card);
                }
            }
        }
        public List<Card> Shuffle()
        {
            List<Card> shuffled = new List<Card>();
            for (int card = shuffled.Count - 1; card > 0; card--)
            {
                int rand = random.Next(card + 1);
                if (rand != card)
                {
                    Card cardR = shuffled[rand];
                    shuffled[rand] = shuffled[card];
                    shuffled[card] = cardR;
                }
            }
            return shuffled;
        }

    }
}
