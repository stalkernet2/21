namespace _21.Frame.Frames
{
    class InEnd : IFrame
    {
        public void Make()
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
