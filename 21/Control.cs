using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    internal class Control
    {
        internal static void WhichKeyWasPress(ConsoleKeyInfo key)
        {
            switch (key.KeyChar)
            {
                case (char)ConsoleKey.Escape:
                    if (Program.menu && !Program.gameStart)
                    {
                        Environment.Exit(0);
                    }
                    else if (Program.gameStart)
                    {
                        Program.gameStart = false;
                    }
                    break;
                case (char)ConsoleKey.Spacebar:
                    if (Program.gameStart)
                    {
                        Program.player.Draw();
                        if (Check.Sum(Program.opponent.Cards) < 21)
                        {
                            Program.opponent.Draw();
                        }
                    }
                    break;
                case (char)ConsoleKey.Enter:
                    if (!Program.gameStart)
                    {
                        Program.gameStart = true;
                    }
                    else
                    {
                        Check.WhoWin(Program.player.Cards, Program.opponent.Cards);
                    }
                    break;
                default:
                    WhichKeyWasPress(Console.ReadKey());
                    break;
            }
        }
    }
}
