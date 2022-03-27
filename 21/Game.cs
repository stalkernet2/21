using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Game
    {
        public static bool menu = true;
        public static bool gameStart = false;
        public static bool gameEnded = false;

        public static Hand player = new Hand();
        public static Hand opponent = new Hand();

        public static void Start()
        {
            while (menu)
            {
                player = new Hand();
                opponent = new Hand();
                Frame.Menu();

                Control.WhichKeyWasPress(Console.ReadKey());

                while (gameStart)
                {
                    Frame.Session(player.Cards, opponent.Cards);

                    Control.WhichKeyWasPress(Console.ReadKey());
                }
            }
        }
    }
}
