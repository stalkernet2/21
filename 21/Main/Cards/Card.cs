namespace _21
{
    public class Card
    {
        public ConsoleColor Color { get; private set; }
        public int Number { get; private set; }
        public char Sumbol { get; private set; }
        public string Word { get; private set; }

        public Card(ConsoleColor color, int num, char sybmol, string word)
        {
            Color = color;
            Number = num;
            Sumbol = sybmol;
            Word = word;
        }
    }
}
