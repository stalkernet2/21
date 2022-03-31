namespace _21
{
    internal class Deck
    {
        private static readonly int[,] cards = new int[,]{  { 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 },
                                                            { 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 },
                                                            { 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 },
                                                            { 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 }};
        public static int[,] Cards = new int[4,52];
        public static void Init()
        {
            Array.Copy(cards, Cards, cards.Length);
        }
    }
}
