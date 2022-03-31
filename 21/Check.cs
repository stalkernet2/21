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
            int playerSum = playerCards.Sum();
            int opponentSum = opponentCards.Sum();

            if (opponentSum >= 21 && playerSum >= 21)
            {
                Frame.Draw(playerCards, opponentCards);
            }
            else if (playerSum > 21 || (opponentSum > playerSum && opponentSum <= 21))
            {
                Frame.Lose(playerCards, opponentCards);
            }
            else if (opponentSum > 21 || (playerSum > opponentSum && playerSum <=21))
            {
                Frame.Win(playerCards, opponentCards);
            }
            else
            {
                Frame.Draw(playerCards, opponentCards);
            }
        }
    }
}
