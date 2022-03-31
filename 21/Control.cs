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
                    if (Game.InMenu && !Game.GameStart)
                    {
                        Environment.Exit(0);
                    }
                    else if (Game.GameStart)
                    {
                        Game.GameStart = false;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    if (Game.GameStart)
                    {
                        Game.Player.Draw();
                        if (Game.Opponent.Cards.Sum() <= 21)
                        {
                            Game.Opponent.Draw();
                        }
                    }
                    break;
                case ConsoleKey.Enter:
                    if (!Game.GameStart)
                    {
                        Menu.Selected();
                    }
                    else
                    {
                        int cardSum = Game.Opponent.Cards.Sum();    
                        while (cardSum < 16)
                        {
                            Game.Opponent.IsItWorthTaking(cardSum);
                            cardSum = Game.Opponent.Cards.Sum();
                        }
                        Check.WhoWin(Game.Player.Cards, Game.Opponent.Cards);
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
