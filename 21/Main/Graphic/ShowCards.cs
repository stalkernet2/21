using ColoredObj;

namespace _21
{
    public partial class Graphic
    {
        public static void ShowHiddenOf(Card[] cards)
        {
            Console.Write(ToSide(ExistingCards(cards) * 5));
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == null)
                    break;

                Colored.Text(ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ' ');
                Colored.Text(ConsoleColor.Blue, ConsoleColor.Blue, ' ');
                Colored.Text(ConsoleColor.Blue, ConsoleColor.Blue, ' ');
                Colored.Text(ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ' ');
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        public static void ShowCardsOf(Card[] cards)
        {
            Console.Write(ToSide(ExistingCards(cards) * 5));

            for (int i = 0; i < cards.Length; i++)
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

        private static int ExistingCards(Card[] cards)
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
