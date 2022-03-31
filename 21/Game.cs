using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Game
    {
        public static bool InMenu = true;
        public static bool GameStart = false;
        public static bool GameEnded = false;

        public static Hand Player = new Hand();
        public static Hand Opponent = new Hand();

        public static void Start()
        {
            while (InMenu)
            {
                Player = new Hand();
                Opponent = new Hand();
                Frame.Main1();

                Control.WhichKeyWasPress(Console.ReadKey());

                while (GameStart)
                {
                    Frame.InGame(Player.Cards, Opponent.Cards);

                    Control.WhichKeyWasPress(Console.ReadKey());
                }
            }
        }
    }
}
