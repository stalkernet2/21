namespace _21.Frames
{
    class InGame : AbstractFrame
    {
        public override void Make()
        {
            Console.WriteLine("GameDrawed");
            Graphic.ShowHiddenOf(Game.Opponent.Cards);
            Graphic.ShowCardsOf(Game.Player.Cards);
            //Console.WriteLine(Graphic.ShowCardsOf(Game.Player.Cards));
            //Console.WriteLine(Graphic.ShowCardsOf(Game.Opponent.Cards)); // debug
        }

    }
}
