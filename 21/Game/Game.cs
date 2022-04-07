namespace _21
{
    public class Game
    {
        public static Hand Player = new Hand();
        public static Hand Opponent = new Hand();

        public static Deck Pack = new Deck();

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
