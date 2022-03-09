using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Check
    {
        public static void WhoWin(int[] playerCards, int[] opponentCards)
        {
            int playerSum = Sum(playerCards);
            int opponentSum = Sum(opponentCards);

            if (opponentSum > 21 && playerSum > 21)
            {
                Draw.drawScreen(playerCards, opponentCards);
            }
            else if (playerSum > 21 || (opponentSum > playerSum && opponentSum <= 21))
            {
                Draw.LoseScreen(playerCards, opponentCards);
            }
            else if (opponentSum > 21 || (playerSum > opponentSum && playerSum <=21))
            {
                Draw.WinScreen(playerCards, opponentCards);
            }
            
        }

        public static int Sum(int [] cards)
        {
            int sum = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                sum += cards[i];
            }
            return sum;
        }
    }
}
