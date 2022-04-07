namespace _21.Frames
{
    class InEnd : IFrame
    {
        public void Make()
        {

            Console.WriteLine(Check.Text);
            Console.WriteLine("Ваши карты");
            Console.WriteLine(Graphic.ShowCardsOf(Game.Player.Cards));
            Console.WriteLine("Карты опонента");
            Console.WriteLine(Graphic.ShowCardsOf(Game.Opponent.Cards));
            FramePool.Index = (int)Player.In.Menu;
        }
    }
}
