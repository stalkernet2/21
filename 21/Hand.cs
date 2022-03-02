using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Hand
    {
        internal int[] Cards = new int[8];

        private int CardPosition = 0;
        internal void Draw()
        {
            Random random = new Random();
            Cards[CardPosition] = Deck.Cards[random.Next(0, Deck.Cards.Rank), random.Next(0, Deck.CardsLength)];
            CardPosition++;
        }
        internal void IsItWorthTaking()
        {

        }
    }
}
