namespace _21
{
    public class Control
    {
        public static void WhichKeyWasPress(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Escape:
                    if (FramePool.Index != (int)Player.In.Menu)
                    {
                        FramePool.Index = (int)Player.In.Menu;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
                case ConsoleKey.Spacebar:
                    if (FramePool.Index == (int)Player.In.Game)
                    {
                        if (Game.Player.Cards.Sum() >= 21)
                        {
                            goto case ConsoleKey.Enter;
                        }
                        else
                        {
                            Game.Player.Draw();
                        }
                        if (Game.Opponent.Cards.Sum() <= 21)
                        {
                            Game.Opponent.Draw();
                        }
                    }
                    break;
                case ConsoleKey.Enter:
                    if (FramePool.Index != (int)Player.In.Game)
                    {
                        Menu.Select();
                    }
                    else
                    {
                        int cardSum = Game.Opponent.Cards.Sum();
                        while (cardSum < 16)
                        {
                            Game.Opponent.IsItWorthTaking(cardSum);
                            cardSum = Game.Opponent.Cards.Sum();
                        }
                        FramePool.Index = (int)Player.In.End;
                        Check.WhoWin();
                        Console.ReadKey();
                    }
                    break;
                case ConsoleKey.UpArrow:
                    Menu.Index -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    Menu.Index += 1;
                    break;
            }
        }
    }
}
