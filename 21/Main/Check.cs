using _21.Frame;
namespace _21
{
    internal class Check
    {
        public static string? Text { get; private set; }

        public static bool player_haveCombination = false;
        public static bool opponent_haveCombination = false;

        public static void WhoWin()
        {
            int playerSum = Sum(Game.Player.Cards);
            int opponentSum = Sum(Game.Opponent.Cards);

            if (opponentSum > 21 && playerSum > 21)
            {
                Text = "Ничья!";
                FramePool.Draw();
            }
            else if (playerSum > 21 || (opponentSum > playerSum && opponentSum <= 21) || opponent_haveCombination)
            {
                Text = "Вы проиграли!";
                FramePool.Draw();
            }
            else if (opponentSum > 21 || (playerSum > opponentSum && playerSum <= 21) || player_haveCombination)
            {
                Text = "Вы выиграли!";
                FramePool.Draw();
            }
            else
            {
                Text = "Ничья!";
                FramePool.Draw();
            }
        }

        public static int Sum(Card[] cards)
        {
            int sum = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    sum += cards[i].Number;
                }
            }
            return sum;
        }
        public static void Combinations()
        {
            player_haveCombination.Combination(Game.Player.Cards);
            opponent_haveCombination.Combination(Game.Opponent.Cards);
        }
    }

    static class Extentions
    {
        internal static bool Combination(this bool nonUse, Card[] cards)
        {
            int cardsLength = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    cardsLength++;
                }
                else
                {
                    break;
                }
            }

            if (cardsLength == 2)
            {
                if (cards[0].Word == "A" && cards[1].Word == "A") // Золотое очко
                {
                    return true;
                }

                if (cards[0].Word == "A" && cards[1].Word == "10") // Натуральное очко
                {
                    return true;
                }
            }

            if (cardsLength == 3)
            {
                int triple = 0;
                for (int i = 0; i < 3; i++) // 678 или 777
                {
                    if (cards[i].Number == 6 + i)
                    {
                        triple++;
                    }
                    else if (cards[i].Number == 7)
                    {
                        triple++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (triple == 3)
                {
                    return true;
                }
            }

            if (cardsLength == 5) // Пять картинок
            {
                int exist = 0;

                string[] word = { "J", "K", "Q" };

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (cards[i].Word == word[j])
                        {
                            exist++;
                        }
                    }
                    if (exist == 0)
                    {
                        return false;
                    }
                }

                if (exist == 5)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
