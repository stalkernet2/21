using System;
using System.Collections.Generic;
using System.Linq;

namespace _21
{
    public class Program
    {
        public static bool menu = true;
        public static bool gameStart = false;
        public static bool gameEnded = false;

        public static Hand player = new Hand();
        public static Hand opponent = new Hand();
        public static void Main(string[] args)
        {
            while (menu)
            {
                player = new Hand();
                opponent = new Hand();
                Draw.Menu();

                Control.WhichKeyWasPress(Console.ReadKey());
               
                while (gameStart)
                {
                    Draw.Game(player.Cards, opponent.Cards);

                    Control.WhichKeyWasPress(Console.ReadKey());
                }
            }
        }
        
    }
}
