namespace _21
{
    public class Hand
    {
        public Card[] Cards = new Card[10];

        public bool HaveCombination = false;

        private int _cardPosition = 0;

        public void Take()
        {
            var random = new Random();
            int[] position = new int[2];

            do
            {
                position[0] = random.Next(0, 4);
                position[1] = random.Next(0, 10);

                Cards[_cardPosition] = Game.Pack.Cards[position[0], position[1]]; // длина масти уменьшилась
            } while (Cards[_cardPosition] == null);

            Array.Clear(Game.Pack.Cards, (position[0] * 10) + position[1], 1);
            _cardPosition++;
        }

        public void IsItWorthTaking(int sumCards)
        {
            var rand = new Random();
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
