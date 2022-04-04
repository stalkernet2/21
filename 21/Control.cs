using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Control
    {
        public static void WhichKeyWasPress(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Escape:
                    if (Frame.Index != (int)Player.In.Menu)
                    {
                        Frame.Index = (int)Player.In.Menu;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
                case ConsoleKey.Spacebar:
                    if (Frame.Index == (int)Player.In.Game)
                    {
                        Game.Player.Draw();
                        if (Game.Opponent.Cards.Sum() <= 21)
                        {
                            Game.Opponent.Draw();
                        }
                    }
                    break;
                case ConsoleKey.Enter:
                    if (Frame.Index != (int)Player.In.Game)
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
                        Check.WhoWin();
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
