namespace _21
{
    public class card
    {
        public ConsoleColor Color { get; private set; }
        public int Number { get; private set; }
        public char Sumbol { get; private set; }
        public string Word { get; private set; }

        public card(ConsoleColor color, int num, char sybmol, string word)
        {
            Color = color;
            Number = num;
            Sumbol = sybmol;
            Word = word;
        }
    }
    public class Hearts : card
    {
        public Hearts(int num, string word) : base(ConsoleColor.Red, num, '♥', word)
        {
        }
    }
    public class Diamonds : card
    {
        public Diamonds(int num, string word) : base(ConsoleColor.Red, num, '♦', word)
        {
        }
    }
    public class Spades : card
    {
        public Spades(int num, string word) : base(ConsoleColor.Black, num, '♠', word)
        {
        }
    }
    public class Clubs : card
    {
        public Clubs(int num, string word) : base(ConsoleColor.Black, num, '♣', word)
        {
        }
    }
}
