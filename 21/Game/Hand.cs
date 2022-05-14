namespace _21
{
    public class Hand
    {
        public card[] Cards = new card[10];

        private int CardPosition = 0;

        public void Take()
        {
            Random random = new Random();
            int[] position = new int[2];

            do
            {
                position[0] = random.Next(0, 4);
                position[1] = random.Next(0, 13);

                Cards[CardPosition] = Game.Pack.Cards[position[0], position[1]];
            } while (Cards[CardPosition] == null);

            Array.Clear(Game.Pack.Cards, (position[0] * 13) + position[1], 1);
            CardPosition++;
        }

        public void IsItWorthTaking(int sumCards)
        {
            Random rand = new Random();
            if (sumCards < 15)
            {
                Take();
            }
            else
            {
                int randnum = rand.Next(0, 103);
                if (randnum % 3 == 0)
                {
                    Take();
                }
            }
        }
    }
}
