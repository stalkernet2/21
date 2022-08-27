using _21.Frame;
using _21.Controls;

namespace _21
{
    public class Game
    {
        public static Hand Player;
        public static Hand Opponent;

        public static Deck Pack;
        public static IMenuProvider MainMenu = new DefaultMenu();

        public static void Start()
        {
            while (true)
            {
                FramePool.Draw();

                Control.WhichKeyWasPress(Console.ReadKey().Key);
            }
        }
    }
}
