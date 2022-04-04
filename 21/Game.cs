using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Game
    {
        public static Hand Player = new Hand();
        public static Hand Opponent = new Hand();

        public static void Start()
        {
            while (true)
            {
                Frame.Draw();

                Control.WhichKeyWasPress(Console.ReadKey().Key);
            }
        }
    }
}
