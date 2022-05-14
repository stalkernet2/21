using ColoredObj;
using System.Text;

namespace _21
{
    public class Graphic
    {
        private static readonly int BorderSize = 3;
        private static readonly char[] BorderChars = new char[4] { '\u2588', '\u2593', '\u2592', '\u2591' };

        public static void ShowHiddenOf(card[] cards)
        {
            Console.Write(ToSide(ExistingCards(cards) * 5));
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    Colored.Text(ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ' ');
                    Colored.Text(ConsoleColor.Blue, ConsoleColor.Blue, ' ');
                    Colored.Text(ConsoleColor.Blue, ConsoleColor.Blue, ' ');
                    Colored.Text(ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ' ');
                    Console.Write(' ');
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        public static void ShowCardsOf(card[] cards)
        {
            Console.Write(ToSide(ExistingCards(cards) * 5));

            for(int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    string space = cards[i].Number > 9 && cards[i].Word != "A" ? " " : "  ";

                    Colored.Text(cards[i].Color, ConsoleColor.White, cards[i].Word + space + cards[i].Sumbol);
                    Console.Write(" ");
                }
                else
                {
                    break;
                }
            }
        }

        public static void InverseText(string text)
        {
            Colored.InverseText(text);
        }

        public static string Border(bool inDown)
        {

            StringBuilder borderLine = new StringBuilder();

            for (int i = 0; i < BorderSize; i++)
            {
                for (int j = 0; j < Console.WindowWidth - 1; j++)
                {
                    borderLine.Append(BorderChars[i]);
                }
                if (i != BorderSize - 1)
                {
                    borderLine.Append('\n');
                }
            }

            switch (inDown)
            {
                case false:
                    return borderLine.ToString();
                case true:
                    string space = "";

                    for (int i = 0; i < (Console.WindowHeight - (Console.CursorTop + 4)); i++)
                    {
                        space += "\n";
                    }
                    return space + TrueReverse(borderLine);
            }
        }

        public static string ToCenterX(string offsetText)
        {
            int spaceLength = (Console.WindowWidth - offsetText.Length) / 2 - 2;
            string space = "";
            for (int i = 0; i <= spaceLength; i++)
            {
                space += " ";
            }
            return space + offsetText + space;
        }

        public static void ToCenterY(int offset)
        {
            for (int j = 0; j < Console.WindowHeight / 2 - (offset - 2) - 4; j++)
            {
                Console.WriteLine();
            }
        }

        public static string ToSide(string text)
        {
            int spaceLength = (Console.WindowWidth - text.Length) / 2 - 2;
            string space = "";
            for (int i = 0; i <= spaceLength; i++)
            {
                space += " ";
            }
            return space;
        }

        public static string ToSide(int offset)
        {
            int spaceLength = (Console.WindowWidth - offset) / 2 - 2;
            string space = "";
            for (int i = 0; i <= spaceLength; i++)
            {
                space += " ";
            }
            return space;
        }

        private static string TrueReverse(StringBuilder text)
        {
            char[] reverseChar = text.ToString().Reverse().ToArray();
            return new string(reverseChar);
        }

        private static int ExistingCards(card[] cards)
        {
            int offset = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                    offset++;
                else
                    break;
            }
            return offset;
        }
    }
}
