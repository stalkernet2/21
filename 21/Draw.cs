using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Draw
    {
        internal static void Menu()
        {
            Console.WriteLine("MenuDrawed");
        }
        internal static void Game(int[] player, int[] opponent)
        {
            Console.WriteLine("GameDrawed");
            Console.WriteLine(DrawCardsOf(player));
            //Console.WriteLine(DrawCardsOf(opponent)); // debug
        }
        internal static void WinScreen(int[] player, int[] opponent)
        {
            Console.WriteLine("Вы выиграли");
            DrawEnd(player, opponent);
        }
        internal static void LoseScreen(int[] player, int[] opponent)
        {
            Console.WriteLine("Вы проиграли");

            DrawEnd(player, opponent);
        }
        internal static void drawScreen(int[] player, int[] opponent)
        {
            Console.WriteLine("Ничья");

            DrawEnd(player, opponent);
        }

        private static string DrawCardsOf(int[] cards)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == 0)
                    sb.Append("  ");
                else if (i < cards.Length - 1)
                    sb.Append(cards[i] + " ");
                else
                    sb.Append(cards[i]);
            }
            return sb.ToString();
        }
        private static void DrawEnd(int[] player, int[] opponent)
        {
            Console.WriteLine("Ваши карты");
            Console.WriteLine(DrawCardsOf(player));
            Console.WriteLine("Карты опонента");
            Console.WriteLine(DrawCardsOf(opponent));
            Program.gameStart = false;
            Console.ReadKey();
        }
    }
}
