namespace _21.Frame
{
    interface IFrame : ISome
    {
        public void Show()
        {
            Console.Clear();
            Console.WriteLine(Graphic.Border(false));
            Make();
            Console.WriteLine(Graphic.Border(true));
        }

        public void Make();
    }
}
