using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Control
    {
        public static void WhichKeyWasPress(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    if (Game.menu && !Game.gameStart)
                    {
                        Environment.Exit(0);
                    }
                    else if (Game.gameStart)
                    {
                        Game.gameStart = false;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    if (Game.gameStart)
                    {
                        Game.player.Draw();
                        if (Check.Sum(Game.opponent.Cards) < 21)
                        {
                            Game.opponent.Draw();
                        }
                    }
                    break;
                case ConsoleKey.Enter:
                    if (!Game.gameStart)
                    {
                        Game.gameStart = true;
                    }
                    else
                    {
                        Game.opponent.IsItWorthTaking(Check.Sum(Game.opponent.Cards));
                        Check.WhoWin(Game.player.Cards, Game.opponent.Cards);
                    }
                    break;
                case ConsoleKey.UpArrow:
                    Menu.Index -= 1;
                    Console.WriteLine(Menu.Index);
                    break;
                case ConsoleKey.DownArrow:
                    Menu.Index += 1;
                    Console.WriteLine(Menu.Index);
                    break;
                default:
                    break;
            }
        }
    }
}
