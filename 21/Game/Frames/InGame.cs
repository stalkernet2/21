namespace _21.Frames
{
    class InGame : IFrame
    {
        public void Make()
        {
            Console.WriteLine("GameDrawed");
            Console.WriteLine(Graphic.ShowCardsOf(Game.Player.Cards));
            Console.WriteLine(Graphic.ShowCardsOf(Game.Opponent.Cards)); // debug
        }

    }
}
