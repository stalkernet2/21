using System.Text;

namespace _21
{
    public class Draw
    {
        private static int _borderSize = 5;
        private static char[] _chars = new char[4] { '\u2588', '\u2593', '\u2592', '\u2591' };
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(BorderY(1));
            for (int i = 0; i < Console.WindowHeight - 7; i++)
            {
                Console.WriteLine();
            }
            //Console.WriteLine(BorderX(""));
            //Console.WriteLine(BorderX("███████████    ███"));
            //Console.WriteLine(BorderX("███     ███    ███"));
            //Console.WriteLine(BorderX("      ███      ███"));
            //Console.WriteLine(BorderX("   ███         ███"));
            //Console.WriteLine(BorderX("████           ███"));
            //Console.WriteLine(BorderX("███████████    ███"));
            Console.WriteLine(BorderY(-1));
            //Console.WriteLine(ToCenter("MenuDrawed"));
        }
        public static void Game(int[] player, int[] opponent)
        {
            Console.Clear();
            Console.WriteLine("GameDrawed");
            Console.WriteLine(DrawCardsOf(player));
            Console.WriteLine(DrawCardsOf(opponent)); // debug
        }
        public static void WinScreen(int[] player, int[] opponent)
        {
            Console.Clear();
            Console.WriteLine("Вы выиграли");

            DrawEnd(player, opponent);
        }
        public static void LoseScreen(int[] player, int[] opponent)
        {
            Console.Clear();
            Console.WriteLine("Вы проиграли");

            DrawEnd(player, opponent);
        }
        public static void drawScreen(int[] player, int[] opponent)
        {
            Console.Clear();
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
        private static string BorderY(int offset)
        {
            
            StringBuilder borderLine = new StringBuilder();

            for (int i = 0; i < _borderSize - 2; i++)
            {
                for (int j = 0; j < Console.WindowWidth; j++)
                {
                    borderLine.Append(_chars[i]);
                }
                if (i != _borderSize - 3)
                {
                    borderLine.Append('\n');
                }
            }
            
            switch(offset)
            {
                case 1:
                    return borderLine.ToString();
                case -1:
                    return TrueReverse(borderLine);
                default:
                    throw new Exception();
            }    
        }
        private static string BorderX(string text)
        {
            StringBuilder Line = new StringBuilder();

            for (int i = 0; i < _borderSize - 2; i++)
            {
                Line.Append(_chars[i]);
            }
            for(int i = 0; i < (Console.WindowWidth - text.Length - (_borderSize * 2)) / 2; i++)
            {
                Line.Append(' ');
            }

            return Line.ToString() + text + TrueReverse(Line);
        }
        private static string TrueReverse(StringBuilder text)
        {
            char[] reverseChar = text.ToString().Reverse().ToArray();
            StringBuilder reverseFinal = new StringBuilder();

            for (int i = 0; i < reverseChar.Length; i++)
            {
                reverseFinal.Append(reverseChar[i]);
            }

            return reverseFinal.ToString();
        }
    }
}
