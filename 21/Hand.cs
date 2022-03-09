using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Hand
    {
        public int[] Cards = new int[8];

        private int CardPosition = 0;
        private bool FirstDraw = true;
        public void Draw()
        {
            if(FirstDraw)
            {
                FirstDraw = false;
                Draw();
            }
            Random random = new Random();
            Cards[CardPosition] = Deck.Cards[random.Next(0, Deck.Cards.Rank), random.Next(0, Deck.CardsLength)];
            CardPosition++;
        }
        public void IsItWorthTaking(int sumCards)
        {
            Random rand = new Random();
            if(sumCards < 16)
            {
                int randnum = rand.Next(0, 4);
                if(randnum % 2 == 0)
                {
                    Draw();
                }
            }
        }
    }
}
