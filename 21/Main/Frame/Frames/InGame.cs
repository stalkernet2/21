namespace _21.Frame.Frames
{
    class InGame : IFrame
    {
        public void Make()
        {
            Console.WriteLine("GameDrawed");
            Graphic.ShowHiddenOf(Game.Opponent.Cards);
            Graphic.ShowCardsOf(Game.Player.Cards);
            //Console.WriteLine(Graphic.ShowCardsOf(Game.Player.Cards));
            //Console.WriteLine(Graphic.ShowCardsOf(Game.Opponent.Cards)); // debug
        }

    }
}
