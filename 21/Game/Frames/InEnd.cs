namespace _21.Frames
{
    class InEnd : AbstractFrame
    {
        public override void Make()
        {
            Console.WriteLine(Check.Text);
            Console.WriteLine("Ваши карты");
            Graphic.ShowCardsOf(Game.Player.Cards);

            //Console.WriteLine(Graphic.ShowCardsOf(Game.Player.Cards));
            Console.WriteLine("\nКарты опонента");
            Graphic.ShowCardsOf(Game.Opponent.Cards);
            //Console.WriteLine(Graphic.ShowCardsOf(Game.Opponent.Cards));
            FramePool.Index = (int)Player.In.Menu;
        }
    }
}
