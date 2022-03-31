namespace _21
{
    public class Hand
    {
        public int[] Cards = new int[10];

        private int CardPosition = 0;
        private bool FirstDraw = true;
        public void Draw()
        {
            if (FirstDraw)
            {
                FirstDraw = false;
                Draw();
            }
            Random random = new Random();
            int[] position = new int[2];

            do
            {
                position[0] = random.Next(0, 4);
                position[1] = random.Next(0, Deck.Cards.Length / 13);

                Cards[CardPosition] = Deck.Cards[position[0], position[1]];
            } while (Cards[CardPosition] == 0);

            Array.Clear(Deck.Cards, (position[0] * 13) + position[1], 1);
            CardPosition++;
        }
        public void IsItWorthTaking(int sumCards)
        {
            Random rand = new Random();
            if (sumCards <= 10)
            {
                Draw();
            }
            else
            {
                int randnum = rand.Next(0, 4);
                if (randnum % 2 == 0)
                {
                    Draw();
                }
            }
        }
    }
}
