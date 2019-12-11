using System;
using System.Collections.Generic;
using System.Text;

namespace CliffsGame
{
    public class Card
    {
        public int Face { get; set; }
        public int Suit { get; set; }

        //public bool activeCard;

        Random random = new Random();

        //Array faceValues = Enum.GetValues(typeof(Face));
        //Array suitValues = Enum.GetValues(typeof(Suit));

        public Card()
        {

        }

        public Card(int face, int suit)
        {
            Face = face;
            Suit = suit;
        }


        public Card DrawCard()
        {
            // int card1Value = GetCardValue(card1);
            Card card = new Card(random.Next(2, 14), random.Next(0,3));
           // card.face = random.Next(2, 14);
           // card.suit = random.Next(0, 3);
            // int card2Value = random.Next(1, 13);
            return card;
        }
    }
}
