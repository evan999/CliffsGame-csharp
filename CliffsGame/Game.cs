using System;
using System.Collections.Generic;
using System.Text;

namespace CliffsGame
{
    public class Game 
    {
        public List<Card> discardPile = new List<Card>();
        public List<Player> players = new List<Player>();
        public Game()
        {
            Deck deck = new Deck();
            StartGame();

        }



        public void Discard(Card card)
        {
            discardPile.Add(card);
        }

        public void StartGame()
        {
            if(players.Count < 1)
            {
                AddPlayer();
            }
            //Shuffle();
            //Deck.Shuffle();
        }

        public void AddPlayer()
        {
            int playerCount = players.Count;
            int maxPlayers = 4;

            if(playerCount >= maxPlayers)
            {
                Console.WriteLine("Can't add any more players");
            }
            else
            {
                players.Add(new Player());
            }
        }
    }
}
