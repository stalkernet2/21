namespace _21
{
    internal class Check
    {
        public static void WhoWin()
        {
            int playerSum = Game.Player.Cards.Sum();
            int opponentSum = Game.Opponent.Cards.Sum();

            if (opponentSum >= 21 && playerSum >= 21)
            {
                Frame.DrawEnd("Ничья!");
            }
            else if (playerSum > 21 || (opponentSum > playerSum && opponentSum <= 21))
            {
                Frame.DrawEnd("Вы проиграли!");
            }
            else if (opponentSum > 21 || (playerSum > opponentSum && playerSum <= 21))
            {
                Frame.DrawEnd("Вы выиграли!");
            }
            else
            {
                Frame.DrawEnd("Ничья!");
            }
        }
    }
}
