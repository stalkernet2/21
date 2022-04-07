namespace _21
{
    internal class Check
    {
        public static string Text { get; private set; }
        public static void WhoWin()
        {
            int playerSum = Game.Player.Cards.Sum();
            int opponentSum = Game.Opponent.Cards.Sum();

            if (opponentSum >= 21 && playerSum >= 21)
            {
                Text = "Ничья!";
                FramePool.Draw();
            }
            else if (playerSum > 21 || (opponentSum > playerSum && opponentSum <= 21))
            {
                Text = "Вы проиграли!";
                FramePool.Draw();
            }
            else if (opponentSum > 21 || (playerSum > opponentSum && playerSum <= 21))
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
    }
}
