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
                        Check.Combinations();

                        if (Check.Sum(Game.Player.Cards) > 21 || Check.player_haveCombination || Check.opponent_haveCombination)
                        {
                            goto case ConsoleKey.Enter;
                        }
                        else
                        {
                            Game.Player.Take();
                        }

                        if (Check.Sum(Game.Opponent.Cards) < 17)
                        {
                            Game.Opponent.Take();
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
                        int cardSum = Check.Sum(Game.Opponent.Cards);

                        while (cardSum < 17)
                        {
                            Game.Opponent.IsItWorthTaking(cardSum);
                            cardSum = Check.Sum(Game.Opponent.Cards);
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
