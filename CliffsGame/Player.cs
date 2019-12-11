using System;
using System.Collections.Generic;
using System.Text;

namespace CliffsGame
{
    public class Player : Game
    {
        public List<Card> hand = new List<Card>(8);

        public void DealHand()
        {

            for(int card = 0; card < 8; card++)
            {
                hand.Add(new Card());
            }
        }

        public void Exchange()
        {
            // Remove selected card from hand
            // Add new card drawn from top of deck to player's hand
            // Add discarded card to the discard pile.
            Console.WriteLine("What card do you want to exchange? Enter face, suit");
            string exchangedCard = Console.ReadLine();
            string[] cardValues = exchangedCard.Split(',');
            string faceValue = cardValues[0];
            string suitValue = cardValues[1];
            int cardFaceValue = int.Parse(cardValues[0].ToString());
            int cardSuitValue = int.Parse(cardValues[1].ToString());






            //hand.Remove(hand[0]);
            //discardPile.Add(hand[0]);
        }

    }
}
